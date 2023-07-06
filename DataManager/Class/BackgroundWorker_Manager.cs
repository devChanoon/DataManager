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
        private enum work_type
        {
            NONE, SEARCH, UPDATE
        }

        private Sql_Manager _SqlManager = null;
        private BackgroundWorker _BackgroundWorker = null;
        private DataTable _ResultDataTable = null;
        private int _ResultUpdateCount = 0;

        private GridControl _GridControl = null;
        private List<string[]> _Parameters = null;
        private DataTable _StandardTable = null;

        private work_type _WorkType = work_type.NONE;
        public delegate string GetTableInTableList();
        public GetTableInTableList _GetTableInTableList;

        public bool IsBusy
        {
            get { return _BackgroundWorker.IsBusy; }
        }

        public int UpdatedRowCount
        {
            get
            {
                int _updateRowCount = _ResultUpdateCount;
                _ResultUpdateCount = 0;
                return _updateRowCount;
            }
        }

        public void Initialize(Sql_Manager sqlManager)
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
        }

        internal void Initialize(object m_Sql_Manager)
        {
            throw new NotImplementedException();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public void RunWorkerAsync_Search(int step, GridControl target, string search_parameter = "", DataTable standard_table = null)
        {

        }

        public void RunWorkerAsync_Execute(int step, List<string[]> parameters)
        {
        }


        public void GetTable()
        {
            string a = _GetTableInTableList();

        }

    }
}
