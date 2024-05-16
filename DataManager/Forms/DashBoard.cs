using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataManager
{
    public partial class DashBoard : Form
    {
        public DashBoard(List<string> tableList, string sourceDbName, int backgroundWorkerCount, ref Sql_Manager sqlManager)
        {
            InitializeComponent();
            copyData.Initialize(tableList, sourceDbName, backgroundWorkerCount, ref sqlManager);
            copyData.Close += new EventHandler(this.FormClose);
        }

        private void FormClose(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Action close = delegate { FormClose(sender, e); };
                this.Invoke(close);
            }
            else
            {
                this.Close();
            }
        }
    }
}
