using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraGrid;

namespace DataManager
{
    class BackgoundWorker_Manager
    {
        public delegate string GetTableInTableList();
        public GetTableInTableList _GetTableInTableList;
        public BackgroundWorkerProgress.SetStatusIdle _SetStatusIdle;
        public BackgroundWorkerProgress.SetStatusDelete _SetStatusDelete;
        public BackgroundWorkerProgress.SetStatusSearch _SetStatusSearch;
        public BackgroundWorkerProgress.SetStatusInsert _SetStatusInsert;
        public BackgroundWorkerProgress.SetStatusException _SetStatusException;
        public BackgroundWorkerProgress.ProgressChanged _ProgressChanged;

        private Sql_Manager _SqlManager = null;
        private BackgroundWorker _BackgroundWorker = null;
        private string _SourceDbName = string.Empty;
        private int _BackgroundWorkerSeq = 0;

        public bool IsBusy
        {
            get { return _BackgroundWorker.IsBusy; }
        }

        public void Initialize(string sourceDbName, int backgroundWorkerSeq, ref Sql_Manager sqlManager)
        {
            if (sqlManager == null)
            {
                _BackgroundWorker = null;
                _SqlManager = null;
            }
            else
            {
                _BackgroundWorker = new BackgroundWorker();
                _BackgroundWorker.WorkerReportsProgress = true;
                _BackgroundWorker.WorkerSupportsCancellation = true;
                _BackgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
                _BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);

                _SqlManager = sqlManager;
            }

            _SourceDbName = sourceDbName;
            _BackgroundWorkerSeq = backgroundWorkerSeq;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string tableName = _GetTableInTableList();
            try
            {
                while (tableName != string.Empty && !_BackgroundWorker.CancellationPending)
                {
                    if (ValidationTable(tableName))
                    { 
                        SetIndentityInsert(tableName, true);

                        DeleteTableData(tableName);
                        string columnData = SearchColumnList(tableName);
                        InsertTableData(tableName, columnData, SearchDataTable(tableName, columnData));

                        SetIndentityInsert(tableName, false);
                        ResetIdentity(tableName);
                    }

                    tableName = _GetTableInTableList();
                }
            }
            catch (Exception ex)
            {
                SetIndentityInsert(tableName, false);
                _SetStatusException(ex.Message);
            }
        }

        private bool ValidationTable(string tableName)
        {
            string result = _SqlManager.CheckExistTable(tableName);
            return result == "Y" ? true : false;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _SetStatusIdle();
            _SqlManager.SqlDisconnect();
            GC.Collect();
        }

        private DataTable SearchDataTable(string tableName, string columnData)
        {
            _SetStatusSearch();
            return _SqlManager.GetTableDataList(_SourceDbName, tableName, columnData);
        }

        private void SetIndentityInsert(string tableName, bool isOn)
        {
            _SqlManager.SetIdentityInsert(tableName, isOn);
        }

        private void ResetIdentity(string tableName)
        {
            _SqlManager.ResetIdentity(tableName);
        }

        private void DeleteTableData(string tableName)
        {
            _SetStatusDelete();
            _SqlManager.DeleteTableData(tableName);
        }

        private string SearchColumnList(string tableName)
        {
            DataTable dataTable = _SqlManager.GetColumnList(_SourceDbName, tableName);
            string columnData = string.Empty;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                columnData += string.Format("{0}[{1}]", i == 0 ? "" : ",", dataTable.Rows[i]["column_name"].ToString());
            }
            return columnData;
        }

        private void InsertTableData(string tableName, string columnData, DataTable targetDataTable)
        {
            if (targetDataTable != null && targetDataTable.Rows.Count > 0)
            {
                int totalRowCount = targetDataTable.Rows.Count;
                _ProgressChanged(0, totalRowCount);

                _SetStatusInsert();
                string valueData = string.Empty;
                int valueDataCount = 0;
                Dictionary<string, byte[]> bytesData = new Dictionary<string, byte[]>();
                for (int i = 0; i < totalRowCount; i++)
                {
                    if (_BackgroundWorker.CancellationPending)
                        break;

                    string comma = valueData == string.Empty ? "" : ",";
                    string data = CreateValueData(targetDataTable.Rows[i], i, ref bytesData);
                    valueData += string.Format("{0}({1})", comma, data);
                    valueDataCount++;
                    if ((valueDataCount + 1) % 25 == 0 || bytesData.Count > 0)
                    { 
                        InsertDataToTable(tableName, columnData, ref bytesData, ref valueData, ref valueDataCount);                        
                        _ProgressChanged(i + 1, totalRowCount);
                    }
                }

                if (valueData != string.Empty && !_BackgroundWorker.CancellationPending)
                { 
                    InsertDataToTable(tableName, columnData, ref bytesData, ref valueData, ref valueDataCount);
                    _ProgressChanged(totalRowCount, totalRowCount);
                }
            }
        }

        private string CreateValueData(DataRow dr, int currentRowIndex, ref Dictionary<string, byte[]> bytesData)
        {
            string valueData = string.Empty;
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                string comma = i == 0 ? "" : ",";
                string data = string.Empty;
                if (dr.ItemArray[i] == DBNull.Value)
                    data = "null";
                else if (dr.ItemArray[i].GetType() == typeof(DateTime))
                    data = string.Format("'{0}'", ((DateTime)dr.ItemArray[i]).ToString("yyyy-MM-dd HH:mm:ss.fff"));
                else if (dr.ItemArray[i].GetType() == typeof(byte[]))
                {
                    string keyName = currentRowIndex.ToString();
                    if (bytesData.ContainsKey(keyName))
                        keyName = string.Format("{0}_{1}", keyName, DateTime.Now.ToString("HHmmssfff"));

                    bytesData.Add(keyName, (byte[])dr.ItemArray[i]);
                    data = string.Format("@BinaryData_{0}", keyName);
                }
                else if (dr.ItemArray[i].GetType() == typeof(double))
                    data = string.Format("{0}", dr.ItemArray[i].ToString());
                else
                    data = string.Format("N'{0}'", dr.ItemArray[i].ToString().Replace("'", "''"));
                    
                valueData += string.Format("{0}{1}", comma, data);
            }

            return valueData;
        }

        private void InsertDataToTable(string tableName, string columnData, ref Dictionary<string, byte[]> bytesData, ref string valueData, ref int valueDataCount)
        {
            string query = string.Empty;
            string result = string.Empty;
            if (bytesData.Count > 0)
            { 
                _SqlManager.InsertDataToTable(tableName, columnData, valueData, bytesData, ref query);
                bytesData.Clear();
            }
            else
                result = _SqlManager.InsertDataToTable(tableName, columnData, valueData, ref query);
            if (result != string.Empty)
            {
                throw new Exception(result);
            }

            valueData = string.Empty;
            valueDataCount = 0;
        }

        public void RunWorkerAsync()
        {
            _BackgroundWorker.RunWorkerAsync();
        }

        public void CancelAsync()
        {
            _BackgroundWorker.CancelAsync();
        }
    }
}
