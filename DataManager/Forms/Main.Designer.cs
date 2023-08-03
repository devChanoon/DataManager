
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
            this.tlp_Step = new System.Windows.Forms.TableLayoutPanel();
            this.lc_SrcDB = new DevExpress.XtraEditors.LabelControl();
            this.cb_SrcDB = new System.Windows.Forms.ComboBox();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gc_TableList = new DevExpress.XtraGrid.GridControl();
            this.gv_TableList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_ce_Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gc_TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TableSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.sb_FindTable = new DevExpress.XtraEditors.SimpleButton();
            this.te_TableName = new DevExpress.XtraEditors.TextEdit();
            this.sb_UncheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.sb_CheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_Step4_Checked_Count = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lc_Checked_Count = new DevExpress.XtraEditors.LabelControl();
            this.sb_Execute = new DevExpress.XtraEditors.SimpleButton();
            this.nud_MaxThread = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tlp_Step.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_Check)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_TableName.Properties)).BeginInit();
            this.tlp_Step4_Checked_Count.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThread)).BeginInit();
            this.SuspendLayout();
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
            this.tlp_Step.Location = new System.Drawing.Point(3, 17);
            this.tlp_Step.Name = "tlp_Step";
            this.tlp_Step.RowCount = 1;
            this.tlp_Step.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Step.Size = new System.Drawing.Size(916, 34);
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
            this.lc_SrcDB.Size = new System.Drawing.Size(277, 32);
            this.lc_SrcDB.TabIndex = 2;
            this.lc_SrcDB.Text = "원본 DB";
            // 
            // cb_SrcDB
            // 
            this.cb_SrcDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SrcDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SrcDB.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_SrcDB.FormattingEnabled = true;
            this.cb_SrcDB.Location = new System.Drawing.Point(279, 1);
            this.cb_SrcDB.Margin = new System.Windows.Forms.Padding(0);
            this.cb_SrcDB.Name = "cb_SrcDB";
            this.cb_SrcDB.Size = new System.Drawing.Size(636, 33);
            this.cb_SrcDB.TabIndex = 3;
            this.cb_SrcDB.SelectedValueChanged += new System.EventHandler(this.cb_SrcDB_SelectedValueChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Information";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Password.Location = new System.Drawing.Point(479, 49);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(193, 23);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.Text = "!1Tascorp";
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_DBName
            // 
            this.tb_DBName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_DBName.Location = new System.Drawing.Point(479, 20);
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(220, 23);
            this.tb_DBName.TabIndex = 1;
            this.tb_DBName.Text = "RTEGMS_NATUREFARM";
            this.tb_DBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ID.Location = new System.Drawing.Point(110, 49);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(238, 23);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.Text = "sa";
            this.tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_DBAddress
            // 
            this.tb_DBAddress.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_DBAddress.Location = new System.Drawing.Point(110, 20);
            this.tb_DBAddress.Name = "tb_DBAddress";
            this.tb_DBAddress.Size = new System.Drawing.Size(238, 23);
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
            this.cbe_ViewPassword.Location = new System.Drawing.Point(671, 49);
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
            this.sb_Connect.Location = new System.Drawing.Point(770, 20);
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
            this.labelControl3.Location = new System.Drawing.Point(411, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(411, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "DB Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DB Address";
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Controls.Add(this.groupBox1, 0, 0);
            this.tlp_Main.Controls.Add(this.groupBox3, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(928, 761);
            this.tlp_Main.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gc_TableList);
            this.groupBox3.Controls.Add(this.pnl_Top);
            this.groupBox3.Controls.Add(this.tlp_Step);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 665);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // gc_TableList
            // 
            this.gc_TableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TableList.Location = new System.Drawing.Point(3, 94);
            this.gc_TableList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_TableList.MainView = this.gv_TableList;
            this.gc_TableList.Name = "gc_TableList";
            this.gc_TableList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.r_ce_Check});
            this.gc_TableList.Size = new System.Drawing.Size(916, 568);
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
            this.pnl_Top.Location = new System.Drawing.Point(3, 51);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(916, 43);
            this.pnl_Top.TabIndex = 6;
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
            this.tlp_Step4_Checked_Count.Location = new System.Drawing.Point(554, 4);
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
            this.sb_Execute.Location = new System.Drawing.Point(787, 4);
            this.sb_Execute.Name = "sb_Execute";
            this.sb_Execute.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Execute.Size = new System.Drawing.Size(124, 34);
            this.sb_Execute.TabIndex = 7;
            this.sb_Execute.Text = "EXECUTE";
            this.sb_Execute.Click += new System.EventHandler(this.sb_Execute_Click);
            // 
            // nud_MaxThread
            // 
            this.nud_MaxThread.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.nud_MaxThread.Location = new System.Drawing.Point(493, 5);
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
            this.labelControl5.Location = new System.Drawing.Point(424, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 32);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Thread";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 761);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManager";
            this.tlp_Step.ResumeLayout(false);
            this.tlp_Step.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_Check)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_TableName.Properties)).EndInit();
            this.tlp_Step4_Checked_Count.ResumeLayout(false);
            this.tlp_Step4_Checked_Count.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Step;
        private DevExpress.XtraEditors.StyleController styleController1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private DevExpress.XtraGrid.GridControl gc_TableList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TableList;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit r_ce_Check;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TableName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TableSize;
        private System.Windows.Forms.Panel pnl_Top;
        private DevExpress.XtraEditors.SimpleButton sb_UncheckAll;
        private DevExpress.XtraEditors.SimpleButton sb_CheckAll;
        private System.Windows.Forms.TableLayoutPanel tlp_Step4_Checked_Count;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lc_Checked_Count;
        private DevExpress.XtraEditors.SimpleButton sb_Execute;
        private DevExpress.XtraEditors.LabelControl lc_SrcDB;
        private System.Windows.Forms.ComboBox cb_SrcDB;
        private DevExpress.XtraEditors.SimpleButton sb_FindTable;
        private DevExpress.XtraEditors.TextEdit te_TableName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nud_MaxThread;
    }
}

