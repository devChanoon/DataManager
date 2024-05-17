using System.Windows.Forms;

namespace DataManager
{
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
            gc_Log.DataSource = Log_Manager.GetMasterData();
        }

        private void gv_Log_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == gc_Detail)
            {
                bool isAllInOne = gv_Log.GetRowCellValue(e.RowHandle, gc_Type).ToString() == "All In One";
                string masterId = gv_Log.GetRowCellValue(e.RowHandle, gc_MasterId).ToString();

                new LogDetailView(masterId, isAllInOne).ShowDialog();
            }
        }
    }
}
