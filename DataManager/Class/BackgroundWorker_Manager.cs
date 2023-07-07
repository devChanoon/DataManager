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

        public void Initialize(Sql_Manager sqlManager, string sourceDbName, int backgroundWorkerSeq)
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
                        InsertTableData(tableName, SearchDataTable(tableName));
                        SetIndentityInsert(tableName, false);
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
            string result = _SqlManager.ValidationTable(tableName);
            return result == "Y" ? true : false;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _SetStatusIdle();
        }

        private DataTable SearchDataTable(string tableName)
        {
            _SetStatusSearch();
            return _SqlManager.GetTableDataList(_SourceDbName, tableName);
        }

        private void SetIndentityInsert(string tableName, bool isOn)
        {
            _SqlManager.SetIdentityInsert(tableName, isOn);
        }

        private void DeleteTableData(string tableName)
        {
            _SqlManager.DeleteTableData(tableName);
        }

        private Dictionary<string, int> SearchComputedColumnList(string tableName)
        {
            Dictionary<string, int> computedcolumnList = new Dictionary<string, int>();
            DataTable dataTable = _SqlManager.GetComputedColumnList(tableName);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                computedcolumnList.Add(dataTable.Rows[i]["column_name"].ToString(), Convert.ToInt32(dataTable.Rows[i]["column_index"].ToString()));
            }
            return computedcolumnList;
        }

        private void InsertTableData(string tableName, DataTable targetDataTable)
        {
            if (targetDataTable != null && targetDataTable.Rows.Count > 0)
            {
                Dictionary<string, int> computedColumnList = SearchComputedColumnList(tableName);

                int totalRowCount = targetDataTable.Rows.Count;
                _ProgressChanged(0, totalRowCount);

                _SetStatusInsert();
                string columnData = GetColumnData(targetDataTable.Rows[0], computedColumnList);
                string valueData = string.Empty;
                for (int i = 0; i < totalRowCount; i++)
                {
                    if (_BackgroundWorker.CancellationPending)
                        break;

                    valueData += string.Format("{0}({1})", valueData == string.Empty ? "" : ",", CreateValueData(targetDataTable.Rows[i], computedColumnList));
                    if ((i + 1) % 25 == 0)
                    { 
                        InsertDataToTable(tableName, columnData, ref valueData);
                        _ProgressChanged(i + 1, totalRowCount);
                    }
                }

                if (valueData != string.Empty && !_BackgroundWorker.CancellationPending)
                { 
                    InsertDataToTable(tableName, columnData, ref valueData);
                    _ProgressChanged(totalRowCount, totalRowCount);
                }
            }
        }

        private string GetColumnData(DataRow dr, Dictionary<string, int> computedColumnList)
        {
            string columnData = string.Empty;
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                string currentColumnName = dr.Table.Columns[i].ColumnName;
                if (!computedColumnList.ContainsKey(currentColumnName))
                    columnData += string.Format("{0}[{1}]", i == 0 ? "" : ",", currentColumnName);
            }
            return columnData;
        }

        private string CreateValueData(DataRow dr, Dictionary<string, int> computedColumnList)
        {
            string valueData = string.Empty;
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                bool isComputedColumn = false;
                for (int j = 0; j < computedColumnList.Count; j++)
                {
                    if (i == computedColumnList.Values.ElementAt(j))
                    {
                        isComputedColumn = true;
                        break;
                    }
                }
                if (isComputedColumn)
                    continue;

                string comma = i == 0 ? "" : ",";
                string data = string.Empty;
                if (dr.ItemArray[i] == DBNull.Value)
                    data = "null";
                else if (dr.ItemArray[i].GetType() == typeof(DateTime))
                    data = ((DateTime)dr.ItemArray[i]).ToString("yyyy-MM-dd HH:mm:ss.fff");
                else
                    data = dr.ItemArray[i].ToString().Replace("'", "''");

                data = dr.ItemArray[i] == DBNull.Value ? "null" : string.Format("'{0}'", data);
                valueData += string.Format("{0}{1}", comma, data);
            }

            return valueData;
        }

        private void InsertDataToTable(string tableName, string columnData, ref string valueData)
        {
            string query = string.Empty;
            string result = _SqlManager.InsertDataToTable(tableName, columnData, valueData, ref query);
            if (result != string.Empty)
            {
                throw new Exception(result);
            }

            valueData = string.Empty;
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
