
namespace DataManager
{
    partial class BackgroundWorkerProgress
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lc_CompleteCount = new DevExpress.XtraEditors.LabelControl();
            this.lc_BWName = new DevExpress.XtraEditors.LabelControl();
            this.lc_TableName = new DevExpress.XtraEditors.LabelControl();
            this.pbc_Progress = new DevExpress.XtraEditors.ProgressBarControl();
            this.pnl_Main.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc_Progress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.tlp_Main);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(260, 185);
            this.pnl_Main.TabIndex = 0;
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.lc_CompleteCount, 0, 3);
            this.tlp_Main.Controls.Add(this.lc_BWName, 0, 0);
            this.tlp_Main.Controls.Add(this.lc_TableName, 0, 1);
            this.tlp_Main.Controls.Add(this.pbc_Progress, 0, 2);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 4;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Size = new System.Drawing.Size(258, 183);
            this.tlp_Main.TabIndex = 0;
            // 
            // lc_CompleteCount
            // 
            this.lc_CompleteCount.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_CompleteCount.Appearance.Options.UseFont = true;
            this.lc_CompleteCount.Appearance.Options.UseTextOptions = true;
            this.lc_CompleteCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lc_CompleteCount.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lc_CompleteCount.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lc_CompleteCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_CompleteCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_CompleteCount.Location = new System.Drawing.Point(3, 157);
            this.lc_CompleteCount.Name = "lc_CompleteCount";
            this.lc_CompleteCount.Size = new System.Drawing.Size(252, 23);
            this.lc_CompleteCount.TabIndex = 3;
            this.lc_CompleteCount.Text = "000 / 000";
            // 
            // lc_BWName
            // 
            this.lc_BWName.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lc_BWName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_BWName.Appearance.Options.UseBackColor = true;
            this.lc_BWName.Appearance.Options.UseFont = true;
            this.lc_BWName.Appearance.Options.UseTextOptions = true;
            this.lc_BWName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_BWName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lc_BWName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_BWName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_BWName.Location = new System.Drawing.Point(3, 3);
            this.lc_BWName.Name = "lc_BWName";
            this.lc_BWName.Size = new System.Drawing.Size(252, 67);
            this.lc_BWName.TabIndex = 2;
            this.lc_BWName.Text = "Thread 1";
            // 
            // lc_TableName
            // 
            this.lc_TableName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_TableName.Appearance.Options.UseFont = true;
            this.lc_TableName.Appearance.Options.UseTextOptions = true;
            this.lc_TableName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_TableName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lc_TableName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_TableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_TableName.Location = new System.Drawing.Point(3, 76);
            this.lc_TableName.Name = "lc_TableName";
            this.lc_TableName.Size = new System.Drawing.Size(252, 48);
            this.lc_TableName.TabIndex = 0;
            // 
            // pbc_Progress
            // 
            this.pbc_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbc_Progress.Location = new System.Drawing.Point(3, 130);
            this.pbc_Progress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pbc_Progress.Name = "pbc_Progress";
            this.pbc_Progress.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.pbc_Progress.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pbc_Progress.Properties.ShowTitle = true;
            this.pbc_Progress.Properties.Step = 1;
            this.pbc_Progress.Size = new System.Drawing.Size(252, 24);
            this.pbc_Progress.TabIndex = 1;
            // 
            // BackgroundWorkerProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Main);
            this.Name = "BackgroundWorkerProgress";
            this.Size = new System.Drawing.Size(260, 185);
            this.pnl_Main.ResumeLayout(false);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc_Progress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private DevExpress.XtraEditors.LabelControl lc_TableName;
        private DevExpress.XtraEditors.LabelControl lc_CompleteCount;
        private DevExpress.XtraEditors.LabelControl lc_BWName;
        private DevExpress.XtraEditors.ProgressBarControl pbc_Progress;
    }
}
