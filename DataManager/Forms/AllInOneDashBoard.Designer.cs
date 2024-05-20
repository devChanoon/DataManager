namespace DataManager
{
    partial class AllInOneDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInOneDashBoard));
            this.copyData = new DataManager.CopyData();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gc_Database = new DevExpress.XtraGrid.GridControl();
            this.gv_Database = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_DbName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_BackupFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.tlp_AllInOneDashBoard = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Site = new System.Windows.Forms.Panel();
            this.gc_Site = new DevExpress.XtraGrid.GridControl();
            this.gv_Site = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_SiteStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gc_SiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lc_SiteStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            this.tlp_AllInOneDashBoard.SuspendLayout();
            this.pnl_Site.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // copyData
            // 
            this.copyData.BackColor = System.Drawing.Color.White;
            this.copyData.Close = null;
            this.copyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyData.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyData.Location = new System.Drawing.Point(3, 330);
            this.copyData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.copyData.Name = "copyData";
            this.copyData.Size = new System.Drawing.Size(1074, 586);
            this.copyData.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "complete.png");
            this.imageList1.Images.SetKeyName(1, "error.png");
            this.imageList1.Images.SetKeyName(2, "wait.png");
            // 
            // gc_Database
            // 
            this.gc_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Database.Location = new System.Drawing.Point(3, 183);
            this.gc_Database.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Database.MainView = this.gv_Database;
            this.gc_Database.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gc_Database.Name = "gc_Database";
            this.gc_Database.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit2,
            this.repositoryItemImageComboBox1});
            this.gc_Database.Size = new System.Drawing.Size(1074, 147);
            this.gc_Database.TabIndex = 9;
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
            this.gv_Database.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_DbName,
            this.gc_BackupFilePath,
            this.gc_status});
            this.gv_Database.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Database.GridControl = this.gc_Database;
            this.gv_Database.Name = "gv_Database";
            this.gv_Database.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Database.OptionsView.ShowGroupPanel = false;
            this.gv_Database.OptionsView.ShowIndicator = false;
            this.gv_Database.RowHeight = 25;
            // 
            // gc_DbName
            // 
            this.gc_DbName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_DbName.AppearanceCell.Options.UseFont = true;
            this.gc_DbName.AppearanceCell.Options.UseTextOptions = true;
            this.gc_DbName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DbName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_DbName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_DbName.AppearanceHeader.Options.UseFont = true;
            this.gc_DbName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_DbName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DbName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DbName.Caption = "DB명";
            this.gc_DbName.FieldName = "DBName";
            this.gc_DbName.Name = "gc_DbName";
            this.gc_DbName.OptionsFilter.AllowAutoFilter = false;
            this.gc_DbName.OptionsFilter.AllowFilter = false;
            this.gc_DbName.Visible = true;
            this.gc_DbName.VisibleIndex = 1;
            this.gc_DbName.Width = 227;
            // 
            // gc_BackupFilePath
            // 
            this.gc_BackupFilePath.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_BackupFilePath.AppearanceCell.Options.UseFont = true;
            this.gc_BackupFilePath.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gc_BackupFilePath.OptionsFilter.AllowAutoFilter = false;
            this.gc_BackupFilePath.OptionsFilter.AllowFilter = false;
            this.gc_BackupFilePath.Visible = true;
            this.gc_BackupFilePath.VisibleIndex = 2;
            this.gc_BackupFilePath.Width = 780;
            // 
            // gc_status
            // 
            this.gc_status.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_status.AppearanceCell.Options.UseFont = true;
            this.gc_status.AppearanceCell.Options.UseTextOptions = true;
            this.gc_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gc_status.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_status.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_status.AppearanceHeader.Options.UseFont = true;
            this.gc_status.AppearanceHeader.Options.UseForeColor = true;
            this.gc_status.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_status.Caption = "상태";
            this.gc_status.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gc_status.FieldName = "Status";
            this.gc_status.Name = "gc_status";
            this.gc_status.OptionsColumn.AllowEdit = false;
            this.gc_status.OptionsColumn.AllowFocus = false;
            this.gc_status.OptionsFilter.AllowAutoFilter = false;
            this.gc_status.OptionsFilter.AllowFilter = false;
            this.gc_status.Visible = true;
            this.gc_status.VisibleIndex = 0;
            this.gc_status.Width = 65;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "Y", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "N", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "", 2)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.ReadOnly = true;
            this.repositoryItemImageComboBox1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Images = this.imageList1;
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            // 
            // tlp_AllInOneDashBoard
            // 
            this.tlp_AllInOneDashBoard.ColumnCount = 1;
            this.tlp_AllInOneDashBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AllInOneDashBoard.Controls.Add(this.copyData, 0, 2);
            this.tlp_AllInOneDashBoard.Controls.Add(this.gc_Database, 0, 1);
            this.tlp_AllInOneDashBoard.Controls.Add(this.pnl_Site, 0, 0);
            this.tlp_AllInOneDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_AllInOneDashBoard.Location = new System.Drawing.Point(0, 0);
            this.tlp_AllInOneDashBoard.Name = "tlp_AllInOneDashBoard";
            this.tlp_AllInOneDashBoard.RowCount = 3;
            this.tlp_AllInOneDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlp_AllInOneDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_AllInOneDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AllInOneDashBoard.Size = new System.Drawing.Size(1080, 920);
            this.tlp_AllInOneDashBoard.TabIndex = 10;
            // 
            // pnl_Site
            // 
            this.pnl_Site.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Site.Controls.Add(this.gc_Site);
            this.pnl_Site.Controls.Add(this.lc_SiteStatus);
            this.pnl_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Site.Location = new System.Drawing.Point(3, 3);
            this.pnl_Site.Name = "pnl_Site";
            this.pnl_Site.Size = new System.Drawing.Size(1074, 174);
            this.pnl_Site.TabIndex = 10;
            // 
            // gc_Site
            // 
            this.gc_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Site.Location = new System.Drawing.Point(0, 0);
            this.gc_Site.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Site.MainView = this.gv_Site;
            this.gc_Site.Name = "gc_Site";
            this.gc_Site.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox2});
            this.gc_Site.Size = new System.Drawing.Size(1072, 145);
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
            this.gv_Site.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_SiteStatus,
            this.gc_SiteName,
            this.gc_Path,
            this.gc_FilePath});
            this.gv_Site.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Site.GridControl = this.gc_Site;
            this.gv_Site.Name = "gv_Site";
            this.gv_Site.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Site.OptionsView.ShowGroupPanel = false;
            this.gv_Site.OptionsView.ShowIndicator = false;
            this.gv_Site.RowHeight = 25;
            // 
            // gc_SiteStatus
            // 
            this.gc_SiteStatus.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_SiteStatus.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_SiteStatus.AppearanceHeader.Options.UseFont = true;
            this.gc_SiteStatus.AppearanceHeader.Options.UseForeColor = true;
            this.gc_SiteStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SiteStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteStatus.Caption = "상태";
            this.gc_SiteStatus.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gc_SiteStatus.FieldName = "Status";
            this.gc_SiteStatus.Name = "gc_SiteStatus";
            this.gc_SiteStatus.OptionsColumn.AllowEdit = false;
            this.gc_SiteStatus.OptionsColumn.AllowFocus = false;
            this.gc_SiteStatus.OptionsFilter.AllowAutoFilter = false;
            this.gc_SiteStatus.OptionsFilter.AllowFilter = false;
            this.gc_SiteStatus.Visible = true;
            this.gc_SiteStatus.VisibleIndex = 0;
            this.gc_SiteStatus.Width = 65;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "Y", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "N", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "", 2)});
            this.repositoryItemImageComboBox2.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.ReadOnly = true;
            this.repositoryItemImageComboBox2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // gc_SiteName
            // 
            this.gc_SiteName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_SiteName.AppearanceCell.Options.UseFont = true;
            this.gc_SiteName.AppearanceCell.Options.UseTextOptions = true;
            this.gc_SiteName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_SiteName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_SiteName.AppearanceHeader.Options.UseFont = true;
            this.gc_SiteName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_SiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SiteName.Caption = "IIS 사이트명";
            this.gc_SiteName.FieldName = "SiteName";
            this.gc_SiteName.Name = "gc_SiteName";
            this.gc_SiteName.OptionsFilter.AllowAutoFilter = false;
            this.gc_SiteName.OptionsFilter.AllowFilter = false;
            this.gc_SiteName.Visible = true;
            this.gc_SiteName.VisibleIndex = 1;
            this.gc_SiteName.Width = 166;
            // 
            // gc_Path
            // 
            this.gc_Path.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Path.AppearanceCell.Options.UseFont = true;
            this.gc_Path.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gc_Path.OptionsFilter.AllowAutoFilter = false;
            this.gc_Path.OptionsFilter.AllowFilter = false;
            this.gc_Path.Visible = true;
            this.gc_Path.VisibleIndex = 2;
            this.gc_Path.Width = 413;
            // 
            // gc_FilePath
            // 
            this.gc_FilePath.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_FilePath.AppearanceCell.Options.UseFont = true;
            this.gc_FilePath.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gc_FilePath.OptionsFilter.AllowAutoFilter = false;
            this.gc_FilePath.OptionsFilter.AllowFilter = false;
            this.gc_FilePath.Visible = true;
            this.gc_FilePath.VisibleIndex = 3;
            this.gc_FilePath.Width = 428;
            // 
            // lc_SiteStatus
            // 
            this.lc_SiteStatus.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_SiteStatus.Appearance.Options.UseFont = true;
            this.lc_SiteStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_SiteStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lc_SiteStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lc_SiteStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lc_SiteStatus.ImageOptions.Image")));
            this.lc_SiteStatus.IndentBetweenImageAndText = 10;
            this.lc_SiteStatus.Location = new System.Drawing.Point(0, 145);
            this.lc_SiteStatus.Name = "lc_SiteStatus";
            this.lc_SiteStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lc_SiteStatus.Size = new System.Drawing.Size(1072, 27);
            this.lc_SiteStatus.TabIndex = 10;
            // 
            // AllInOneDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 920);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_AllInOneDashBoard);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllInOneDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllInOneDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            this.tlp_AllInOneDashBoard.ResumeLayout(false);
            this.pnl_Site.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CopyData copyData;
        private DevExpress.XtraGrid.GridControl gc_Database;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Database;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DbName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BackupFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn gc_status;
        private System.Windows.Forms.TableLayoutPanel tlp_AllInOneDashBoard;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.Panel pnl_Site;
        private DevExpress.XtraGrid.GridControl gc_Site;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Site;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SiteStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SiteName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Path;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FilePath;
        private DevExpress.XtraEditors.LabelControl lc_SiteStatus;
    }
}