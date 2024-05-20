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
        private int _BackgroundWorkerSeq = 0;
        private string _SourceDbName = string.Empty;
        private BackgoundWorker_Manager _BackgoundWorker_Manager = null;
        private bool _IsException = false;
        private string _ExceptionMessage = string.Empty;

        private Color _DeleteStatus = Color.IndianRed;
        private Color _SearchStatus = Color.LightYellow;
        private Color _InsertStatus = Color.SeaGreen;
        private Color _IdleStatus = Color.WhiteSmoke;
        private Color _DisabledStatus = Color.DarkGray;
        private Color _ExceptionStatus = Color.Red;

        public delegate string GetTableInTableList();
        public delegate void SetStatusIdle();
        public delegate void SetStatusDelete();
        public delegate void SetStatusSearch();
        public delegate void SetStatusInsert();
        public delegate void SetStatusException(string message);
        public delegate void ProgressChanged(int insertedRowCount, int totalRowCount);
        public GetTableInTableList _GetTableInTableList;

        public int BackgroundWorkerSeq { get { return _BackgroundWorkerSeq; } }
        public bool IsEnabled { get { return this.Enabled; } }
        public bool IsBusy { get { return _BackgoundWorker_Manager == null ? false : _BackgoundWorker_Manager.IsBusy; } }
        public bool IsException { get { return _IsException; } }
        public string ExceptionMessage { get { return _ExceptionMessage; } }

        public BackgroundWorkerProgress()
        {
            InitializeComponent();
        }

        public void Initialize(int backgroundWorkerSeq, string sourceDbName)
        {
            _BackgroundWorkerSeq = backgroundWorkerSeq;
            SetBWName($"Thread {backgroundWorkerSeq}");

            _SourceDbName = sourceDbName;
        }

        private void SetBWName(string name)
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setBWName = delegate { SetBWName(name); };
                lc_BWName.Invoke(setBWName);
            }
            else
                lc_BWName.Text = name;

        }

        public void Disabled()
        {
            lc_BWName.BackColor = _DisabledStatus;
            lc_TableName.BackColor = _DisabledStatus;
            lc_CompleteCount.BackColor = _DisabledStatus;
            tlp_Main.BackColor = _DisabledStatus;

            this.Enabled = false;
        }

        private void SetIdle()
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setIdle = delegate { SetIdle(); };
                lc_BWName.Invoke(setIdle);
            }
            else
            {
                lc_BWName.BackColor = _IdleStatus;
            }
        }

        private void SetDelete()
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setDelete = delegate { SetDelete(); };
                lc_BWName.Invoke(setDelete);
            }
            else
            {
                lc_BWName.BackColor = _DeleteStatus;
            }
        }

        private void SetSearch()
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setSearch = delegate { SetSearch(); };
                lc_BWName.Invoke(setSearch);
            }
            else
            {
                lc_BWName.BackColor = _SearchStatus;
            }
        }

        private void SetInsert()
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setUpdate = delegate { SetInsert(); };
                lc_BWName.Invoke(setUpdate);
            }
            else
            {
                lc_BWName.BackColor = _InsertStatus;
            }
        }


        private void SetException(string message)
        {
            if (lc_BWName.InvokeRequired)
            {
                Action setException = delegate { SetException(message); };
                lc_BWName.Invoke(setException);
            }
            else
            {
                lc_BWName.BackColor = _ExceptionStatus;
                _IsException = true;
                _ExceptionMessage = string.Format("Thread {0} > {1}", _BackgroundWorkerSeq, message);
            }
        }

        private void SetTableName(string tableName)
        {   
            if (lc_TableName.InvokeRequired)
            {
                //Console.WriteLine(string.Format("[{0}] Thread {1} > {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), _BackgroundWorkerSeq, tableName));
                Action setTableName = delegate { SetTableName(tableName); };
                pbc_Progress.Invoke(setTableName);
            }
            else
            {
                lc_TableName.Text = tableName;
            }
        }

        private void SetProgress(int insertedRowCount, int totalRowCount)
        {
            if (pbc_Progress.InvokeRequired)
            {
                Action setProgress = delegate { SetProgress(insertedRowCount, totalRowCount); };
                pbc_Progress.Invoke(setProgress);
            }
            else
            {
                if (totalRowCount == 0)
                    pbc_Progress.Position = 0;
                else
                    pbc_Progress.Position = Convert.ToInt32(Convert.ToDouble(insertedRowCount) / Convert.ToDouble(totalRowCount) * 100);

                lc_CompleteCount.Text = string.Format("{0} / {1}", insertedRowCount, totalRowCount);
            }
        }

        public void ConnectDatabase(string connectionString)
        {
            string connectionResult = _SqlManager.SqlConnect(connectionString);
            if (connectionResult != string.Empty)
                Disabled();
            else
            {
                _BackgoundWorker_Manager = new BackgoundWorker_Manager();
                _BackgoundWorker_Manager.Initialize(_SourceDbName, _BackgroundWorkerSeq, ref _SqlManager);
                _BackgoundWorker_Manager._GetTableInTableList = new BackgoundWorker_Manager.GetTableInTableList(GetTable);
                _BackgoundWorker_Manager._SetStatusIdle = new SetStatusIdle(SetIdle);
                _BackgoundWorker_Manager._SetStatusDelete = new SetStatusDelete(SetDelete);
                _BackgoundWorker_Manager._SetStatusSearch = new SetStatusSearch(SetSearch);
                _BackgoundWorker_Manager._SetStatusInsert = new SetStatusInsert(SetInsert);
                _BackgoundWorker_Manager._SetStatusException = new SetStatusException(SetException);
                _BackgoundWorker_Manager._ProgressChanged = new ProgressChanged(SetProgress);

                SetIdle();
            }
        }

        public void RunBackgroundWorker()
        {
            _BackgoundWorker_Manager.RunWorkerAsync();
        }

        public void CancelBackgroundWorker()
        {
            _BackgoundWorker_Manager.CancelAsync();
        }

        public string GetTable()
        {
            string tableName = _GetTableInTableList();
            SetTableName(tableName);
            SetProgress(0, 0);
            return tableName;
        }
    }
}
