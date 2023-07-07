
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.spb_Step = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.tlp_BWList = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorkerProgress8 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress7 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress6 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress5 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress4 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress3 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress2 = new DataManager.BackgroundWorkerProgress();
            this.backgroundWorkerProgress1 = new DataManager.BackgroundWorkerProgress();
            this.lc_ProcessTime = new DevExpress.XtraEditors.LabelControl();
            this.tlp_ProcessTime = new System.Windows.Forms.TableLayoutPanel();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.lc_TableCount = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.spb_Step)).BeginInit();
            this.tlp_BWList.SuspendLayout();
            this.tlp_ProcessTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // spb_Step
            // 
            this.spb_Step.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.spb_Step.Appearance.Options.UseBackColor = true;
            this.spb_Step.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.spb_Step.ConnectorLineThickness = 10;
            this.spb_Step.Dock = System.Windows.Forms.DockStyle.Top;
            this.spb_Step.IndentBetweenItems = 200;
            this.spb_Step.IndicatorLineThickness = 4;
            this.spb_Step.ItemOptions.ConnectorOffset = -20;
            this.spb_Step.ItemOptions.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.None;
            this.spb_Step.ItemOptions.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.None;
            this.spb_Step.ItemOptions.Indicator.Width = 50;
            this.spb_Step.Items.Add(this.stepProgressBarItem1);
            this.spb_Step.Items.Add(this.stepProgressBarItem2);
            this.spb_Step.Items.Add(this.stepProgressBarItem3);
            this.spb_Step.Items.Add(this.stepProgressBarItem4);
            this.spb_Step.Location = new System.Drawing.Point(0, 0);
            this.spb_Step.Name = "spb_Step";
            this.spb_Step.SelectedItemIndex = 0;
            this.spb_Step.Size = new System.Drawing.Size(1080, 165);
            this.spb_Step.TabIndex = 0;
            this.spb_Step.SelectedItemChanged += new DevExpress.XtraEditors.StepProgressBarSelectedItemChangedEventHandler(this.spb_Step_SelectedItemChanged);
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.ContentBlock2.Caption = "FK 목록 조회";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.Options.ConnectorOffset = -20;
            this.stepProgressBarItem1.Options.Indicator.Width = 50;
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Caption = "FK 비활성화";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            this.stepProgressBarItem2.Options.ConnectorOffset = -20;
            this.stepProgressBarItem2.Options.Indicator.Width = 50;
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock2.Caption = "데이터 복사";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            this.stepProgressBarItem3.Options.ConnectorOffset = -20;
            this.stepProgressBarItem3.Options.Indicator.Width = 50;
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.ContentBlock2.Caption = "FK 활성화";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            this.stepProgressBarItem4.Options.ConnectorOffset = -20;
            this.stepProgressBarItem4.Options.Indicator.Width = 50;
            // 
            // tlp_BWList
            // 
            this.tlp_BWList.ColumnCount = 9;
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_BWList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress8, 7, 3);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress7, 5, 3);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress6, 3, 3);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress5, 1, 3);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress4, 7, 1);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress3, 5, 1);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress2, 3, 1);
            this.tlp_BWList.Controls.Add(this.backgroundWorkerProgress1, 1, 1);
            this.tlp_BWList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BWList.Location = new System.Drawing.Point(0, 213);
            this.tlp_BWList.Name = "tlp_BWList";
            this.tlp_BWList.RowCount = 5;
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BWList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_BWList.Size = new System.Drawing.Size(1080, 420);
            this.tlp_BWList.TabIndex = 8;
            // 
            // backgroundWorkerProgress8
            // 
            this.backgroundWorkerProgress8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress8.Location = new System.Drawing.Point(811, 215);
            this.backgroundWorkerProgress8.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress8.Name = "backgroundWorkerProgress8";
            this.backgroundWorkerProgress8.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress8.TabIndex = 7;
            // 
            // backgroundWorkerProgress7
            // 
            this.backgroundWorkerProgress7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress7.Location = new System.Drawing.Point(544, 215);
            this.backgroundWorkerProgress7.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress7.Name = "backgroundWorkerProgress7";
            this.backgroundWorkerProgress7.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress7.TabIndex = 6;
            // 
            // backgroundWorkerProgress6
            // 
            this.backgroundWorkerProgress6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress6.Location = new System.Drawing.Point(277, 215);
            this.backgroundWorkerProgress6.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress6.Name = "backgroundWorkerProgress6";
            this.backgroundWorkerProgress6.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress6.TabIndex = 5;
            // 
            // backgroundWorkerProgress5
            // 
            this.backgroundWorkerProgress5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress5.Location = new System.Drawing.Point(10, 215);
            this.backgroundWorkerProgress5.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress5.Name = "backgroundWorkerProgress5";
            this.backgroundWorkerProgress5.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress5.TabIndex = 4;
            // 
            // backgroundWorkerProgress4
            // 
            this.backgroundWorkerProgress4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress4.Location = new System.Drawing.Point(811, 10);
            this.backgroundWorkerProgress4.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress4.Name = "backgroundWorkerProgress4";
            this.backgroundWorkerProgress4.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress4.TabIndex = 3;
            // 
            // backgroundWorkerProgress3
            // 
            this.backgroundWorkerProgress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress3.Location = new System.Drawing.Point(544, 10);
            this.backgroundWorkerProgress3.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress3.Name = "backgroundWorkerProgress3";
            this.backgroundWorkerProgress3.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress3.TabIndex = 2;
            // 
            // backgroundWorkerProgress2
            // 
            this.backgroundWorkerProgress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress2.Location = new System.Drawing.Point(277, 10);
            this.backgroundWorkerProgress2.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress2.Name = "backgroundWorkerProgress2";
            this.backgroundWorkerProgress2.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress2.TabIndex = 1;
            // 
            // backgroundWorkerProgress1
            // 
            this.backgroundWorkerProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundWorkerProgress1.Location = new System.Drawing.Point(10, 10);
            this.backgroundWorkerProgress1.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundWorkerProgress1.Name = "backgroundWorkerProgress1";
            this.backgroundWorkerProgress1.Size = new System.Drawing.Size(257, 195);
            this.backgroundWorkerProgress1.TabIndex = 0;
            // 
            // lc_ProcessTime
            // 
            this.lc_ProcessTime.Appearance.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_ProcessTime.Appearance.Options.UseFont = true;
            this.lc_ProcessTime.Appearance.Options.UseTextOptions = true;
            this.lc_ProcessTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_ProcessTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lc_ProcessTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_ProcessTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_ProcessTime.Location = new System.Drawing.Point(814, 3);
            this.lc_ProcessTime.Name = "lc_ProcessTime";
            this.lc_ProcessTime.Size = new System.Drawing.Size(251, 42);
            this.lc_ProcessTime.TabIndex = 8;
            this.lc_ProcessTime.Text = "000:00:00";
            // 
            // tlp_ProcessTime
            // 
            this.tlp_ProcessTime.ColumnCount = 9;
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProcessTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlp_ProcessTime.Controls.Add(this.lc_TableCount, 5, 0);
            this.tlp_ProcessTime.Controls.Add(this.lc_ProcessTime, 7, 0);
            this.tlp_ProcessTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_ProcessTime.Location = new System.Drawing.Point(0, 165);
            this.tlp_ProcessTime.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ProcessTime.Name = "tlp_ProcessTime";
            this.tlp_ProcessTime.RowCount = 1;
            this.tlp_ProcessTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ProcessTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlp_ProcessTime.Size = new System.Drawing.Size(1080, 48);
            this.tlp_ProcessTime.TabIndex = 9;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("check", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.check"))));
            // 
            // lc_TableCount
            // 
            this.lc_TableCount.Appearance.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_TableCount.Appearance.Options.UseFont = true;
            this.lc_TableCount.Appearance.Options.UseTextOptions = true;
            this.lc_TableCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_TableCount.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lc_TableCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_TableCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_TableCount.Location = new System.Drawing.Point(547, 3);
            this.lc_TableCount.Name = "lc_TableCount";
            this.lc_TableCount.Size = new System.Drawing.Size(251, 42);
            this.lc_TableCount.TabIndex = 9;
            this.lc_TableCount.Text = "000 / 000";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 633);
            this.Controls.Add(this.tlp_BWList);
            this.Controls.Add(this.tlp_ProcessTime);
            this.Controls.Add(this.spb_Step);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.spb_Step)).EndInit();
            this.tlp_BWList.ResumeLayout(false);
            this.tlp_ProcessTime.ResumeLayout(false);
            this.tlp_ProcessTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.StepProgressBar spb_Step;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private System.Windows.Forms.TableLayoutPanel tlp_BWList;
        private BackgroundWorkerProgress backgroundWorkerProgress8;
        private BackgroundWorkerProgress backgroundWorkerProgress7;
        private BackgroundWorkerProgress backgroundWorkerProgress6;
        private BackgroundWorkerProgress backgroundWorkerProgress5;
        private BackgroundWorkerProgress backgroundWorkerProgress4;
        private BackgroundWorkerProgress backgroundWorkerProgress3;
        private BackgroundWorkerProgress backgroundWorkerProgress2;
        private BackgroundWorkerProgress backgroundWorkerProgress1;
        private DevExpress.XtraEditors.LabelControl lc_ProcessTime;
        private System.Windows.Forms.TableLayoutPanel tlp_ProcessTime;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.LabelControl lc_TableCount;
    }
}