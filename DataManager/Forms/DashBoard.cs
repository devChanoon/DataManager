using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Transactions;
using System.Diagnostics;

namespace DataManager
{
    public partial class DashBoard : Form
    {
        private Sql_Manager _SqlManager = null;
        private BackgroundWorker _BackgroundWorker = null;

        private List<string> _TableList = null;
        private Queue<string> _TableQueue = null;
        private Dictionary<string, List<string>> _ForeignKeyList = null;
        private string _SourceDbName = string.Empty;

        private int _BackgroundWorkerCount = -1;
        
        private enum Step
        {
            SEARCH_FK,
            NOCHECK_FK,
            TRANSFER_DATA,
            CHECK_FK
        }

        public DashBoard(List<string> tableList, string sourceDbName, ref Sql_Manager sqlManager)
        {
            InitializeComponent();
            setTableList(tableList);
            _SqlManager = sqlManager;
            _SourceDbName = sourceDbName;

            SetBackgroundWorkerList();

            _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.WorkerReportsProgress = true;
            _BackgroundWorker.WorkerSupportsCancellation = true;
            _BackgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            _BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            _BackgroundWorker.RunWorkerAsync();
        }

        private void setTableList(List<string> tableList)
        {
            _TableList = tableList;
            _TableQueue = new Queue<string>();
            for (int i = 0; i < tableList.Count; i++)
            {
                _TableQueue.Enqueue(tableList[i]);
            }

            SetTableCount();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bool exit = false;
                while (!exit)
                {   
                    switch ((Step)spb_Step.SelectedItemIndex)
                    {
                        case Step.SEARCH_FK:
                            SearchForeignKey();
                            break;
                        case Step.NOCHECK_FK:
                            SetForeignKey(false);
                            break;
                        case Step.TRANSFER_DATA:
                            TransferTableData();
                            break;
                        case Step.CHECK_FK:
                            SetForeignKey(true);
                            exit = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoveNextStep()
        {
            if (spb_Step.InvokeRequired)
            {
                Action moveNextStep = delegate { MoveNextStep(); };
                spb_Step.Invoke(moveNextStep);
            }
            else
            {
                spb_Step.SelectedItemIndex++;
            }
        }

        private void SearchForeignKey()
        {
            _ForeignKeyList = new Dictionary<string, List<string>>();
            DataTable dataTable = _SqlManager.GetForeignKeyList();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string tableName = dataTable.Rows[i]["table_name"].ToString();
                string foreignKeyName = dataTable.Rows[i]["foreign_key_name"].ToString();
                if (_TableList.Contains(dataTable.Rows[i]["table_name"].ToString()))
                {
                    if (!_ForeignKeyList.ContainsKey(tableName))
                        _ForeignKeyList.Add(tableName, new List<string>());

                    _ForeignKeyList[tableName].Add(foreignKeyName);
                }
            }

            MoveNextStep();
        }

        private void SetForeignKey(bool isCheck)
        {
            for (int i = 0; i < _ForeignKeyList.Count; i++)
            {
                string tableName = _ForeignKeyList.Keys.ElementAt(i);
                List<string> foreignKeyNameList = _ForeignKeyList[tableName];
                for (int j = 0; j < foreignKeyNameList.Count; j++)
                {
                    string result = _SqlManager.SetForeignKey(tableName, foreignKeyNameList[j], isCheck);
                    if (result != string.Empty)
                        throw new Exception(result);
                }
            }

            MoveNextStep();
        }

        private void TransferTableData()
        {
            DateTime startTime = DateTime.Now;

            // 목록 초기화
            List<BackgroundWorkerProgress> enabledBackroundWorkerList = new List<BackgroundWorkerProgress>();
            for (int i = tlp_BWList.Controls.Count - 1; i >= 0; i--)
            {
                BackgroundWorkerProgress backgroundWorkerProgress = ((BackgroundWorkerProgress)tlp_BWList.Controls[i]);
                if (backgroundWorkerProgress.IsEnabled)
                {
                    enabledBackroundWorkerList.Add(backgroundWorkerProgress);
                }
            }

            // 시작 명령
            for (int i = 0; i < enabledBackroundWorkerList.Count; i++)
            {
                enabledBackroundWorkerList[i].RunBackgroundWorker();                
            }

            double timeSpanSecond = 0;
            // 대기
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                if ((currentTime - startTime).TotalSeconds != timeSpanSecond)
                {
                    timeSpanSecond = (currentTime - startTime).TotalSeconds;
                    SetProcessTime(timeSpanSecond);
                }

                bool allWorkerComplete = true;
                bool existException = false;
                string exceptionMessage = string.Empty;
                for (int i = enabledBackroundWorkerList.Count - 1; i >= 0; i--)
                {
                    if (enabledBackroundWorkerList[i].IsBusy)
                        allWorkerComplete = false;
                    else if (enabledBackroundWorkerList[i].IsException)
                    {
                        existException = true;
                        exceptionMessage = enabledBackroundWorkerList[i].ExceptionMessage;
                        break;
                    }   
                    else
                        enabledBackroundWorkerList.RemoveAt(i);
                }

                if (existException)
                { 
                    for (int i = 0; i < enabledBackroundWorkerList.Count; i++)
                    {
                        enabledBackroundWorkerList[i].CancelBackgroundWorker();
                    }
                    throw new Exception(exceptionMessage);
                }

                if (allWorkerComplete)
                    break;
            }

            // 완료
            MoveNextStep();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GC.Collect();
            if (DialogResult.OK == MessageBox.Show("데이터 이전이 완료되었습니다."))
            {
                FormClose();
            }
        }

        private void FormClose()
        {
            if (this.InvokeRequired)
            {
                Action close = delegate { FormClose(); };
                this.Invoke(close);
            }
            else
            {
                this.Close();
            }
        }


        private void SetBackgroundWorkerList()
        {
            int backgroundWorkerCount = Environment.ProcessorCount > 8 ? 8 : Environment.ProcessorCount;
            backgroundWorkerCount = _BackgroundWorkerCount > 0 ? _BackgroundWorkerCount : backgroundWorkerCount;
            int backgroundWorkerIndex = 0;
            for (int i = tlp_BWList.Controls.Count - 1; i >= 0; i--)
            {
                BackgroundWorkerProgress backgroundWorkerProgress = ((BackgroundWorkerProgress)tlp_BWList.Controls[i]);
                backgroundWorkerProgress.Initialize(++backgroundWorkerIndex, _SourceDbName);
                if (backgroundWorkerProgress.BackgroundWorkerSeq > backgroundWorkerCount)
                    backgroundWorkerProgress.Disabled();
                else
                {
                    backgroundWorkerProgress._GetTableInTableList = new BackgroundWorkerProgress.GetTableInTableList(GetTable);
                    backgroundWorkerProgress.ConnectDatabase(_SqlManager.ConnectionString);
                }
            }

            Process process = Process.GetCurrentProcess();
            foreach (ProcessThread processThread in process.Threads)
            {
                processThread.ProcessorAffinity = process.ProcessorAffinity;
            }
        }

        private void spb_Step_SelectedItemChanged(object sender, DevExpress.XtraEditors.StepProgressBarSelectedItemChangedEventArgs e)
        {
            StepProgressBar stepProgressBar = sender as StepProgressBar;
            foreach (StepProgressBarItem item in stepProgressBar.Items)
            {
                item.Options.Indicator.ActiveStateImageOptions.SvgImage = null;
                item.Options.Indicator.Width = 50;
                item.Options.ConnectorOffset = -20;
                item.ContentBlock1.Description = null;
            }

            var currentItem = e.SelectedItems.Last();
            if (currentItem != null)
            {
                currentItem.Options.Indicator.ActiveStateImageOptions.SvgImage = svgImageCollection1[0];
                currentItem.Options.Indicator.Width = 100;
                currentItem.ContentBlock1.Description = "Step " + (stepProgressBar.SelectedItemIndex + 1).ToString() + " of 4";
                currentItem.Options.ConnectorOffset = 0;
                if (stepProgressBar.SelectedItemIndex < 2)
                    stepProgressBar.Appearances.CommonActiveColor = Color.IndianRed;
                if (stepProgressBar.SelectedItemIndex >= 2 && stepProgressBar.SelectedItemIndex < 3)
                    stepProgressBar.Appearances.CommonActiveColor = Color.Goldenrod;
                if (stepProgressBar.SelectedItemIndex >= 3)
                    stepProgressBar.Appearances.CommonActiveColor = Color.Green;
            }
        }

        public string GetTable()
        {
            lock(_TableQueue)
            {
                string tableName = string.Empty;
                if (_TableQueue.Count > 0)                    
                    tableName = _TableQueue.Dequeue();

                SetTableCount();
                return tableName;
            }
        }

        private void SetTableCount()
        {
            if (pbc_TableProgress.InvokeRequired)
            {
                Action setTableCount = delegate { SetTableCount(); };
                pbc_TableProgress.Invoke(setTableCount);
            }
            else
            {   
                pbc_TableProgress.Position = Convert.ToInt32(Convert.ToDouble(_TableList.Count - _TableQueue.Count) / Convert.ToDouble(_TableList.Count) * 100); ;
            }
        }

        public void SetProcessTime(double totalSeconds)
        {
            if (lc_ProcessTime.InvokeRequired)
            {
                Action setProcessTime = delegate { SetProcessTime(totalSeconds); };
                lc_ProcessTime.Invoke(setProcessTime);
            }   
            else
            {
                double _totalSeconds = totalSeconds;
                int hours = (int)(_totalSeconds / 3600);
                _totalSeconds = _totalSeconds % 3600;
                int minutes = (int)(_totalSeconds / 60);
                _totalSeconds = _totalSeconds % 60;
                int seconds = (int)(_totalSeconds);

                lc_ProcessTime.Text = string.Format("{0:D3}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }
        }
    }
}
