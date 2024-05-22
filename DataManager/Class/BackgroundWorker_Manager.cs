using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

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
        public BackgroundWorkerProgress.SetStatusValidate _SetStatusValidate;
        public BackgroundWorkerProgress.SetStatusException _SetStatusException;
        public BackgroundWorkerProgress.ProgressChanged _ProgressChanged;

        private Sql_Manager _SqlManager = null;
        private BackgroundWorker _BackgroundWorker = null;
        private string _SourceDbName = string.Empty;
        private int _BackgroundWorkerSeq = 0;
        private List<string> _InvalidTableList = new List<string>();

        public bool IsBusy
        {
            get { return _BackgroundWorker.IsBusy; }
        }
        public List<string> InvalidTableList
        {
            get { return _InvalidTableList; }
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
                    if (ExistTable(tableName))
                    {
                        // 1. 기존 테이블 데이터 삭제
                        if (_BackgroundWorker.CancellationPending) break;
                        DeleteTableData(tableName);

                        // 2. 계산열을 제외한 컬럼 데이터 조회
                        if (_BackgroundWorker.CancellationPending) break;
                        string columnData = SearchColumnList(tableName);

                        // 3. 컬럼 데이터 기준 기존 테이블 데이터 조회
                        if (_BackgroundWorker.CancellationPending) break;
                        DataTable dataTable = SearchDataTable(tableName, columnData);

                        // 4. 기존 테이블 데이터 신규 DB 테이블로 복사
                        if (_BackgroundWorker.CancellationPending) break;
                        InsertTableData(tableName, columnData, dataTable);

                        // 5. 신규 테이블 데이터 검증
                        if (_BackgroundWorker.CancellationPending) break;
                        ValidationTable(tableName, columnData);

                        // 6. 테이블 ID값 재설정
                        if (_BackgroundWorker.CancellationPending) break;
                        ResetIdentity(tableName);
                    }

                    tableName = _GetTableInTableList();
                }
            }
            catch (Exception ex)
            {
                _SetStatusException(ex.Message);
            }
        }

        private bool ExistTable(string tableName)
        {
            string result = _SqlManager.CheckExistTable(tableName);
            return result == "Y" ? true : false;
        }

        private void ValidationTable(string tableName, string columnData)
        {
            _SetStatusValidate();

            DataTable dataTable = _SqlManager.ValidationTableData(_SourceDbName, tableName, columnData);
            if (dataTable != null && dataTable.Rows.Count > 0)
                _InvalidTableList.Add($"[{tableName}]");
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
                columnData += $"{(i == 0 ? "" : ",")}[{dataTable.Rows[i]["column_name"]}]";
            }
            return columnData;
        }

        private void InsertTableData(string tableName, string columnData, DataTable targetDataTable)
        {
            if (targetDataTable != null && targetDataTable.Rows.Count > 0)
            {
                int totalRowCount = targetDataTable.Rows.Count;

                // Progress 초기화
                _ProgressChanged(0, totalRowCount);

                // 입력 상태로 변경
                _SetStatusInsert();

                // 현재 DB 테이블 스키마 조회
                DataTable currentDbTable = _SqlManager.GetTableSchema(tableName, columnData);

                const int ADD_ROW_COUNT = 10000;
                // 현재 DB 스키마에 원본 데이터 입력
                for (int i = 0; i < totalRowCount; i++)
                {
                    if (_BackgroundWorker.CancellationPending)
                        break;

                    DataRow dataRow = currentDbTable.NewRow();
                    for (int j = 0; j < targetDataTable.Columns.Count; j++)
                    {
                        string columnName = targetDataTable.Columns[j].ColumnName;
                        dataRow[columnName] = targetDataTable.Rows[i][columnName];
                    }
                    currentDbTable.Rows.Add(dataRow);

                    // Bulk Insert
                    if (currentDbTable.Rows.Count == ADD_ROW_COUNT)
                        BulkInsert(tableName, ref currentDbTable, totalRowCount, i + 1);
                }

                // 남은 데이터 Insert
                if (currentDbTable.Rows.Count > 0 && !_BackgroundWorker.CancellationPending)
                    BulkInsert(tableName, ref currentDbTable, totalRowCount);
            }
        }

        private void BulkInsert(string tableName, ref DataTable dataTable, int totalRowCount, int currentRowCount = -1)
        {
            // Insert
            _SqlManager.InsertBulk(tableName, dataTable);

            dataTable.Rows.Clear();
            _ProgressChanged(currentRowCount != -1 ? currentRowCount : totalRowCount, totalRowCount);
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
