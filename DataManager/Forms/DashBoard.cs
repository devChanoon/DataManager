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

namespace DataManager
{
    public partial class DashBoard : Form
    {
        private Sql_Manager _SqlManager = null;
        private List<string> _TableList = null;
        private Queue<string> _TableQueue = null;

        private Dictionary<string, List<string>> _ForeignKeyList = null;
        private bool isPositiveDirection = true;

        private BackgroundWorker _BackgroundWorker = null;
        private enum Step
        {
            SEARCH_FK = -1,
            NOCHECK_FK,
            TRANSFER_DATA,
            CHECK_FK,
            FINISH
        }

        public DashBoard(List<string> tableList, Sql_Manager sqlManager)
        {
            InitializeComponent();
            setTableList(tableList);
            _SqlManager = sqlManager;

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
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    while ((Step)spb_Step.SelectedItemIndex != Step.FINISH)
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
                                break;
                            case Step.CHECK_FK:
                                SetForeignKey(true);
                                break;
                        }
                    }

                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transactionScope.Dispose();
                }

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

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void SetBackgroundWorkerList()
        {
            int backgroundWorkerCount = Environment.ProcessorCount > 8 ? 8 : Environment.ProcessorCount;
            int backgroundWorkerIndex = 0;
            for (int i = tlp_BWList.Controls.Count - 1; i >= 0; i--)
            {
                BackgroundWorkerProgress backgroundWorkerProgress = ((BackgroundWorkerProgress)tlp_BWList.Controls[i]);
                backgroundWorkerProgress.SetTitle(++backgroundWorkerIndex);
                if (backgroundWorkerProgress.BackgroundWorkerSeq > backgroundWorkerCount)
                    backgroundWorkerProgress.Disabled();
                else
                {
                    backgroundWorkerProgress._GetTableInTableList = new BackgroundWorkerProgress.GetTableInTableList(GetTable);
                    backgroundWorkerProgress.ConnectDatabase(_SqlManager.ConnectionString);
                }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPositiveDirection)
            { 
                spb_Step.SelectedItemIndex++;
                if (spb_Step.SelectedItemIndex == spb_Step.Items.Count - 1)
                    isPositiveDirection = false;
            }
            else
            {
                spb_Step.SelectedItemIndex--;
                if (spb_Step.SelectedItemIndex == 0)
                    isPositiveDirection = true;
            }
        }

        public string GetTable()
        {
            if (_TableQueue.Count > 0)
                return _TableQueue.Dequeue();
            else
                return string.Empty;
        }
    }
}
