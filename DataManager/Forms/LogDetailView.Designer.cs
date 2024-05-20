namespace DataManager
{
    partial class LogDetailView
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogDetailView));
            this.tc_LogDetailView = new DevExpress.XtraTab.XtraTabControl();
            this.tp_AllInOne = new DevExpress.XtraTab.XtraTabPage();
            this.tlp_AllInOne = new System.Windows.Forms.TableLayoutPanel();
            this.gc_Database = new DevExpress.XtraGrid.GridControl();
            this.gv_Database = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gc_DBTime = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_DatabaseName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_BackupFilePath = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_DBResult = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_DBErrorMessage = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gc_Site = new DevExpress.XtraGrid.GridControl();
            this.gv_Site = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gc_SiteTime = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_Result = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_ErrorMessage = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_SiteName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_Path = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gc_FilePath = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.tp_ETC = new DevExpress.XtraTab.XtraTabPage();
            this.gc_ETC = new DevExpress.XtraGrid.GridControl();
            this.gv_ETC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_LogMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ETCResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tc_LogDetailView)).BeginInit();
            this.tc_LogDetailView.SuspendLayout();
            this.tp_AllInOne.SuspendLayout();
            this.tlp_AllInOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.tp_ETC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ETC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ETC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_LogDetailView
            // 
            this.tc_LogDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_LogDetailView.Location = new System.Drawing.Point(0, 0);
            this.tc_LogDetailView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tc_LogDetailView.Name = "tc_LogDetailView";
            this.tc_LogDetailView.SelectedTabPage = this.tp_AllInOne;
            this.tc_LogDetailView.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tc_LogDetailView.Size = new System.Drawing.Size(1164, 562);
            this.tc_LogDetailView.TabIndex = 0;
            this.tc_LogDetailView.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_AllInOne,
            this.tp_ETC});
            // 
            // tp_AllInOne
            // 
            this.tp_AllInOne.Controls.Add(this.tlp_AllInOne);
            this.tp_AllInOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_AllInOne.Name = "tp_AllInOne";
            this.tp_AllInOne.Size = new System.Drawing.Size(1162, 560);
            this.tp_AllInOne.Text = "xtraTabPage1";
            // 
            // tlp_AllInOne
            // 
            this.tlp_AllInOne.ColumnCount = 1;
            this.tlp_AllInOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AllInOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_AllInOne.Controls.Add(this.gc_Database, 0, 1);
            this.tlp_AllInOne.Controls.Add(this.gc_Site, 0, 0);
            this.tlp_AllInOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_AllInOne.Location = new System.Drawing.Point(0, 0);
            this.tlp_AllInOne.Name = "tlp_AllInOne";
            this.tlp_AllInOne.RowCount = 2;
            this.tlp_AllInOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_AllInOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_AllInOne.Size = new System.Drawing.Size(1162, 560);
            this.tlp_AllInOne.TabIndex = 10;
            // 
            // gc_Database
            // 
            this.gc_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Database.Location = new System.Drawing.Point(3, 283);
            this.gc_Database.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Database.MainView = this.gv_Database;
            this.gc_Database.Name = "gc_Database";
            this.gc_Database.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit2});
            this.gc_Database.Size = new System.Drawing.Size(1156, 274);
            this.gc_Database.TabIndex = 10;
            this.gc_Database.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Database});
            // 
            // gv_Database
            // 
            this.gv_Database.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Database.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Database.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Database.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_Database.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Database.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_Database.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Database.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Database.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Database.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Database.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Database.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Database.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Database.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Database.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Database.Appearance.Row.Options.UseForeColor = true;
            this.gv_Database.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Database.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Database.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Database.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Database.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.gv_Database.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gc_DatabaseName,
            this.gc_BackupFilePath,
            this.gc_DBResult,
            this.gc_DBErrorMessage,
            this.gc_DBTime});
            this.gv_Database.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Expression = "[Result] = \'FAIL\'";
            formatConditionRuleExpression1.PredefinedName = "Red Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gv_Database.FormatRules.Add(gridFormatRule1);
            this.gv_Database.GridControl = this.gc_Database;
            this.gv_Database.Name = "gv_Database";
            this.gv_Database.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Database.OptionsView.ShowBands = false;
            this.gv_Database.OptionsView.ShowGroupPanel = false;
            this.gv_Database.OptionsView.ShowIndicator = false;
            this.gv_Database.RowHeight = 25;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand1";
            this.gridBand2.Columns.Add(this.gc_DBTime);
            this.gridBand2.Columns.Add(this.gc_DatabaseName);
            this.gridBand2.Columns.Add(this.gc_BackupFilePath);
            this.gridBand2.Columns.Add(this.gc_DBResult);
            this.gridBand2.Columns.Add(this.gc_DBErrorMessage);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 1152;
            // 
            // gc_DBTime
            // 
            this.gc_DBTime.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DBTime.AppearanceCell.Options.UseFont = true;
            this.gc_DBTime.AppearanceCell.Options.UseTextOptions = true;
            this.gc_DBTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DBTime.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DBTime.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_DBTime.AppearanceHeader.Options.UseFont = true;
            this.gc_DBTime.AppearanceHeader.Options.UseForeColor = true;
            this.gc_DBTime.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DBTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DBTime.Caption = "시간";
            this.gc_DBTime.FieldName = "Time";
            this.gc_DBTime.Name = "gc_DBTime";
            this.gc_DBTime.OptionsColumn.AllowEdit = false;
            this.gc_DBTime.OptionsColumn.AllowFocus = false;
            this.gc_DBTime.OptionsColumn.ReadOnly = true;
            this.gc_DBTime.OptionsFilter.AllowAutoFilter = false;
            this.gc_DBTime.OptionsFilter.AllowFilter = false;
            this.gc_DBTime.Visible = true;
            this.gc_DBTime.Width = 166;
            // 
            // gc_DatabaseName
            // 
            this.gc_DatabaseName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DatabaseName.AppearanceCell.Options.UseFont = true;
            this.gc_DatabaseName.AppearanceCell.Options.UseTextOptions = true;
            this.gc_DatabaseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DatabaseName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DatabaseName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_DatabaseName.AppearanceHeader.Options.UseFont = true;
            this.gc_DatabaseName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_DatabaseName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DatabaseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DatabaseName.Caption = "DB명";
            this.gc_DatabaseName.FieldName = "DatabaseName";
            this.gc_DatabaseName.Name = "gc_DatabaseName";
            this.gc_DatabaseName.OptionsColumn.AllowEdit = false;
            this.gc_DatabaseName.OptionsColumn.AllowFocus = false;
            this.gc_DatabaseName.OptionsColumn.ReadOnly = true;
            this.gc_DatabaseName.OptionsFilter.AllowAutoFilter = false;
            this.gc_DatabaseName.OptionsFilter.AllowFilter = false;
            this.gc_DatabaseName.Visible = true;
            this.gc_DatabaseName.Width = 157;
            // 
            // gc_BackupFilePath
            // 
            this.gc_BackupFilePath.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_BackupFilePath.AppearanceCell.Options.UseFont = true;
            this.gc_BackupFilePath.AppearanceCell.Options.UseTextOptions = true;
            this.gc_BackupFilePath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gc_BackupFilePath.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_BackupFilePath.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_BackupFilePath.AppearanceHeader.Options.UseFont = true;
            this.gc_BackupFilePath.AppearanceHeader.Options.UseForeColor = true;
            this.gc_BackupFilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_BackupFilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_BackupFilePath.Caption = "백업 파일 경로 (.bak)";
            this.gc_BackupFilePath.FieldName = "BackupFilePath";
            this.gc_BackupFilePath.Name = "gc_BackupFilePath";
            this.gc_BackupFilePath.OptionsColumn.AllowEdit = false;
            this.gc_BackupFilePath.OptionsColumn.AllowFocus = false;
            this.gc_BackupFilePath.OptionsColumn.ReadOnly = true;
            this.gc_BackupFilePath.OptionsFilter.AllowAutoFilter = false;
            this.gc_BackupFilePath.OptionsFilter.AllowFilter = false;
            this.gc_BackupFilePath.Visible = true;
            this.gc_BackupFilePath.Width = 829;
            // 
            // gc_DBResult
            // 
            this.gc_DBResult.AppearanceCell.Options.UseTextOptions = true;
            this.gc_DBResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DBResult.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DBResult.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_DBResult.AppearanceHeader.Options.UseFont = true;
            this.gc_DBResult.AppearanceHeader.Options.UseForeColor = true;
            this.gc_DBResult.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DBResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DBResult.Caption = "결과";
            this.gc_DBResult.FieldName = "Result";
            this.gc_DBResult.Name = "gc_DBResult";
            this.gc_DBResult.OptionsColumn.AllowEdit = false;
            this.gc_DBResult.OptionsColumn.AllowFocus = false;
            this.gc_DBResult.OptionsColumn.ReadOnly = true;
            this.gc_DBResult.OptionsFilter.AllowAutoFilter = false;
            this.gc_DBResult.OptionsFilter.AllowFilter = false;
            this.gc_DBResult.RowIndex = 1;
            this.gc_DBResult.Visible = true;
            this.gc_DBResult.Width = 166;
            // 
            // gc_DBErrorMessage
            // 
            this.gc_DBErrorMessage.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DBErrorMessage.AppearanceCell.Options.UseFont = true;
            this.gc_DBErrorMessage.AppearanceCell.Options.UseTextOptions = true;
            this.gc_DBErrorMessage.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gc_DBErrorMessage.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_DBErrorMessage.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_DBErrorMessage.AppearanceHeader.Options.UseFont = true;
            this.gc_DBErrorMessage.AppearanceHeader.Options.UseForeColor = true;
            this.gc_DBErrorMessage.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DBErrorMessage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DBErrorMessage.Caption = "오류메세지";
            this.gc_DBErrorMessage.FieldName = "ErrorMessage";
            this.gc_DBErrorMessage.Name = "gc_DBErrorMessage";
            this.gc_DBErrorMessage.OptionsColumn.AllowEdit = false;
            this.gc_DBErrorMessage.OptionsColumn.AllowFocus = false;
            this.gc_DBErrorMessage.OptionsColumn.ReadOnly = true;
            this.gc_DBErrorMessage.OptionsFilter.AllowAutoFilter = false;
            this.gc_DBErrorMessage.OptionsFilter.AllowFilter = false;
            this.gc_DBErrorMessage.RowIndex = 1;
            this.gc_DBErrorMessage.Visible = true;
            this.gc_DBErrorMessage.Width = 986;
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            this.repositoryItemImageEdit2.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemImageEdit2.ReadOnly = true;
            this.repositoryItemImageEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemImageEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // gc_Site
            // 
            this.gc_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Site.Location = new System.Drawing.Point(3, 3);
            this.gc_Site.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Site.MainView = this.gv_Site;
            this.gc_Site.Name = "gc_Site";
            this.gc_Site.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gc_Site.Size = new System.Drawing.Size(1156, 274);
            this.gc_Site.TabIndex = 9;
            this.gc_Site.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Site});
            // 
            // gv_Site
            // 
            this.gv_Site.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Site.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Site.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Site.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_Site.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Site.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_Site.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Site.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Site.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Site.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Site.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Site.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Site.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Site.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Site.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Site.Appearance.Row.Options.UseForeColor = true;
            this.gv_Site.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Site.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Site.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Site.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Site.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gv_Site.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gc_SiteName,
            this.gc_Path,
            this.gc_FilePath,
            this.gc_Result,
            this.gc_ErrorMessage,
            this.gc_SiteTime});
            this.gv_Site.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Expression = "[Result] = \'FAIL\'";
            formatConditionRuleExpression2.PredefinedName = "Red Fill";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gv_Site.FormatRules.Add(gridFormatRule2);
            this.gv_Site.GridControl = this.gc_Site;
            this.gv_Site.Name = "gv_Site";
            this.gv_Site.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Site.OptionsView.ShowBands = false;
            this.gv_Site.OptionsView.ShowGroupPanel = false;
            this.gv_Site.OptionsView.ShowIndicator = false;
            this.gv_Site.RowHeight = 25;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.gc_SiteTime);
            this.gridBand1.Columns.Add(this.gc_SiteName);
            this.gridBand1.Columns.Add(this.gc_Path);
            this.gridBand1.Columns.Add(this.gc_FilePath);
            this.gridBand1.Columns.Add(this.gc_Result);
            this.gridBand1.Columns.Add(this.gc_ErrorMessage);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1152;
            // 
            // gc_SiteTime
            // 
            this.gc_SiteTime.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_SiteTime.AppearanceCell.Options.UseFont = true;
            this.gc_SiteTime.AppearanceCell.Options.UseTextOptions = true;
            this.gc_SiteTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteTime.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_SiteTime.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_SiteTime.AppearanceHeader.Options.UseFont = true;
            this.gc_SiteTime.AppearanceHeader.Options.UseForeColor = true;
            this.gc_SiteTime.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SiteTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteTime.Caption = "시간";
            this.gc_SiteTime.FieldName = "Time";
            this.gc_SiteTime.Name = "gc_SiteTime";
            this.gc_SiteTime.OptionsColumn.AllowEdit = false;
            this.gc_SiteTime.OptionsColumn.AllowFocus = false;
            this.gc_SiteTime.OptionsColumn.ReadOnly = true;
            this.gc_SiteTime.OptionsFilter.AllowAutoFilter = false;
            this.gc_SiteTime.OptionsFilter.AllowFilter = false;
            this.gc_SiteTime.Visible = true;
            this.gc_SiteTime.Width = 166;
            // 
            // gc_Result
            // 
            this.gc_Result.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Result.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Result.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_Result.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Result.AppearanceHeader.Options.UseFont = true;
            this.gc_Result.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Result.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Result.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Result.Caption = "결과";
            this.gc_Result.FieldName = "Result";
            this.gc_Result.Name = "gc_Result";
            this.gc_Result.OptionsColumn.AllowEdit = false;
            this.gc_Result.OptionsColumn.AllowFocus = false;
            this.gc_Result.OptionsColumn.ReadOnly = true;
            this.gc_Result.OptionsFilter.AllowAutoFilter = false;
            this.gc_Result.OptionsFilter.AllowFilter = false;
            this.gc_Result.RowIndex = 1;
            this.gc_Result.Visible = true;
            this.gc_Result.Width = 166;
            // 
            // gc_ErrorMessage
            // 
            this.gc_ErrorMessage.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_ErrorMessage.AppearanceCell.Options.UseFont = true;
            this.gc_ErrorMessage.AppearanceCell.Options.UseTextOptions = true;
            this.gc_ErrorMessage.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gc_ErrorMessage.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_ErrorMessage.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_ErrorMessage.AppearanceHeader.Options.UseFont = true;
            this.gc_ErrorMessage.AppearanceHeader.Options.UseForeColor = true;
            this.gc_ErrorMessage.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ErrorMessage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ErrorMessage.Caption = "오류메세지";
            this.gc_ErrorMessage.FieldName = "ErrorMessage";
            this.gc_ErrorMessage.Name = "gc_ErrorMessage";
            this.gc_ErrorMessage.OptionsColumn.AllowEdit = false;
            this.gc_ErrorMessage.OptionsColumn.AllowFocus = false;
            this.gc_ErrorMessage.OptionsColumn.ReadOnly = true;
            this.gc_ErrorMessage.OptionsFilter.AllowAutoFilter = false;
            this.gc_ErrorMessage.OptionsFilter.AllowFilter = false;
            this.gc_ErrorMessage.RowIndex = 1;
            this.gc_ErrorMessage.Visible = true;
            this.gc_ErrorMessage.Width = 986;
            // 
            // gc_SiteName
            // 
            this.gc_SiteName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_SiteName.AppearanceCell.Options.UseFont = true;
            this.gc_SiteName.AppearanceCell.Options.UseTextOptions = true;
            this.gc_SiteName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_SiteName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_SiteName.AppearanceHeader.Options.UseFont = true;
            this.gc_SiteName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_SiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteName.Caption = "IIS 사이트명";
            this.gc_SiteName.FieldName = "SiteName";
            this.gc_SiteName.Name = "gc_SiteName";
            this.gc_SiteName.OptionsColumn.AllowEdit = false;
            this.gc_SiteName.OptionsColumn.AllowFocus = false;
            this.gc_SiteName.OptionsColumn.ReadOnly = true;
            this.gc_SiteName.OptionsFilter.AllowAutoFilter = false;
            this.gc_SiteName.OptionsFilter.AllowFilter = false;
            this.gc_SiteName.Visible = true;
            this.gc_SiteName.Width = 219;
            // 
            // gc_Path
            // 
            this.gc_Path.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_Path.AppearanceCell.Options.UseFont = true;
            this.gc_Path.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Path.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gc_Path.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_Path.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Path.AppearanceHeader.Options.UseFont = true;
            this.gc_Path.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Path.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Path.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Path.Caption = "경로";
            this.gc_Path.FieldName = "Path";
            this.gc_Path.Name = "gc_Path";
            this.gc_Path.OptionsColumn.AllowEdit = false;
            this.gc_Path.OptionsColumn.AllowFocus = false;
            this.gc_Path.OptionsColumn.ReadOnly = true;
            this.gc_Path.OptionsFilter.AllowAutoFilter = false;
            this.gc_Path.OptionsFilter.AllowFilter = false;
            this.gc_Path.Visible = true;
            this.gc_Path.Width = 318;
            // 
            // gc_FilePath
            // 
            this.gc_FilePath.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_FilePath.AppearanceCell.Options.UseFont = true;
            this.gc_FilePath.AppearanceCell.Options.UseTextOptions = true;
            this.gc_FilePath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gc_FilePath.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_FilePath.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_FilePath.AppearanceHeader.Options.UseFont = true;
            this.gc_FilePath.AppearanceHeader.Options.UseForeColor = true;
            this.gc_FilePath.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_FilePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FilePath.Caption = "배포 파일 경로 (.zip)";
            this.gc_FilePath.FieldName = "FilePath";
            this.gc_FilePath.Name = "gc_FilePath";
            this.gc_FilePath.OptionsColumn.AllowEdit = false;
            this.gc_FilePath.OptionsColumn.AllowFocus = false;
            this.gc_FilePath.OptionsColumn.ReadOnly = true;
            this.gc_FilePath.OptionsFilter.AllowAutoFilter = false;
            this.gc_FilePath.OptionsFilter.AllowFilter = false;
            this.gc_FilePath.Visible = true;
            this.gc_FilePath.Width = 449;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemImageEdit1.ReadOnly = true;
            this.repositoryItemImageEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // tp_ETC
            // 
            this.tp_ETC.Controls.Add(this.gc_ETC);
            this.tp_ETC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tp_ETC.Name = "tp_ETC";
            this.tp_ETC.Size = new System.Drawing.Size(1162, 560);
            this.tp_ETC.Text = "xtraTabPage2";
            // 
            // gc_ETC
            // 
            this.gc_ETC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ETC.Location = new System.Drawing.Point(0, 0);
            this.gc_ETC.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_ETC.MainView = this.gv_ETC;
            this.gc_ETC.Name = "gc_ETC";
            this.gc_ETC.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gc_ETC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit3});
            this.gc_ETC.Size = new System.Drawing.Size(1162, 560);
            this.gc_ETC.TabIndex = 10;
            this.gc_ETC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ETC});
            // 
            // gv_ETC
            // 
            this.gv_ETC.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_ETC.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_ETC.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_ETC.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_ETC.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_ETC.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_ETC.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_ETC.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_ETC.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_ETC.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_ETC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_ETC.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_ETC.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_ETC.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_ETC.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_ETC.Appearance.Row.Options.UseForeColor = true;
            this.gv_ETC.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_ETC.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_ETC.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_ETC.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_ETC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_LogMessage,
            this.gc_Time,
            this.gc_ETCResult});
            this.gv_ETC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format0";
            formatConditionRuleExpression3.Expression = "[Result] = \'FAIL\'";
            formatConditionRuleExpression3.PredefinedName = "Red Fill";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.gv_ETC.FormatRules.Add(gridFormatRule3);
            this.gv_ETC.GridControl = this.gc_ETC;
            this.gv_ETC.Name = "gv_ETC";
            this.gv_ETC.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_ETC.OptionsView.ShowGroupPanel = false;
            this.gv_ETC.OptionsView.ShowIndicator = false;
            this.gv_ETC.RowHeight = 25;
            // 
            // gc_LogMessage
            // 
            this.gc_LogMessage.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_LogMessage.AppearanceCell.Options.UseFont = true;
            this.gc_LogMessage.AppearanceCell.Options.UseTextOptions = true;
            this.gc_LogMessage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gc_LogMessage.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_LogMessage.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_LogMessage.AppearanceHeader.Options.UseFont = true;
            this.gc_LogMessage.AppearanceHeader.Options.UseForeColor = true;
            this.gc_LogMessage.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_LogMessage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_LogMessage.Caption = "로그 메세지";
            this.gc_LogMessage.FieldName = "LogMessage";
            this.gc_LogMessage.Name = "gc_LogMessage";
            this.gc_LogMessage.OptionsColumn.AllowEdit = false;
            this.gc_LogMessage.OptionsColumn.AllowFocus = false;
            this.gc_LogMessage.OptionsColumn.ReadOnly = true;
            this.gc_LogMessage.OptionsFilter.AllowAutoFilter = false;
            this.gc_LogMessage.OptionsFilter.AllowFilter = false;
            this.gc_LogMessage.Visible = true;
            this.gc_LogMessage.VisibleIndex = 2;
            this.gc_LogMessage.Width = 809;
            // 
            // gc_Time
            // 
            this.gc_Time.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_Time.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gc_Time.AppearanceCell.Options.UseFont = true;
            this.gc_Time.AppearanceCell.Options.UseForeColor = true;
            this.gc_Time.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Time.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_Time.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Time.AppearanceHeader.Options.UseFont = true;
            this.gc_Time.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Time.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Time.Caption = "시간";
            this.gc_Time.FieldName = "Time";
            this.gc_Time.Name = "gc_Time";
            this.gc_Time.OptionsColumn.AllowEdit = false;
            this.gc_Time.Visible = true;
            this.gc_Time.VisibleIndex = 0;
            this.gc_Time.Width = 199;
            // 
            // gc_ETCResult
            // 
            this.gc_ETCResult.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_ETCResult.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gc_ETCResult.AppearanceCell.Options.UseFont = true;
            this.gc_ETCResult.AppearanceCell.Options.UseForeColor = true;
            this.gc_ETCResult.AppearanceCell.Options.UseTextOptions = true;
            this.gc_ETCResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ETCResult.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.gc_ETCResult.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_ETCResult.AppearanceHeader.Options.UseFont = true;
            this.gc_ETCResult.AppearanceHeader.Options.UseForeColor = true;
            this.gc_ETCResult.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ETCResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ETCResult.Caption = "결과";
            this.gc_ETCResult.FieldName = "Result";
            this.gc_ETCResult.Name = "gc_ETCResult";
            this.gc_ETCResult.OptionsColumn.AllowEdit = false;
            this.gc_ETCResult.Visible = true;
            this.gc_ETCResult.VisibleIndex = 1;
            this.gc_ETCResult.Width = 122;
            // 
            // repositoryItemImageEdit3
            // 
            this.repositoryItemImageEdit3.AutoHeight = false;
            this.repositoryItemImageEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit3.Name = "repositoryItemImageEdit3";
            this.repositoryItemImageEdit3.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemImageEdit3.ReadOnly = true;
            this.repositoryItemImageEdit3.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemImageEdit3.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // LogDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 562);
            this.Controls.Add(this.tc_LogDetailView);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Log";
            ((System.ComponentModel.ISupportInitialize)(this.tc_LogDetailView)).EndInit();
            this.tc_LogDetailView.ResumeLayout(false);
            this.tp_AllInOne.ResumeLayout(false);
            this.tlp_AllInOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.tp_ETC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ETC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ETC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tc_LogDetailView;
        private DevExpress.XtraTab.XtraTabPage tp_AllInOne;
        private DevExpress.XtraTab.XtraTabPage tp_ETC;
        private DevExpress.XtraGrid.GridControl gc_Site;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private System.Windows.Forms.TableLayoutPanel tlp_AllInOne;
        private DevExpress.XtraGrid.GridControl gc_ETC;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit3;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gv_Site;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_SiteTime;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_Result;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_ErrorMessage;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_SiteName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_Path;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_FilePath;
        private DevExpress.XtraGrid.GridControl gc_Database;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gv_Database;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_DBResult;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_DBErrorMessage;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_DatabaseName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_BackupFilePath;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gc_DBTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ETC;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LogMessage;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Time;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ETCResult;
    }
}