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
    public partial class BackgroundWorkerProgress : UserControl
    {
        private Sql_Manager _SqlManager = new Sql_Manager();
        private int _backgroundWorkerSeq = 0;
        public int BackgroundWorkerSeq { get { return _backgroundWorkerSeq; } }
        private BackgoundWorker_Manager _BackgoundWorker_Manager = null;

        public delegate string GetTableInTableList();
        public GetTableInTableList _GetTableInTableList;

        private bool _isComplete = false;
        public bool isEnabled { get { return this.Enabled; } }
        public bool isComplete { get { return _isComplete; } }

        public BackgroundWorkerProgress()
        {
            InitializeComponent();
        }

        public void SetTitle(int backgroundWorkerSeq)
        {
            _backgroundWorkerSeq = backgroundWorkerSeq;
            lc_BWName.Text = string.Format("Thread {0}", backgroundWorkerSeq);
        }

        public void Disabled()
        {
            lc_BWName.BackColor = Color.DarkGray;
            lc_TableName.BackColor = Color.DarkGray;
            lc_CompleteCount.BackColor = Color.DarkGray;
            tlp_Main.BackColor = Color.DarkGray;

            this.Enabled = false;
        }

        public void ConnectDatabase(string connectionString)
        {
            if (!_SqlManager.SqlConnect(connectionString))
                Disabled();
            else
            {
                _BackgoundWorker_Manager = new BackgoundWorker_Manager();
                _BackgoundWorker_Manager._GetTableInTableList = new BackgoundWorker_Manager.GetTableInTableList(GetTable);
                _BackgoundWorker_Manager.GetTable();
            }
        }

        public void DisconnectDatabase()
        {
            _SqlManager.SqlDisconnect();
        }

        public string GetTable()
        {
            string tableName = _GetTableInTableList();
            lc_TableName.Text = tableName;
            return tableName;
        }
    }
}
