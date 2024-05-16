using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.Administration;

namespace DataManager
{
    public partial class Main : Form
    {
        public delegate void ModifyDBAppendLog(string log, Log.LogType logType);

        public const string INI_FILE_NAME = "RTEGMS_SYSTEM.ini";
        public const string NOT_EXIST_IIS = "IIS에 설정된 사이트가 없습니다.";
        private const string NOT_EXIST_INI = "INI 파일을 찾을 수 없습니다.";

        private Sql_Manager _SqlManager = new Sql_Manager();
        private Init_Manager _InitManager = new Init_Manager();

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(    // ini Read 함수
                    String section,
                    String key,
                    String def,
                    StringBuilder retVal,
                    int size,
                    String filePath);

        public Main()
        {
            InitializeComponent();
            _InitManager.Initialize();

            tb_DBAddress.Text = _InitManager._InitDb.dbAddress;
            tb_DBName.Text = _InitManager._InitDb.dbName;
            tb_ID.Text = _InitManager._InitDb.ID;
            tb_Password.Text = _InitManager._InitDb.password;

            if (Environment.ProcessorCount < 8)
            {
                nud_MaxThread.Maximum = Environment.ProcessorCount;
                nud_MaxThread.Value = Environment.ProcessorCount;
            }

            this.Text = string.Format("DataManager - V{0}", System.Windows.Forms.Application.ProductVersion);

            InitializeDataSource(gv_Site);
            InitializeDataSource(gv_Database);
        }

        private void InitializeDataSource(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable dataSource = new DataTable();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                DataColumn dataColumn = new DataColumn(gridView.Columns[i].FieldName);
                dataSource.Columns.Add(dataColumn);
            }
            SetDataSource(gridView, dataSource);
        }

        private void sb_Connect_Click(object sender, EventArgs e)
        {
            if (sb_Connect.Text == "CONNECT")
            {
                if (ConnectDatabase())
                    InitailizeDbList();
            }
            else
                DisconnectDatabase();
        }

        private bool ConnectDatabase()
        {
            string connectionResult = _SqlManager.SqlConnect(Sql_Manager.CreateConnectionString(tb_DBAddress.Text, tb_DBName.Text, tb_ID.Text, tb_Password.Text));
            if (connectionResult == string.Empty)
            {
                SetDBControlEnabled(false);
                sb_Connect.Text = "DISCONNECT";

                _InitManager._InitDb.dbAddress = tb_DBAddress.Text;
                _InitManager._InitDb.dbName = tb_DBName.Text;
                _InitManager._InitDb.ID = tb_ID.Text;
                _InitManager._InitDb.password = tb_Password.Text;
                _InitManager._InitDb.SaveDBConfig();

                InitializeDBInfo();
                return true;
            }
            else
            {
                sb_Connect.Text = "CONNECT";
                MessageBox.Show(connectionResult, "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DisconnectDatabase()
        {
            if (_SqlManager.SqlDisconnect())
            {
                SetDBControlEnabled(true);
                sb_Connect.Text = "CONNECT";
            }
            else
            {
                sb_Connect.Text = "DISCONNECT";
            }
        }

        private void SetDBControlEnabled(bool enabled)
        {
            tb_DBAddress.Enabled = enabled;
            tb_DBName.Enabled = enabled;
            tb_ID.Enabled = enabled;
            tb_Password.Enabled = enabled;
            if (!enabled)
                cbe_ViewPassword.Checked = enabled;
            cbe_ViewPassword.Enabled = enabled;

            tc_WorkType.Enabled = !enabled;
        }

        #region Copy Data
        private void InitailizeDbList()
        {
            cb_SrcDB.Items.Clear();

            DataTable dataTable = _SqlManager.GetDbList(tb_DBName.Text);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                cb_SrcDB.Items.Add(dataRow[0]);

                if (cb_SrcDB.SelectedItem == null)
                    cb_SrcDB.SelectedItem = cb_SrcDB.Items[0];
            }
        }

        private void cb_SrcDB_SelectedValueChanged(object sender, EventArgs e)
        {
            gc_TableList.DataSource = _SqlManager.GetTableList(cb_SrcDB.SelectedItem.ToString());
            displayCheckedTableCount(gv_TableList.RowCount);
        }

        private void r_ce_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (gv_TableList.GetFocusedRowCellValue(gc_Check).ToString() == "N")
            {
                gv_TableList.SetFocusedRowCellValue(gc_Check, "Y");
            }
            else
            {
                gv_TableList.SetFocusedRowCellValue(gc_Check, "N");
            }

            displayCheckedTableCount();
        }

        private void displayCheckedTableCount(int checkedTableCount = -1)
        {
            int _checkedCount = checkedTableCount;
            if (_checkedCount == -1)
            {
                _checkedCount = 0;
                for (int i = 0; i < gv_TableList.RowCount; i++)
                {
                    if (gv_TableList.GetRowCellValue(i, gc_Check).ToString() == "Y")
                        _checkedCount++;
                }
            }

            lc_Checked_Count.Text = string.Format("{0} / {1}", _checkedCount, gv_TableList.RowCount);
        }

        private void sb_CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_TableList.RowCount; i++)
            {
                gv_TableList.SetRowCellValue(i, gc_Check, "Y");
            }

