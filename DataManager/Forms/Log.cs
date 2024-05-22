using DevExpress.DataAccess.Wizard.Presenters;
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
    public partial class Log : UserControl
    {
        public enum LogType
        {
            ALERT,
            INFO
        }

        public Log()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            lb_Log.Items.Clear();
        }

        public void AppendLog(string content, LogType logType = LogType.INFO)
        {            
            lb_Log.Items.Add($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]\t[{logType.ToString()}]\t{content}");
            lb_Log.SelectedIndex = lb_Log.Items.Count - 1;
        }

        private void lb_Log_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                string log_data = lb_Log.Items[e.Index].ToString();
                if (log_data.Contains("[INFO]"))
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                    using (Brush textBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(log_data, e.Font, textBrush, e.Bounds.Location);
                    }
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);

                    using (Brush textBrush = new SolidBrush(Color.White))
                    {
                        e.Graphics.DrawString(log_data, e.Font, textBrush, e.Bounds.Location);
                    }
                }
            }
        }
    }
}
