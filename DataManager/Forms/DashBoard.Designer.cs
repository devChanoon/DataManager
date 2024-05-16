
namespace DataManager
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.copyData = new DataManager.CopyData();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Bottom.Controls.Add(this.copyData);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1080, 633);
            this.pnl_Bottom.TabIndex = 11;
            // 
            // copyData
            // 
            this.copyData.BackColor = System.Drawing.Color.White;
            this.copyData.Close = null;
            this.copyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyData.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyData.Location = new System.Drawing.Point(0, 0);
            this.copyData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyData.Name = "copyData";
            this.copyData.Size = new System.Drawing.Size(1078, 631);
            this.copyData.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 633);
            this.Controls.Add(this.pnl_Bottom);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashBoard";
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Bottom;
        private CopyData copyData;
    }
}