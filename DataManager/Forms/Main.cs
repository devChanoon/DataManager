using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (_SqlManager.SqlConnect(connectionString))
            {
                SetDBControlEnabled(false);
                sb_Connect.Text = "DISCONNECT";

                _InitManager._InitDb.dbAddress = tb_DBAddress.Text;
                _InitManager._InitDb.dbName = tb_DBName.Text;
                _InitManager._InitDb.ID = tb_ID.Text;
                _InitManager._InitDb.password = tb_Password.Text;
                _InitManager._InitDb.SaveDBConfig();
                return true;
            }
            else
            {
                sb_Connect.Text = "CONNECT";
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

            groupBox3.Enabled = !enabled;
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

            DashBoard dashBoard = new DashBoard(tableList, cb_SrcDB.SelectedItem.ToString(), ref _SqlManager);
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
    }
}
