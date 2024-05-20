using System.Windows.Forms;

namespace DataManager
{
    public partial class LogDetailView : Form
    {
        public LogDetailView(string masterId, bool isAllInOne)
        {
            InitializeComponent();
            tc_LogDetailView.SelectedTabPage = isAllInOne ? tp_AllInOne : tp_ETC;
            if (isAllInOne)
            {
                gc_Site.DataSource = Log_Manager.GetDetailData(masterId, typeof(Log_Manager.SiteData));
                gc_Database.DataSource = Log_Manager.GetDetailData(masterId, typeof(Log_Manager.DatabaseData));
            }
            else
                gc_ETC.DataSource = Log_Manager.GetDetailData(masterId, typeof(Log_Manager.DetailData));
        }
    }
}
