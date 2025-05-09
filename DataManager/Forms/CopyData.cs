﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DataManager
{
    public partial class CopyData : UserControl
    {
        public bool IsEnd = false;
        public string ErrorMessage = string.Empty;
        private bool _ShowMessage = true;

        private Log_Manager _LogManager = new Log_Manager();
        private Sql_Manager _SqlManager = null;
        private BackgroundWorker _BackgroundWorker = null;

        private List<string> _TableList = null;
        private List<string> _InvalidTableList = null;
        private Queue<string> _TableQueue = null;
        private Dictionary<string, List<string>> _ForeignKeyList = null;
        private string _SourceDbName = string.Empty;

        private int _BackgroundWorkerCount = -1;
        private DateTime _StepStartTime = new DateTime();
        private int _StepProcessSecond = 0;

        public EventHandler Close { get; set; }

        public CopyData()
        {
            InitializeComponent();
        }

        private enum Step
        {
            SEARCH_FK,
            NOCHECK_FK,
            TRANSFER_DATA,
            CHECK_FK
        }

        public void Initialize(List<string> tableList, string sourceDbName, int backgroundWorkerCount, ref Sql_Manager sqlManager, bool showMessage = true)
        {
            SetInitailizeStatus();
            IsEnd = false;

            setTableList(tableList);
            _SqlManager = sqlManager;
            _SourceDbName = sourceDbName;
            _BackgroundWorkerCount = backgroundWorkerCount;
            _ShowMessage = showMessage;

            SetBackgroundWorkerList();

            _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.WorkerReportsProgress = true;
            _BackgroundWorker.WorkerSupportsCancellation = true;
            _BackgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            _BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            _BackgroundWorker.RunWorkerAsync();
        }

        private void SetInitailizeStatus()
        {
            if (lc_ProcessTime.InvokeRequired)
            {
                Action setInitailizeStatus = delegate { SetInitailizeStatus(); };
                lc_ProcessTime.Invoke(setInitailizeStatus);
            }
            else
            {
                spb_Step.SelectedItemIndex = 0;
                lc_ProcessTime.Text = "000:00:00";
            }
        }

        private void setTableList(List<string> tableList)
        {
            _TableList = tableList;
            _TableQueue = new Queue<string>();
            for (int i = 0; i < tableList.Count; i++)
            {
                _TableQueue.Enqueue(tableList[i]);
            }

            SetTableCount(_TableList.Count - _TableQueue.Count, _TableList.Count);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_ShowMessage)
                _LogManager.AppendMaster("Copy Data", _SqlManager.ServerName);
            
            AppendDetailLog($"[{_SourceDbName}] => [{_SqlManager.Database}] 데이터 이전 시작");

            try
            {
                _InvalidTableList = new List<string>();

                bool exit = false;
                while (!exit)
                {
                    switch ((Step)spb_Step.SelectedItemIndex)
                    {
                        case Step.SEARCH_FK:
                            AppendDetailLog("FK 목록 조회 시작");
                            SearchForeignKey();
                            AppendDetailLog("FK 목록 조회 종료");
                            break;
                        case Step.NOCHECK_FK:
                            AppendDetailLog("FK 비활성화 시작");
                            SetForeignKey(false);
                            AppendDetailLog("FK 비활성화 종료");
                            break;
                        case Step.TRANSFER_DATA:
                            AppendDetailLog("데이터 복사 시작");
                            TransferTableData();
                            AppendDetailLog("데이터 복사 종료");
                            break;
                        case Step.CHECK_FK:
                            AppendDetailLog("FK 활성화 시작");
                            SetForeignKey(true);
                            AppendDetailLog("FK 활성화 종료");
                            exit = true;
                            break;
                    }
                }

                if (_InvalidTableList.Count > 0)
                    throw new Exception($"{string.Join(",", _InvalidTableList)} > not valid.");
            }
            catch (Exception ex)
            {
                if (_ShowMessage) {
                    AppendDetailLog(ex.Message, true);
                    MessageBox.Show(ex.Message);
                }
                else
                    ErrorMessage = ex.Message;
            }
        }

        private void AppendDetailLog(string logMessage, bool isError = false)
        {
            if (!_ShowMessage)
                return;
            
            _LogManager.AppendDetail(new Log_Manager.DetailData()
            {
                Result = isError ? "FAIL" : "SUCCESS",
                LogMessage = logMessage,
                ErrorMessage = isError ? logMessage : string.Empty
            });
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
                if (!_ForeignKeyList.ContainsKey(tableName))
                    _ForeignKeyList.Add(tableName, new List<string>());

                _ForeignKeyList[tableName].Add(foreignKeyName);
            }

            MoveNextStep();
        }

        private void SetForeignKey(bool isCheck)
        {
            SetStepStartTime();
            SetTableCount(0, _ForeignKeyList.Count);

            for (int i = 0; i < _ForeignKeyList.Count; i++)
            {
                SetTableCount(i + 1, _ForeignKeyList.Count);

                string tableName = _ForeignKeyList.Keys.ElementAt(i);
                List<string> foreignKeyNameList = _ForeignKeyList[tableName];
                for (int j = 0; j < foreignKeyNameList.Count; j++)
                {
                    string result = _SqlManager.SetForeignKey(tableName, foreignKeyNameList[j], isCheck);
                    if (result != string.Empty)
                        throw new Exception(result);
                }
            }

            if (!isCheck)
                MoveNextStep();
        }

        private void SetStepStartTime()
        {
            _StepStartTime = DateTime.Now;
            _StepProcessSecond = 0;
        }

        private void TransferTableData()
        {
            SetStepStartTime();

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

            // 대기
            while (true)
            {
                SetProcessTime();

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
                    {
                        MergeInvalidTableList(enabledBackroundWorkerList[i].InvalidTableList);
                        enabledBackroundWorkerList.RemoveAt(i);
                    }   
                }

                if (existException)
                {
                    for (int i = 0; i < enabledBackroundWorkerList.Count; i++)
                    {
                        enabledBackroundWorkerList[i].CancelBackgroundWorker();
                    }

                    for (int i = 0; i < enabledBackroundWorkerList.Count; i++)
                    {
                        while (enabledBackroundWorkerList[i].IsBusy) { }
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
            if (!_ShowMessage)
                IsEnd = true;
            else if (DialogResult.OK == MessageBox.Show("데이터 이전이 완료되었습니다."))
                FormClose();
        }

        private void FormClose()
        {
            for (int i = tlp_BWList.Controls.Count - 1; i >= 0; i--)
            {
                BackgroundWorkerProgress backgroundWorkerProgress = ((BackgroundWorkerProgress)tlp_BWList.Controls[i]);
                if (backgroundWorkerProgress.IsBusy)
                    backgroundWorkerProgress.CancelBackgroundWorker();
            }

            Close(this, null);
        }

        private void MergeInvalidTableList(List<string> invalidTableList)        
        {
            _InvalidTableList.AddRange(invalidTableList);
            _InvalidTableList.Sort();
        }

        private void SetBackgroundWorkerList()
        {
            if (tlp_BWList.InvokeRequired)
            {
                Action setBackgroundWorkerList = delegate { SetBackgroundWorkerList(); };
                tlp_BWList.Invoke(setBackgroundWorkerList);
            }
            else
            { 
                int backgroundWorkerIndex = 0;
                for (int i = tlp_BWList.Controls.Count - 1; i >= 0; i--)
                {
                    BackgroundWorkerProgress backgroundWorkerProgress = ((BackgroundWorkerProgress)tlp_BWList.Controls[i]);
                    backgroundWorkerProgress.Initialize(++backgroundWorkerIndex, _SourceDbName);
                    if (backgroundWorkerProgress.BackgroundWorkerSeq > _BackgroundWorkerCount)
                        backgroundWorkerProgress.Disabled();
                    else
                    {
                        backgroundWorkerProgress._GetTableInTableList = new BackgroundWorkerProgress.GetTableInTableList(GetTable);
                        backgroundWorkerProgress.ConnectDatabase(_SqlManager.ConnectionString);
                    }
                }
            }

            Process process = Process.GetCurrentProcess();
            foreach (ProcessThread processThread in process.Threads)
            {
                processThread.ProcessorAffinity = process.ProcessorAffinity;
            }
        }

        private void spb_Step_SelectedItemChanged(object sender, StepProgressBarSelectedItemChangedEventArgs e)
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
                currentItem.ContentBlock1.Description = $"Step {(stepProgressBar.SelectedItemIndex + 1)} of 4";
                currentItem.Options.ConnectorOffset = 0;
                if (stepProgressBar.SelectedItemIndex < 1)
                    stepProgressBar.Appearances.CommonActiveColor = Color.IndianRed;
                if (stepProgressBar.SelectedItemIndex >= 1 && stepProgressBar.SelectedItemIndex < 3)
                    stepProgressBar.Appearances.CommonActiveColor = Color.Goldenrod;
                if (stepProgressBar.SelectedItemIndex >= 3)
                    stepProgressBar.Appearances.CommonActiveColor = Color.Green;
            }
        }

        public string GetTable()
        {
            lock (_TableQueue)
            {
                string tableName = string.Empty;
                if (_TableQueue.Count > 0)
                    tableName = _TableQueue.Dequeue();

                SetTableCount(_TableList.Count - _TableQueue.Count, _TableList.Count);
                return tableName;
            }
        }

        private void SetTableCount(int currentCount, int totalCount)
        {
            if (pbc_TableProgress.InvokeRequired)
            {
                Action setTableCount = delegate { SetTableCount(currentCount, totalCount); };
                pbc_TableProgress.Invoke(setTableCount);
            }
            else
            {
                if (totalCount == 0)
                    pbc_TableProgress.Position = 0;
                else
                    pbc_TableProgress.Position = Convert.ToInt32(Convert.ToDouble(currentCount) / Convert.ToDouble(totalCount) * 100);
            }
        }

        private void SetProcessTime()
        {
            if (lc_ProcessTime.InvokeRequired)
            {
                Action setProcessTime = delegate { SetProcessTime(); };
                lc_ProcessTime.Invoke(setProcessTime);
            }
            else
            {
                DateTime currentTime = DateTime.Now;
                if ((currentTime - _StepStartTime).TotalSeconds != _StepProcessSecond)
                {
                    _StepProcessSecond = Convert.ToInt32((currentTime - _StepStartTime).TotalSeconds);

                    double _totalSeconds = _StepProcessSecond;
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
}
