
namespace DataManager
{
    partial class Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sb_Log = new DevExpress.XtraEditors.SimpleButton();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_DBName = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_DBAddress = new System.Windows.Forms.TextBox();
            this.cbe_ViewPassword = new DevExpress.XtraEditors.CheckButton();
            this.sb_Connect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tc_WorkType = new DevExpress.XtraTab.XtraTabControl();
            this.tp_AllInOne = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gc_Site = new DevExpress.XtraGrid.GridControl();
            this.gv_Site = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_SiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gc_Database = new DevExpress.XtraGrid.GridControl();
            this.gv_Database = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_DbName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_BackupFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_SitePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sb_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Add = new DevExpress.XtraEditors.SimpleButton();
            this.sb_AllInOneExecute = new DevExpress.XtraEditors.SimpleButton();
            this.tp_Copy = new DevExpress.XtraTab.XtraTabPage();
            this.gb_Copy = new System.Windows.Forms.GroupBox();
            this.gc_TableList = new DevExpress.XtraGrid.GridControl();
            this.gv_TableList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_ce_Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gc_TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TableSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nud_MaxThread = new System.Windows.Forms.NumericUpDown();
            this.sb_FindTable = new DevExpress.XtraEditors.SimpleButton();
            this.te_TableName = new DevExpress.XtraEditors.TextEdit();
            this.sb_UncheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.sb_CheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_Step4_Checked_Count = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lc_Checked_Count = new DevExpress.XtraEditors.LabelControl();
            this.sb_Execute = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_Step = new System.Windows.Forms.TableLayoutPanel();
            this.lc_SrcDB = new DevExpress.XtraEditors.LabelControl();
            this.cb_SrcDB = new System.Windows.Forms.ComboBox();
            this.tp_ModifyDatabase = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModifyLog = new DataManager.Log();
            this.pnl_ModifyTop = new System.Windows.Forms.Panel();
            this.tlp_ModifyTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lb_LogDBPath = new DevExpress.XtraEditors.LabelControl();
            this.lb_DataDBPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sb_ModifyExecute = new DevExpress.XtraEditors.SimpleButton();
            this.lb_DataDBName = new DevExpress.XtraEditors.LabelControl();
            this.lb_LogDBName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_WorkType)).BeginInit();
            this.tc_WorkType.SuspendLayout();
            this.tp_AllInOne.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tp_Copy.SuspendLayout();
            this.gb_Copy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_Check)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TableName.Properties)).BeginInit();
            this.tlp_Step4_Checked_Count.SuspendLayout();
            this.tlp_Step.SuspendLayout();
            this.tp_ModifyDatabase.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_ModifyTop.SuspendLayout();
            this.tlp_ModifyTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleController1
            // 
            this.styleController1.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.styleController1.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.styleController1.Appearance.Options.UseBackColor = true;
            this.styleController1.Appearance.Options.UseBorderColor = true;
            this.styleController1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sb_Log);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.tb_DBName);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.tb_DBAddress);
            this.groupBox1.Controls.Add(this.cbe_ViewPassword);
            this.groupBox1.Controls.Add(this.sb_Connect);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Information";
            // 
            // sb_Log
            // 
            this.sb_Log.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Log.Appearance.Options.UseFont = true;
            this.sb_Log.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Log.Location = new System.Drawing.Point(982, 19);
            this.sb_Log.Name = "sb_Log";
            this.sb_Log.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Log.Size = new System.Drawing.Size(124, 53);
            this.sb_Log.TabIndex = 10;
            this.sb_Log.Text = "LOG";
            this.sb_Log.Click += new System.EventHandler(this.sb_Log_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Password.Location = new System.Drawing.Point(516, 49);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(272, 23);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.Text = "!1Tascorp";
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_DBName
            // 
            this.tb_DBName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_DBName.Location = new System.Drawing.Point(516, 20);
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(300, 23);
            this.tb_DBName.TabIndex = 1;
            this.tb_DBName.Text = "RTEGMS_NATUREFARM";
            this.tb_DBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ID.Location = new System.Drawing.Point(110, 49);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(300, 23);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.Text = "sa";
            this.tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_DBAddress
            // 
            this.tb_DBAddress.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_DBAddress.Location = new System.Drawing.Point(110, 20);
            this.tb_DBAddress.Name = "tb_DBAddress";
            this.tb_DBAddress.Size = new System.Drawing.Size(300, 23);
            this.tb_DBAddress.TabIndex = 0;
            this.tb_DBAddress.Text = "sf.tascorp.co.kr";
            this.tb_DBAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbe_ViewPassword
            // 
            this.cbe_ViewPassword.AllowFocus = false;
            this.cbe_ViewPassword.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbe_ViewPassword.AppearancePressed.Options.UseBackColor = true;
            this.cbe_ViewPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbe_ViewPassword.ImageOptions.Image")));
            this.cbe_ViewPassword.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cbe_ViewPassword.Location = new System.Drawing.Point(787, 49);
            this.cbe_ViewPassword.Name = "cbe_ViewPassword";
            this.cbe_ViewPassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cbe_ViewPassword.Size = new System.Drawing.Size(28, 23);
            this.cbe_ViewPassword.TabIndex = 9;
            this.cbe_ViewPassword.CheckedChanged += new System.EventHandler(this.cbe_ViewPassword_CheckedChanged);
            // 
            // sb_Connect
            // 
            this.sb_Connect.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Connect.Appearance.Options.UseFont = true;
            this.sb_Connect.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Connect.Location = new System.Drawing.Point(852, 19);
            this.sb_Connect.Name = "sb_Connect";
            this.sb_Connect.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Connect.Size = new System.Drawing.Size(124, 53);
            this.sb_Connect.TabIndex = 5;
            this.sb_Connect.Text = "CONNECT";
            this.sb_Connect.Click += new System.EventHandler(this.sb_Connect_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "ID";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(448, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(448, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "DB Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server";
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Controls.Add(this.groupBox1, 0, 0);
            this.tlp_Main.Controls.Add(this.tc_WorkType, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(1139, 677);
            this.tlp_Main.TabIndex = 5;
            // 
            // tc_WorkType
            // 
            this.tc_WorkType.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.tc_WorkType.Appearance.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.Header.BackColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.Header.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.Header.Options.UseBorderColor = true;
            this.tc_WorkType.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tc_WorkType.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.tc_WorkType.AppearancePage.HeaderDisabled.BackColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.HeaderDisabled.BorderColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.HeaderDisabled.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.HeaderDisabled.Options.UseBorderColor = true;
            this.tc_WorkType.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.HeaderHotTracked.BorderColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.HeaderHotTracked.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.HeaderHotTracked.Options.UseBorderColor = true;
            this.tc_WorkType.AppearancePage.PageClient.BackColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.PageClient.BorderColor = System.Drawing.Color.White;
            this.tc_WorkType.AppearancePage.PageClient.Options.UseBackColor = true;
            this.tc_WorkType.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.tc_WorkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_WorkType.Enabled = false;
            this.tc_WorkType.Location = new System.Drawing.Point(3, 93);
            this.tc_WorkType.Name = "tc_WorkType";
            this.tc_WorkType.SelectedTabPage = this.tp_AllInOne;
            this.tc_WorkType.Size = new System.Drawing.Size(1133, 581);
            this.tc_WorkType.TabIndex = 2;
            this.tc_WorkType.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_AllInOne,
            this.tp_Copy,
            this.tp_ModifyDatabase});
            // 
            // tp_AllInOne
            // 
            this.tp_AllInOne.Controls.Add(this.groupBox3);
            this.tp_AllInOne.Name = "tp_AllInOne";
            this.tp_AllInOne.Size = new System.Drawing.Size(1131, 555);
            this.tp_AllInOne.Text = "All In One";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gc_Site);
            this.groupBox3.Controls.Add(this.gc_Database);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1131, 555);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // gc_Site
            // 
            this.gc_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Site.Location = new System.Drawing.Point(3, 61);
            this.gc_Site.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Site.MainView = this.gv_Site;
            this.gc_Site.Name = "gc_Site";
            this.gc_Site.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_Site.Size = new System.Drawing.Size(1125, 332);
            this.gc_Site.TabIndex = 7;
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
            this.gv_Site.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_Site_RowCellClick);
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
            this.gc_SiteName.VisibleIndex = 0;
            this.gc_SiteName.Width = 187;
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
            this.gc_Path.VisibleIndex = 1;
            this.gc_Path.Width = 466;
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
            this.gc_FilePath.VisibleIndex = 2;
            this.gc_FilePath.Width = 479;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = "Y";
            this.repositoryItemCheckEdit1.ValueUnchecked = "N";
            // 
            // gc_Database
            // 
            this.gc_Database.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Database.Location = new System.Drawing.Point(3, 393);
            this.gc_Database.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Database.MainView = this.gv_Database;
            this.gc_Database.Name = "gc_Database";
            this.gc_Database.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gc_Database.Size = new System.Drawing.Size(1125, 159);
            this.gc_Database.TabIndex = 8;
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
            this.gc_SitePath});
            this.gv_Database.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Database.GridControl = this.gc_Database;
            this.gv_Database.Name = "gv_Database";
            this.gv_Database.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Database.OptionsView.ShowGroupPanel = false;
            this.gv_Database.OptionsView.ShowIndicator = false;
            this.gv_Database.RowHeight = 25;
            this.gv_Database.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_Database_RowCellClick);
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
            this.gc_DbName.VisibleIndex = 0;
            this.gc_DbName.Width = 188;
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
            this.gc_BackupFilePath.VisibleIndex = 1;
            this.gc_BackupFilePath.Width = 911;
            // 
            // gc_SitePath
            // 
            this.gc_SitePath.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_SitePath.AppearanceCell.Options.UseFont = true;
            this.gc_SitePath.AppearanceCell.Options.UseTextOptions = true;
            this.gc_SitePath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gc_SitePath.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_SitePath.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_SitePath.AppearanceHeader.Options.UseFont = true;
            this.gc_SitePath.AppearanceHeader.Options.UseForeColor = true;
            this.gc_SitePath.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SitePath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SitePath.Caption = "사이트 경로";
            this.gc_SitePath.FieldName = "SitePath";
            this.gc_SitePath.Name = "gc_SitePath";
            this.gc_SitePath.OptionsColumn.AllowEdit = false;
            this.gc_SitePath.OptionsColumn.AllowFocus = false;
            this.gc_SitePath.OptionsFilter.AllowAutoFilter = false;
            this.gc_SitePath.OptionsFilter.AllowFilter = false;
            this.gc_SitePath.Width = 201;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = "Y";
            this.repositoryItemCheckEdit2.ValueUnchecked = "N";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sb_Delete);
            this.panel1.Controls.Add(this.sb_Add);
            this.panel1.Controls.Add(this.sb_AllInOneExecute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 43);
            this.panel1.TabIndex = 6;
            // 
            // sb_Delete
            // 
            this.sb_Delete.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_Delete.Appearance.Options.UseFont = true;
            this.sb_Delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Delete.Location = new System.Drawing.Point(89, 4);
            this.sb_Delete.Name = "sb_Delete";
            this.sb_Delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Delete.Size = new System.Drawing.Size(83, 34);
            this.sb_Delete.TabIndex = 13;
            this.sb_Delete.Text = "삭제";
            this.sb_Delete.Click += new System.EventHandler(this.sb_Delete_Click);
            // 
            // sb_Add
            // 
            this.sb_Add.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_Add.Appearance.Options.UseFont = true;
            this.sb_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Add.Location = new System.Drawing.Point(3, 4);
            this.sb_Add.Name = "sb_Add";
            this.sb_Add.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Add.Size = new System.Drawing.Size(83, 34);
            this.sb_Add.TabIndex = 12;
            this.sb_Add.Text = "추가";
            this.sb_Add.Click += new System.EventHandler(this.sb_Add_Click);
            // 
            // sb_AllInOneExecute
            // 
            this.sb_AllInOneExecute.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_AllInOneExecute.Appearance.Options.UseFont = true;
            this.sb_AllInOneExecute.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_AllInOneExecute.Location = new System.Drawing.Point(997, 4);
            this.sb_AllInOneExecute.Name = "sb_AllInOneExecute";
            this.sb_AllInOneExecute.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_AllInOneExecute.Size = new System.Drawing.Size(124, 34);
            this.sb_AllInOneExecute.TabIndex = 7;
            this.sb_AllInOneExecute.Text = "EXECUTE";
            this.sb_AllInOneExecute.Click += new System.EventHandler(this.sb_AllInOneExecute_Click);
            // 
            // tp_Copy
            // 
            this.tp_Copy.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.tp_Copy.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Copy.Controls.Add(this.gb_Copy);
            this.tp_Copy.Name = "tp_Copy";
            this.tp_Copy.Size = new System.Drawing.Size(1131, 555);
            this.tp_Copy.Text = "Copy Data";
            // 
            // gb_Copy
            // 
            this.gb_Copy.Controls.Add(this.gc_TableList);
            this.gb_Copy.Controls.Add(this.pnl_Top);
            this.gb_Copy.Controls.Add(this.tlp_Step);
            this.gb_Copy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Copy.Location = new System.Drawing.Point(0, 0);
            this.gb_Copy.Name = "gb_Copy";
            this.gb_Copy.Size = new System.Drawing.Size(1131, 555);
            this.gb_Copy.TabIndex = 5;
            this.gb_Copy.TabStop = false;
            this.gb_Copy.Text = "Action";
            // 
            // gc_TableList
            // 
            this.gc_TableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TableList.Location = new System.Drawing.Point(3, 95);
            this.gc_TableList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_TableList.MainView = this.gv_TableList;
            this.gc_TableList.Name = "gc_TableList";
            this.gc_TableList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.r_ce_Check});
            this.gc_TableList.Size = new System.Drawing.Size(1125, 457);
            this.gc_TableList.TabIndex = 7;
            this.gc_TableList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TableList});
            // 
            // gv_TableList
            // 
            this.gv_TableList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_TableList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_TableList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_TableList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_TableList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_TableList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_TableList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_TableList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_TableList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_TableList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_TableList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_TableList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_TableList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_TableList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_TableList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_TableList.Appearance.Row.Options.UseForeColor = true;
            this.gv_TableList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_TableList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_TableList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_TableList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_TableList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Check,
            this.gc_TableName,
            this.gc_TableSize});
            this.gv_TableList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_TableList.GridControl = this.gc_TableList;
            this.gv_TableList.Name = "gv_TableList";
            this.gv_TableList.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_TableList.OptionsView.ShowGroupPanel = false;
            this.gv_TableList.OptionsView.ShowIndicator = false;
            this.gv_TableList.RowHeight = 25;
            // 
            // gc_Check
            // 
            this.gc_Check.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Check.AppearanceCell.Options.UseFont = true;
            this.gc_Check.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Check.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Check.AppearanceHeader.Options.UseFont = true;
            this.gc_Check.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Check.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Check.Caption = "선택";
            this.gc_Check.ColumnEdit = this.r_ce_Check;
            this.gc_Check.FieldName = "check";
            this.gc_Check.Name = "gc_Check";
            this.gc_Check.OptionsFilter.AllowAutoFilter = false;
            this.gc_Check.OptionsFilter.AllowFilter = false;
            this.gc_Check.Visible = true;
            this.gc_Check.VisibleIndex = 0;
            this.gc_Check.Width = 113;
            // 
            // r_ce_Check
            // 
            this.r_ce_Check.AutoHeight = false;
            this.r_ce_Check.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.r_ce_Check.Name = "r_ce_Check";
            this.r_ce_Check.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.r_ce_Check.ValueChecked = "Y";
            this.r_ce_Check.ValueUnchecked = "N";
            this.r_ce_Check.CheckedChanged += new System.EventHandler(this.r_ce_Check_CheckedChanged);
            // 
            // gc_TableName
            // 
            this.gc_TableName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_TableName.AppearanceCell.Options.UseFont = true;
            this.gc_TableName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_TableName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_TableName.AppearanceHeader.Options.UseFont = true;
            this.gc_TableName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_TableName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TableName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TableName.Caption = "테이블명";
            this.gc_TableName.FieldName = "table_name";
            this.gc_TableName.Name = "gc_TableName";
            this.gc_TableName.OptionsColumn.AllowEdit = false;
            this.gc_TableName.OptionsColumn.AllowFocus = false;
            this.gc_TableName.OptionsFilter.AllowAutoFilter = false;
            this.gc_TableName.OptionsFilter.AllowFilter = false;
            this.gc_TableName.Visible = true;
            this.gc_TableName.VisibleIndex = 1;
            this.gc_TableName.Width = 709;
            // 
            // gc_TableSize
            // 
            this.gc_TableSize.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_TableSize.AppearanceCell.Options.UseFont = true;
            this.gc_TableSize.AppearanceCell.Options.UseTextOptions = true;
            this.gc_TableSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gc_TableSize.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_TableSize.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_TableSize.AppearanceHeader.Options.UseFont = true;
            this.gc_TableSize.AppearanceHeader.Options.UseForeColor = true;
            this.gc_TableSize.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TableSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TableSize.Caption = "테이블 크기 (KB)";
            this.gc_TableSize.FieldName = "table_size";
            this.gc_TableSize.Name = "gc_TableSize";
            this.gc_TableSize.OptionsColumn.AllowEdit = false;
            this.gc_TableSize.OptionsColumn.AllowFocus = false;
            this.gc_TableSize.OptionsFilter.AllowAutoFilter = false;
            this.gc_TableSize.OptionsFilter.AllowFilter = false;
            this.gc_TableSize.Visible = true;
            this.gc_TableSize.VisibleIndex = 2;
            this.gc_TableSize.Width = 201;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.White;
            this.pnl_Top.Controls.Add(this.labelControl5);
            this.pnl_Top.Controls.Add(this.nud_MaxThread);
            this.pnl_Top.Controls.Add(this.sb_FindTable);
            this.pnl_Top.Controls.Add(this.te_TableName);
            this.pnl_Top.Controls.Add(this.sb_UncheckAll);
            this.pnl_Top.Controls.Add(this.sb_CheckAll);
            this.pnl_Top.Controls.Add(this.tlp_Step4_Checked_Count);
            this.pnl_Top.Controls.Add(this.sb_Execute);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(3, 52);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1125, 43);
            this.pnl_Top.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(634, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 32);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Thread";
            // 
            // nud_MaxThread
            // 
            this.nud_MaxThread.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.nud_MaxThread.Location = new System.Drawing.Point(703, 5);
            this.nud_MaxThread.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_MaxThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MaxThread.Name = "nud_MaxThread";
            this.nud_MaxThread.Size = new System.Drawing.Size(55, 32);
            this.nud_MaxThread.TabIndex = 16;
            this.nud_MaxThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_MaxThread.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // sb_FindTable
            // 
            this.sb_FindTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sb_FindTable.ImageOptions.Image")));
            this.sb_FindTable.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_FindTable.Location = new System.Drawing.Point(382, 5);
            this.sb_FindTable.Name = "sb_FindTable";
            this.sb_FindTable.Size = new System.Drawing.Size(32, 32);
            this.sb_FindTable.TabIndex = 15;
            this.sb_FindTable.Click += new System.EventHandler(this.sb_FindTable_Click);
            // 
            // te_TableName
            // 
            this.te_TableName.Location = new System.Drawing.Point(182, 5);
            this.te_TableName.Name = "te_TableName";
            this.te_TableName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_TableName.Properties.Appearance.Options.UseFont = true;
            this.te_TableName.Size = new System.Drawing.Size(201, 32);
            this.te_TableName.TabIndex = 14;
            this.te_TableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.te_TableName_KeyPress);
            // 
            // sb_UncheckAll
            // 
            this.sb_UncheckAll.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_UncheckAll.Appearance.Options.UseFont = true;
            this.sb_UncheckAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_UncheckAll.Location = new System.Drawing.Point(89, 4);
            this.sb_UncheckAll.Name = "sb_UncheckAll";
            this.sb_UncheckAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_UncheckAll.Size = new System.Drawing.Size(83, 34);
            this.sb_UncheckAll.TabIndex = 13;
            this.sb_UncheckAll.Text = "전체해제";
            this.sb_UncheckAll.Click += new System.EventHandler(this.sb_UncheckAll_Click);
            // 
            // sb_CheckAll
            // 
            this.sb_CheckAll.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_CheckAll.Appearance.Options.UseFont = true;
            this.sb_CheckAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_CheckAll.Location = new System.Drawing.Point(3, 4);
            this.sb_CheckAll.Name = "sb_CheckAll";
            this.sb_CheckAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_CheckAll.Size = new System.Drawing.Size(83, 34);
            this.sb_CheckAll.TabIndex = 12;
            this.sb_CheckAll.Text = "전체선택";
            this.sb_CheckAll.Click += new System.EventHandler(this.sb_CheckAll_Click);
            // 
            // tlp_Step4_Checked_Count
            // 
            this.tlp_Step4_Checked_Count.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Step4_Checked_Count.ColumnCount = 2;
            this.tlp_Step4_Checked_Count.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Step4_Checked_Count.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Step4_Checked_Count.Controls.Add(this.labelControl6, 0, 0);
            this.tlp_Step4_Checked_Count.Controls.Add(this.lc_Checked_Count, 1, 0);
            this.tlp_Step4_Checked_Count.Location = new System.Drawing.Point(764, 4);
            this.tlp_Step4_Checked_Count.Name = "tlp_Step4_Checked_Count";
            this.tlp_Step4_Checked_Count.RowCount = 1;
            this.tlp_Step4_Checked_Count.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Step4_Checked_Count.Size = new System.Drawing.Size(230, 34);
            this.tlp_Step4_Checked_Count.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(1, 1);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 32);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "선택 테이블 수";
            // 
            // lc_Checked_Count
            // 
            this.lc_Checked_Count.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_Checked_Count.Appearance.Options.UseFont = true;
            this.lc_Checked_Count.Appearance.Options.UseTextOptions = true;
            this.lc_Checked_Count.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_Checked_Count.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Checked_Count.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lc_Checked_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Checked_Count.IndentBetweenImageAndText = 7;
            this.lc_Checked_Count.Location = new System.Drawing.Point(118, 4);
            this.lc_Checked_Count.Name = "lc_Checked_Count";
            this.lc_Checked_Count.Size = new System.Drawing.Size(108, 26);
            this.lc_Checked_Count.TabIndex = 10;
            this.lc_Checked_Count.Text = "000 / 000";
            // 
            // sb_Execute
            // 
            this.sb_Execute.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Execute.Appearance.Options.UseFont = true;
            this.sb_Execute.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Execute.Location = new System.Drawing.Point(997, 4);
            this.sb_Execute.Name = "sb_Execute";
            this.sb_Execute.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Execute.Size = new System.Drawing.Size(124, 34);
            this.sb_Execute.TabIndex = 7;
            this.sb_Execute.Text = "EXECUTE";
            this.sb_Execute.Click += new System.EventHandler(this.sb_Execute_Click);
            // 
            // tlp_Step
            // 
            this.tlp_Step.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Step.ColumnCount = 2;
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.39772F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.60228F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Step.Controls.Add(this.lc_SrcDB, 0, 0);
            this.tlp_Step.Controls.Add(this.cb_SrcDB, 1, 0);
            this.tlp_Step.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Step.Location = new System.Drawing.Point(3, 18);
            this.tlp_Step.Name = "tlp_Step";
            this.tlp_Step.RowCount = 1;
            this.tlp_Step.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Step.Size = new System.Drawing.Size(1125, 34);
            this.tlp_Step.TabIndex = 0;
            // 
            // lc_SrcDB
            // 
            this.lc_SrcDB.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.lc_SrcDB.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_SrcDB.Appearance.Options.UseBackColor = true;
            this.lc_SrcDB.Appearance.Options.UseFont = true;
            this.lc_SrcDB.Appearance.Options.UseTextOptions = true;
            this.lc_SrcDB.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_SrcDB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_SrcDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_SrcDB.Location = new System.Drawing.Point(1, 1);
            this.lc_SrcDB.Margin = new System.Windows.Forms.Padding(0);
            this.lc_SrcDB.Name = "lc_SrcDB";
            this.lc_SrcDB.Size = new System.Drawing.Size(341, 32);
            this.lc_SrcDB.TabIndex = 2;
            this.lc_SrcDB.Text = "원본 DB";
            // 
            // cb_SrcDB
            // 
            this.cb_SrcDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SrcDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SrcDB.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_SrcDB.FormattingEnabled = true;
            this.cb_SrcDB.Location = new System.Drawing.Point(343, 1);
            this.cb_SrcDB.Margin = new System.Windows.Forms.Padding(0);
            this.cb_SrcDB.Name = "cb_SrcDB";
            this.cb_SrcDB.Size = new System.Drawing.Size(781, 33);
            this.cb_SrcDB.TabIndex = 3;
            this.cb_SrcDB.SelectedValueChanged += new System.EventHandler(this.cb_SrcDB_SelectedValueChanged);
            // 
            // tp_ModifyDatabase
            // 
            this.tp_ModifyDatabase.Controls.Add(this.groupBox2);
            this.tp_ModifyDatabase.Name = "tp_ModifyDatabase";
            this.tp_ModifyDatabase.Size = new System.Drawing.Size(1131, 555);
            this.tp_ModifyDatabase.Text = "Modify Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModifyLog);
            this.groupBox2.Controls.Add(this.pnl_ModifyTop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1131, 555);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // ModifyLog
            // 
            this.ModifyLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyLog.Location = new System.Drawing.Point(3, 170);
            this.ModifyLog.Margin = new System.Windows.Forms.Padding(0);
            this.ModifyLog.Name = "ModifyLog";
            this.ModifyLog.Size = new System.Drawing.Size(1125, 382);
            this.ModifyLog.TabIndex = 7;
            // 
            // pnl_ModifyTop
            // 
            this.pnl_ModifyTop.BackColor = System.Drawing.Color.White;
            this.pnl_ModifyTop.Controls.Add(this.tlp_ModifyTop);
            this.pnl_ModifyTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ModifyTop.Location = new System.Drawing.Point(3, 18);
            this.pnl_ModifyTop.Name = "pnl_ModifyTop";
            this.pnl_ModifyTop.Size = new System.Drawing.Size(1125, 152);
            this.pnl_ModifyTop.TabIndex = 6;
            // 
            // tlp_ModifyTop
            // 
            this.tlp_ModifyTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_ModifyTop.ColumnCount = 3;
            this.tlp_ModifyTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_ModifyTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ModifyTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlp_ModifyTop.Controls.Add(this.labelControl11, 0, 0);
            this.tlp_ModifyTop.Controls.Add(this.labelControl10, 0, 4);
            this.tlp_ModifyTop.Controls.Add(this.lb_LogDBPath, 1, 4);
            this.tlp_ModifyTop.Controls.Add(this.lb_DataDBPath, 1, 2);
            this.tlp_ModifyTop.Controls.Add(this.labelControl9, 0, 1);
            this.tlp_ModifyTop.Controls.Add(this.sb_ModifyExecute, 2, 1);
            this.tlp_ModifyTop.Controls.Add(this.lb_DataDBName, 1, 1);
            this.tlp_ModifyTop.Controls.Add(this.lb_LogDBName, 1, 3);
            this.tlp_ModifyTop.Controls.Add(this.labelControl7, 0, 2);
            this.tlp_ModifyTop.Controls.Add(this.labelControl8, 0, 3);
            this.tlp_ModifyTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ModifyTop.Location = new System.Drawing.Point(0, 0);
            this.tlp_ModifyTop.Name = "tlp_ModifyTop";
            this.tlp_ModifyTop.RowCount = 5;
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ModifyTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_ModifyTop.Size = new System.Drawing.Size(1125, 152);
            this.tlp_ModifyTop.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Orange;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tlp_ModifyTop.SetColumnSpan(this.labelControl11, 3);
            this.labelControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl11.Location = new System.Drawing.Point(1, 1);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(1123, 30);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "※※ 현재 접속중인 DB를 백업 DB로 전환합니다. ( 기존 DB명#yyyyMMddHHmmss ) ※※";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl10.Location = new System.Drawing.Point(1, 122);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(200, 29);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "로그 DB 물리 경로";
            // 
            // lb_LogDBPath
            // 
            this.lb_LogDBPath.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LogDBPath.Appearance.Options.UseFont = true;
            this.lb_LogDBPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lb_LogDBPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LogDBPath.Location = new System.Drawing.Point(205, 125);
            this.lb_LogDBPath.Name = "lb_LogDBPath";
            this.lb_LogDBPath.Size = new System.Drawing.Size(793, 23);
            this.lb_LogDBPath.TabIndex = 15;
            this.lb_LogDBPath.Text = "Log DB Path";
            // 
            // lb_DataDBPath
            // 
            this.lb_DataDBPath.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataDBPath.Appearance.Options.UseFont = true;
            this.lb_DataDBPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lb_DataDBPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DataDBPath.Location = new System.Drawing.Point(205, 65);
            this.lb_DataDBPath.Name = "lb_DataDBPath";
            this.lb_DataDBPath.Size = new System.Drawing.Size(793, 23);
            this.lb_DataDBPath.TabIndex = 14;
            this.lb_DataDBPath.Text = "Data DB Path";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl9.Location = new System.Drawing.Point(1, 32);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(200, 29);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "데이터 DB 논리 파일명";
            // 
            // sb_ModifyExecute
            // 
            this.sb_ModifyExecute.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_ModifyExecute.Appearance.Options.UseFont = true;
            this.sb_ModifyExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sb_ModifyExecute.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_ModifyExecute.Location = new System.Drawing.Point(1002, 32);
            this.sb_ModifyExecute.Margin = new System.Windows.Forms.Padding(0);
            this.sb_ModifyExecute.Name = "sb_ModifyExecute";
            this.tlp_ModifyTop.SetRowSpan(this.sb_ModifyExecute, 4);
            this.sb_ModifyExecute.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_ModifyExecute.Size = new System.Drawing.Size(122, 119);
            this.sb_ModifyExecute.TabIndex = 7;
            this.sb_ModifyExecute.Text = "EXECUTE";
            this.sb_ModifyExecute.Click += new System.EventHandler(this.sb_ModifyExecute_Click);
            // 
            // lb_DataDBName
            // 
            this.lb_DataDBName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataDBName.Appearance.Options.UseFont = true;
            this.lb_DataDBName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lb_DataDBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DataDBName.Location = new System.Drawing.Point(205, 35);
            this.lb_DataDBName.Name = "lb_DataDBName";
            this.lb_DataDBName.Size = new System.Drawing.Size(793, 23);
            this.lb_DataDBName.TabIndex = 8;
            this.lb_DataDBName.Text = "Data DB Name";
            // 
            // lb_LogDBName
            // 
            this.lb_LogDBName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LogDBName.Appearance.Options.UseFont = true;
            this.lb_LogDBName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lb_LogDBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LogDBName.Location = new System.Drawing.Point(205, 95);
            this.lb_LogDBName.Name = "lb_LogDBName";
            this.lb_LogDBName.Size = new System.Drawing.Size(793, 23);
            this.lb_LogDBName.TabIndex = 9;
            this.lb_LogDBName.Text = "Log DB Name";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(1, 62);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(200, 29);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "데이터 DB 물리 경로";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(1, 92);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(200, 29);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "로그 DB 논리 파일명";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 677);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManager";
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_WorkType)).EndInit();
            this.tc_WorkType.ResumeLayout(false);
            this.tp_AllInOne.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tp_Copy.ResumeLayout(false);
            this.gb_Copy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_Check)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TableName.Properties)).EndInit();
            this.tlp_Step4_Checked_Count.ResumeLayout(false);
            this.tlp_Step4_Checked_Count.PerformLayout();
            this.tlp_Step.ResumeLayout(false);
            this.tlp_Step.PerformLayout();
            this.tp_ModifyDatabase.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnl_ModifyTop.ResumeLayout(false);
            this.tlp_ModifyTop.ResumeLayout(false);
            this.tlp_ModifyTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.StyleController styleController1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_DBName;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_DBAddress;
        private DevExpress.XtraEditors.CheckButton cbe_ViewPassword;
        private DevExpress.XtraEditors.SimpleButton sb_Connect;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl tc_WorkType;
        private DevExpress.XtraTab.XtraTabPage tp_Copy;
        private System.Windows.Forms.GroupBox gb_Copy;
        private DevExpress.XtraGrid.GridControl gc_TableList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TableList;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit r_ce_Check;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TableName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TableSize;
        private System.Windows.Forms.Panel pnl_Top;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nud_MaxThread;
        private DevExpress.XtraEditors.SimpleButton sb_FindTable;
        private DevExpress.XtraEditors.TextEdit te_TableName;
        private DevExpress.XtraEditors.SimpleButton sb_UncheckAll;
        private DevExpress.XtraEditors.SimpleButton sb_CheckAll;
        private System.Windows.Forms.TableLayoutPanel tlp_Step4_Checked_Count;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lc_Checked_Count;
        private DevExpress.XtraEditors.SimpleButton sb_Execute;
        private System.Windows.Forms.TableLayoutPanel tlp_Step;
        private DevExpress.XtraEditors.LabelControl lc_SrcDB;
        private System.Windows.Forms.ComboBox cb_SrcDB;
        private DevExpress.XtraTab.XtraTabPage tp_ModifyDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnl_ModifyTop;
        private DevExpress.XtraEditors.SimpleButton sb_ModifyExecute;
        private System.Windows.Forms.TableLayoutPanel tlp_ModifyTop;
        private DevExpress.XtraEditors.LabelControl lb_DataDBName;
        private DevExpress.XtraEditors.LabelControl lb_LogDBName;
        private DevExpress.XtraEditors.LabelControl lb_LogDBPath;
        private DevExpress.XtraEditors.LabelControl lb_DataDBPath;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Log ModifyLog;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraTab.XtraTabPage tp_AllInOne;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gc_Site;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Site;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SiteName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Path;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FilePath;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sb_Delete;
        private DevExpress.XtraEditors.SimpleButton sb_Add;
        private DevExpress.XtraEditors.SimpleButton sb_AllInOneExecute;
        private DevExpress.XtraGrid.GridControl gc_Database;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Database;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DbName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BackupFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SitePath;
        private DevExpress.XtraEditors.SimpleButton sb_Log;
    }
}

