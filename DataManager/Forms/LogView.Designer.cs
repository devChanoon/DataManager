namespace DataManager
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.gc_Log = new DevExpress.XtraGrid.GridControl();
            this.gv_Log = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Detail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gc_MasterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ServerName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Log
            // 
            this.gc_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Log.Location = new System.Drawing.Point(0, 0);
            this.gc_Log.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Log.MainView = this.gv_Log;
            this.gc_Log.Name = "gc_Log";
            this.gc_Log.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gc_Log.Size = new System.Drawing.Size(1160, 673);
            this.gc_Log.TabIndex = 8;
            this.gc_Log.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Log});
            // 
            // gv_Log
            // 
            this.gv_Log.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Log.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Log.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Log.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_Log.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Log.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_Log.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Log.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Log.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Log.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Log.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Log.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Log.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Log.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Log.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Log.Appearance.Row.Options.UseForeColor = true;
            this.gv_Log.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Log.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Log.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Log.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Log.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Type,
            this.gc_Time,
            this.gc_Result,
            this.gc_ErrorMessage,
            this.gc_Detail,
            this.gc_MasterId,
            this.gc_ServerName});
            this.gv_Log.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Log.GridControl = this.gc_Log;
            this.gv_Log.Name = "gv_Log";
            this.gv_Log.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Log.OptionsView.ShowGroupPanel = false;
            this.gv_Log.OptionsView.ShowIndicator = false;
            this.gv_Log.RowHeight = 25;
            this.gv_Log.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_Log_RowCellClick);
            // 
            // gc_Type
            // 
            this.gc_Type.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Type.AppearanceCell.Options.UseFont = true;
            this.gc_Type.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Type.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Type.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Type.AppearanceHeader.Options.UseFont = true;
            this.gc_Type.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Type.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Type.Caption = "구분";
            this.gc_Type.FieldName = "Type";
            this.gc_Type.Name = "gc_Type";
            this.gc_Type.OptionsColumn.AllowEdit = false;
            this.gc_Type.OptionsColumn.AllowFocus = false;
            this.gc_Type.OptionsColumn.ReadOnly = true;
            this.gc_Type.OptionsFilter.AllowAutoFilter = false;
            this.gc_Type.OptionsFilter.AllowFilter = false;
            this.gc_Type.Visible = true;
            this.gc_Type.VisibleIndex = 1;
            this.gc_Type.Width = 103;
            // 
            // gc_Time
            // 
            this.gc_Time.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Time.AppearanceCell.Options.UseFont = true;
            this.gc_Time.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Time.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Time.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Time.AppearanceHeader.Options.UseFont = true;
            this.gc_Time.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Time.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Time.Caption = "시간";
            this.gc_Time.FieldName = "Time";
            this.gc_Time.Name = "gc_Time";
            this.gc_Time.OptionsColumn.AllowEdit = false;
            this.gc_Time.OptionsColumn.AllowFocus = false;
            this.gc_Time.OptionsColumn.ReadOnly = true;
            this.gc_Time.OptionsFilter.AllowAutoFilter = false;
            this.gc_Time.OptionsFilter.AllowFilter = false;
            this.gc_Time.Visible = true;
            this.gc_Time.VisibleIndex = 2;
            this.gc_Time.Width = 189;
            // 
            // gc_Result
            // 
            this.gc_Result.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_Result.AppearanceCell.Options.UseFont = true;
            this.gc_Result.AppearanceCell.Options.UseTextOptions = true;
            this.gc_Result.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Result.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gc_Result.Visible = true;
            this.gc_Result.VisibleIndex = 3;
            this.gc_Result.Width = 109;
            // 
            // gc_ErrorMessage
            // 
            this.gc_ErrorMessage.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_ErrorMessage.AppearanceCell.Options.UseFont = true;
            this.gc_ErrorMessage.AppearanceCell.Options.UseTextOptions = true;
            this.gc_ErrorMessage.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gc_ErrorMessage.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gc_ErrorMessage.Visible = true;
            this.gc_ErrorMessage.VisibleIndex = 4;
            this.gc_ErrorMessage.Width = 517;
            // 
            // gc_Detail
            // 
            this.gc_Detail.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_Detail.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_Detail.AppearanceHeader.Options.UseFont = true;
            this.gc_Detail.AppearanceHeader.Options.UseForeColor = true;
            this.gc_Detail.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Detail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Detail.Caption = "자세히";
            this.gc_Detail.ColumnEdit = this.repositoryItemImageEdit1;
            this.gc_Detail.FieldName = "Detail";
            this.gc_Detail.Name = "gc_Detail";
            this.gc_Detail.OptionsColumn.AllowEdit = false;
            this.gc_Detail.OptionsColumn.AllowFocus = false;
            this.gc_Detail.OptionsColumn.ReadOnly = true;
            this.gc_Detail.OptionsFilter.AllowAutoFilter = false;
            this.gc_Detail.OptionsFilter.AllowFilter = false;
            this.gc_Detail.Visible = true;
            this.gc_Detail.VisibleIndex = 5;
            this.gc_Detail.Width = 58;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Images = this.imageList1;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemImageEdit1.ReadOnly = true;
            this.repositoryItemImageEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "detail.png");
            // 
            // gc_MasterId
            // 
            this.gc_MasterId.FieldName = "MasterId";
            this.gc_MasterId.Name = "gc_MasterId";
            this.gc_MasterId.OptionsColumn.AllowEdit = false;
            this.gc_MasterId.OptionsColumn.AllowFocus = false;
            this.gc_MasterId.OptionsColumn.ReadOnly = true;
            this.gc_MasterId.OptionsFilter.AllowAutoFilter = false;
            this.gc_MasterId.OptionsFilter.AllowFilter = false;
            // 
            // gc_ServerName
            // 
            this.gc_ServerName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_ServerName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gc_ServerName.AppearanceCell.Options.UseFont = true;
            this.gc_ServerName.AppearanceCell.Options.UseForeColor = true;
            this.gc_ServerName.AppearanceCell.Options.UseTextOptions = true;
            this.gc_ServerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ServerName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_ServerName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_ServerName.AppearanceHeader.Options.UseFont = true;
            this.gc_ServerName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_ServerName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ServerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ServerName.Caption = "서버";
            this.gc_ServerName.FieldName = "ServerName";
            this.gc_ServerName.Name = "gc_ServerName";
            this.gc_ServerName.OptionsColumn.AllowEdit = false;
            this.gc_ServerName.Visible = true;
            this.gc_ServerName.VisibleIndex = 0;
            this.gc_ServerName.Width = 182;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 673);
            this.Controls.Add(this.gc_Log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.gc_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Log;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Log;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Type;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Time;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Result;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Detail;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MasterId;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ServerName;
    }
}