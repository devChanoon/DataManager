using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager
{
    public partial class Main : Form
    {
        private Sql_Manager _SqlManager = new Sql_Manager();
        private Init_Manager _InitManager = new Init_Manager();

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
                nud_MaxThread.Value = nud_MaxThread.Value;
            }

            this.Text = string.Format("DataManager - V{0}", Application.ProductVersion);
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
            string connectionString = string.Format("Server={0};database={1};uid={2};pwd={3}", tb_DBAddress.Text, tb_DBName.Text, tb_ID.Text, tb_Password.Text);
            string connectionResult = _SqlManager.SqlConnect(connectionString);
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

            DataTable dataTable = _SqlManager.GetDBInfo(tb_DBName.Text);
            if (dataTable != null)
            {
                lb_DataDBName.Text = dataTable.Rows[0]["name"].ToString();
                lb_DataDBPath.Text = dataTable.Rows[0]["filename"].ToString();
                lb_LogDBName.Text = dataTable.Rows[1]["name"].ToString();
                lb_LogDBPath.Text = dataTable.Rows[1]["filename"].ToString();
            }
        }

        private void sb_ModifyExecute_Click(object sender, EventArgs e)
        {
            ModifyLog.Clear();

            if (!File.Exists(lb_DataDBPath.Text) || !File.Exists(lb_DataDBPath.Text))
            {
                ModifyLog.AppendLog("DB 또는 log 파일이 해당 경로에 존재하지 않습니다.\r\n해당 DB 서버에서 실행해 주십시오.", Log.LogType.ALERT);
                return;
            }

            string prevDbName = tb_DBName.Text;
            try
            {
                // 1. 액세스 제한 RESTRICTED_USER로 변경
                SetDBAccess(false);

                // 2. 논리 이름 변경 (DB, LOG)
                string suffix = DateTime.Now.ToString("yyyyMMddHHmmss");
                string dbName = SetDBLogicalName(lb_DataDBName.Text, suffix);
                string logName = SetDBLogicalName(lb_LogDBName.Text, suffix);

                // 4. DB명 변경
                tb_DBName.Text = SetDBName(tb_DBName.Text, suffix);

                // 3. DB OFFLINE
                SetDBStatus(false);

                // 4. 물리 DB 파일 이름 변경
                string dbPath = SetDBPhysicalName(lb_DataDBPath.Text, suffix);
                string logPath = SetDBPhysicalName(lb_LogDBPath.Text, suffix);

                // 5. DB ONLINE
                SetDBStatus(true);

                // 6. 파일 경로 수정
                SetDBPath(dbName, dbPath);
                SetDBPath(logName, logPath);

                // 7. 변경된 경로 표시
                lb_DataDBName.Text = dbName;
                lb_LogDBName.Text = logName;
                lb_DataDBPath.Text = dbPath;
                lb_LogDBPath.Text = logPath;
            }
            catch (Exception ex)
            {
                ModifyLog.AppendLog(ex.Message, Log.LogType.ALERT);
            }
            finally
            {
                // DB ONLINE
                SetDBStatus(true);

                // DB 액세스 제한 MULTI_USER로 변경
                SetDBAccess(true);

                if (prevDbName != tb_DBName.Text)
                {
                    MessageBox.Show("DB명 변경에 성공 했습니다.");
                    sb_Connect_Click(null, null); // Disconnect
                    sb_Connect_Click(null, null); // 변경된 DB명으로 Connect
                }
            }
        }

        private void SetDBAccess(bool isMultiUser)
        {
            ModifyLog.AppendLog(string.Format("DB Access 제한 변경 : {0}", isMultiUser ? "MULTI_USER" : "RESTRICED_USER"));
            _SqlManager.SetDBAccess(tb_DBName.Text, isMultiUser);
        }

        private void SetDBStatus(bool isOnline)
        {
            ModifyLog.AppendLog(string.Format("DB State 변경 : {0}", isOnline ? "ONLINE" : "OFFLINE"));
            _SqlManager.SetDBStatus(tb_DBName.Text, isOnline);
        }

        private string SetDBLogicalName(string currentName, string suffix)
        {
            string newName = GetNewName(currentName, suffix);
            ModifyLog.AppendLog(string.Format("DB 논리 파일명 변경 : {0} >> {1}", currentName, newName));
            
            string resultName = _SqlManager.SetDBLogicalName(tb_DBName.Text, currentName, newName);
            if (resultName != newName)
                throw new Exception("DB 논리 파일명 변경에 실패 했습니다.");
            else
                return resultName;
        }

        private string GetNewName(string currentName, string suffix)
        {
            const string TIME_STAMP_SYMBOL = "#";
            string sourceName = currentName;
            if (sourceName.IndexOf(TIME_STAMP_SYMBOL) > -1)
                sourceName = sourceName.Substring(0, sourceName.IndexOf(TIME_STAMP_SYMBOL));

            return string.Format("{0}{1}{2}", sourceName, TIME_STAMP_SYMBOL, suffix);
        }

        private string SetDBPhysicalName(string path, string suffix)
        {
            string extention = Path.GetExtension(path);
            string fileName = Path.GetFileName(path);
            fileName = fileName.Substring(0, fileName.Length - extention.Length);

            string newFileName = string.Format("{0}{1}", GetNewName(fileName, suffix), extention);
            string newPath = Path.Combine(Path.GetDirectoryName(path), newFileName);

            try
            {
                ModifyLog.AppendLog(string.Format("DB 물리 파일명 변경 : {0} >> {1}", Path.GetFileName(path), newFileName));

                FileInfo fileInfo = new FileInfo(path);
                fileInfo.MoveTo(newPath);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("DB 물리 파일명 변경에 실패했습니다. {0}", ex.Message));
            }

            return newPath;
        }

        private void SetDBPath(string currentName, string path)
        {
            ModifyLog.AppendLog(string.Format("DB 물리 경로 변경 : {0} - {1}", currentName, path));
            _SqlManager.SetDBLogicalPath(tb_DBName.Text, currentName, path);
        }

        private string SetDBName(string currentName, string suffix)
        {
            string newName = GetNewName(currentName, suffix);
            ModifyLog.AppendLog(string.Format("DB명 변경 : {0} >> {1}", tb_DBName.Text, newName));
            _SqlManager.ChangeDBName(currentName, newName);
            return newName;
        }
    }
}