            displayCheckedTableCount(gv_TableList.RowCount);
        }

        private void sb_UncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_TableList.RowCount; i++)
            {
                gv_TableList.SetRowCellValue(i, gc_Check, "N");
            }

            displayCheckedTableCount(0);
        }

        private void sb_Execute_Click(object sender, EventArgs e)
        {
            List<string> tableList = new List<string>();
            for (int i = 0; i < gv_TableList.RowCount; i++)
            {
                if (gv_TableList.GetRowCellValue(i, gc_Check).ToString() == "Y")
                    tableList.Add(gv_TableList.GetRowCellValue(i, gc_TableName).ToString());
            }

            DashBoard dashBoard = new DashBoard(tableList, cb_SrcDB.SelectedItem.ToString(), (int)nud_MaxThread.Value, ref _SqlManager);
            dashBoard.ShowDialog();
        }

        private void cbe_ViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbe_ViewPassword.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void sb_FindTable_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            if (gv_TableList.RowCount > 0 && gv_TableList.FocusedRowHandle != gv_TableList.RowCount - 1)
                startIndex = gv_TableList.FocusedRowHandle + 1;

            int rowIndex = SearchTable(startIndex);
            if (startIndex > 0 && rowIndex == -1)
            {
                startIndex = 0;
                rowIndex = SearchTable(startIndex);
            }

            if (rowIndex == -1)
                MessageBox.Show("해당하는 테이블이 존재하지 않습니다.");
            else
                gv_TableList.FocusedRowHandle = rowIndex;
        }

        private int SearchTable(int startIndex)
        {
            int rowIndex = -1;
            for (int i = startIndex; i < gv_TableList.RowCount; i++)
            {
                if (gv_TableList.GetRowCellValue(i, gc_TableName).ToString().ToUpper().Contains(te_TableName.Text.ToUpper()))
                {
                    rowIndex = i;
                    break;
                }
            }

            return rowIndex;
        }

        private void te_TableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                sb_FindTable_Click(null, null);
        }

        #endregion

        #region Modify Database
        private void ClearDBInfo()
        {
            lb_DataDBName.Text = string.Empty;
            lb_DataDBPath.Text = string.Empty;
            lb_LogDBName.Text = string.Empty;
            lb_LogDBPath.Text = string.Empty;
        }

        private void InitializeDBInfo()
        {
            ClearDBInfo();
            
            DatabaseInfo databaseInfo = new DatabaseInfo().GetDatabaseInfo(tb_DBName.Text, ref _SqlManager);
            lb_DataDBName.Text = databaseInfo.Current.DataDBName;
            lb_DataDBPath.Text = databaseInfo.Current.DataDBPath;
            lb_LogDBName.Text = databaseInfo.Current.LogDBName;
            lb_LogDBPath.Text = databaseInfo.Current.LogDBPath;
        }

        private void AppendLog(string log, Log.LogType logType)
        {
            ModifyLog.AppendLog(log, logType);
        }

        private void sb_ModifyExecute_Click(object sender, EventArgs e)
        {
            ModifyLog.Clear();

            if (!File.Exists(lb_DataDBPath.Text) || !File.Exists(lb_LogDBPath.Text))
            {
                ModifyLog.AppendLog("data 파일 또는 log 파일이 해당 경로에 존재하지 않습니다.\r\n해당 DB 서버에서 실행해 주십시오.", Log.LogType.ALERT);
                return;
            }

            DatabaseInfo databaseInfo = new DatabaseInfo();
            databaseInfo.Current.DBName = tb_DBName.Text;
            databaseInfo.Current.DataDBName = lb_DataDBName.Text;
            databaseInfo.Current.DataDBPath = lb_DataDBPath.Text;
            databaseInfo.Current.LogDBName = lb_LogDBName.Text;
            databaseInfo.Current.LogDBPath = lb_LogDBPath.Text;

            Database_Manager databaseManager = new Database_Manager(databaseInfo, true, ref _SqlManager);
            databaseManager.ModifyDBAppendLog = new ModifyDBAppendLog(AppendLog);
            Tuple<bool, DatabaseInfo> modifyResult = databaseManager.ModifyDatabase();
            tb_DBName.Text = modifyResult.Item2.Current.DBName;
            lb_DataDBName.Text = modifyResult.Item2.Current.DataDBName;
            lb_DataDBPath.Text = modifyResult.Item2.Current.DataDBPath;
            lb_LogDBName.Text = modifyResult.Item2.Current.LogDBName;
            lb_LogDBPath.Text = modifyResult.Item2.Current.LogDBPath;

            if (modifyResult.Item1)
            {
                MessageBox.Show("DB명 변경에 성공 했습니다.");
                sb_Connect_Click(null, null); // Disconnect
                sb_Connect_Click(null, null); // 변경된 DB명으로 Connect
            }
        }

        #endregion

        #region All In One

        private void gv_Site_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == gc_FilePath)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Zip Files (*.zip)|*.zip";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gv_Site.SetFocusedRowCellValue(e.Column, openFileDialog.FileName);
                }
            }
        }

        private void gv_Database_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == gc_BackupFilePath)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup File (*.bak)|*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gv_Database.SetFocusedRowCellValue(e.Column, openFileDialog.FileName);
                }
            }
        }

        private void sb_Add_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Tuple<bool, string> result = AddSite(folderBrowserDialog.SelectedPath);
                if (!result.Item1)
                    return;

                AddDB(folderBrowserDialog.SelectedPath, result.Item2);
            }
        }

        private Tuple<bool, string> AddSite(string path)
        {
            DataTable dataTable = GetDataSource(gv_Site);
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Path"].ToString().Equals(path))
                    return new Tuple<bool, string>(false, string.Empty);
            }

            DataRow dataRow = dataTable.NewRow();
            dataRow["Path"] = path;
            dataRow["SiteName"] = FindSiteName(path);
            dataTable.Rows.Add(dataRow);
            SetDataSource(gv_Site, dataTable);
            return new Tuple<bool, string>(true, path);
        }
        public string FindSiteName(string path)
        {
            ServerManager serverManager = new ServerManager();
            foreach (Site site in serverManager.Sites)
            {
                foreach (Microsoft.Web.Administration.Application application in site.Applications)
                {
                    // 특정 경로를 가지는 Application 확인
                    if (application.VirtualDirectories[0].PhysicalPath.Equals(path, StringComparison.OrdinalIgnoreCase))
                    {
                        return site.Name;
                    }
                }
            }

            return NOT_EXIST_IIS;
        }

        private Tuple<bool, string> FindDbName(string path)
        {
            StringBuilder temp = new StringBuilder(2000);
            GetPrivateProfileString("Config", "dbName", "", temp, 2000, Path.Combine(path, INI_FILE_NAME));
            string dbName = temp.ToString();
            return new Tuple<bool, string>(dbName != string.Empty, dbName == string.Empty ? NOT_EXIST_INI : dbName);
        }

        private void AddDB(string path, string sitePath)
        {
            Tuple<bool, string> dbInfo = FindDbName(path);
            if (!dbInfo.Item1)
                return;

            DataTable dataTable = GetDataSource(gv_Database);
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["DBName"].ToString().Equals(dbInfo.Item2))
                    return;
            }

            DataRow dataRow = dataTable.NewRow();
            dataRow["DBName"] = dbInfo.Item2;
            dataRow["SitePath"] = sitePath;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["DBName"] = $"{dbInfo.Item2}_AT";
            dataRow["SitePath"] = sitePath;
            dataTable.Rows.Add(dataRow);
        }

        private void sb_Delete_Click(object sender, EventArgs e)
        {
            string sitePath = gv_Site.GetFocusedRowCellValue(gc_Path).ToString();
            SetDataSource(gv_Site, GetFilteredDataSource(gv_Site, sitePath, "Path"));
            SetDataSource(gv_Database, GetFilteredDataSource(gv_Database, sitePath, "SitePath"));
        }

        private DataTable GetFilteredDataSource(DevExpress.XtraGrid.Views.Grid.GridView gridView, string targetString, string fieldName)
        {
            DataTable dataTable = GetDataSource(gridView);
            var dataRows = dataTable.AsEnumerable().Where(row => row[fieldName].ToString() != targetString);
            return dataRows.Any() ? dataRows.CopyToDataTable() : dataTable.Clone();
        }

        private DataTable GetDataSource(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            return gridView.GridControl.DataSource as DataTable;
        }

        private void SetDataSource(DevExpress.XtraGrid.Views.Grid.GridView gridView, DataTable dataSource)
        {
            gridView.GridControl.DataSource = dataSource;
        }

        private void sb_AllInOneExecute_Click(object sender, EventArgs e)
        {
            if (!CheckDBFile())
            { 
                MessageBox.Show("data 파일 또는 log 파일이 경로에 존재하지 않습니다.\r\n해당 DB 서버에서 실행해 주십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckEmptyFilePath())
            {
                if (DialogResult.No == MessageBox.Show("파일 경로가 지정되지 않은 사이트 또는 DB가 있습니다.\r\n계속 진행하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
            }

            AllInOneDashBoard allInOneDashBoard = new AllInOneDashBoard(GetDataSource(gv_Site), 
                GetDataSource(gv_Database), 
                tb_DBAddress.Text,
                tb_ID.Text,
                tb_Password.Text);
            allInOneDashBoard.ShowDialog();
        }

        private bool CheckDBFile()
        {
            DataTable dbTable = GetDataSource(gv_Database);
            var filteredTable = dbTable.AsEnumerable().Where(row => row["BackupFilePath"].ToString() != string.Empty);
            dbTable = filteredTable.Any() ? filteredTable.CopyToDataTable() : dbTable.Clone();
            for (int i = 0; i < dbTable.Rows.Count; i++)
            {
                DatabaseInfo databaseInfo = new DatabaseInfo().GetDatabaseInfo(dbTable.Rows[i]["DBName"].ToString(), ref _SqlManager);
                if (!File.Exists(databaseInfo.Current.DataDBPath) || !File.Exists(databaseInfo.Current.LogDBPath))
                    return false;
            }

            return true;
        }

        private bool CheckEmptyFilePath()
        {
            DataTable siteTable = GetDataSource(gv_Site);
            var filteredTable = siteTable.AsEnumerable().Where(row => row["FilePath"].ToString() == string.Empty);
            siteTable = filteredTable.Any() ? filteredTable.CopyToDataTable() : siteTable.Clone();

            DataTable dbTable = GetDataSource(gv_Database);
            filteredTable = dbTable.AsEnumerable().Where(row => row["BackupFilePath"].ToString() == string.Empty);
            dbTable = filteredTable.Any() ? filteredTable.CopyToDataTable() : dbTable.Clone();

            return siteTable.Rows.Count == 0 && dbTable.Rows.Count == 0;
        }

        #endregion
    }
}
