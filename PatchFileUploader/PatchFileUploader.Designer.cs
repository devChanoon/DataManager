namespace PatchFileUploader
{
    partial class PatchFileUploader
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchFileUploader));
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.gc_File = new DevExpress.XtraGrid.GridControl();
            this.gv_File = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_FileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FileVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_IsCurrentYN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_UploadTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tb_Version = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gc_File)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_File)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SelectFile.Location = new System.Drawing.Point(426, 8);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(98, 23);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "파일 선택";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Upload.Location = new System.Drawing.Point(530, 8);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(98, 23);
            this.btn_Upload.TabIndex = 1;
            this.btn_Upload.Text = "업로드";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // gc_File
            // 
            this.gc_File.Location = new System.Drawing.Point(0, 41);
            this.gc_File.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_File.MainView = this.gv_File;
            this.gc_File.Name = "gc_File";
            this.gc_File.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_File.Size = new System.Drawing.Size(1001, 486);
            this.gc_File.TabIndex = 8;
            this.gc_File.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_File});
            // 
            // gv_File
            // 
            this.gv_File.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_File.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_File.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_File.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_File.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_File.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_File.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_File.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_File.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_File.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_File.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_File.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_File.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_File.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_File.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_File.Appearance.Row.Options.UseForeColor = true;
            this.gv_File.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_File.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_File.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_File.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_File.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_FileName,
            this.gc_FileVersion,
            this.gc_IsCurrentYN,
            this.gc_UploadTime});
            this.gv_File.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Expression = "[FileUseYN] = \'Y\'";
            formatConditionRuleExpression2.PredefinedName = "Green Fill";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gv_File.FormatRules.Add(gridFormatRule2);
            this.gv_File.GridControl = this.gc_File;
            this.gv_File.Name = "gv_File";
            this.gv_File.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_File.OptionsView.ShowGroupPanel = false;
            this.gv_File.OptionsView.ShowIndicator = false;
            this.gv_File.RowHeight = 25;
            this.gv_File.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_File_FocusedRowChanged);
            // 
            // gc_FileName
            // 
            this.gc_FileName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_FileName.AppearanceCell.Options.UseFont = true;
            this.gc_FileName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_FileName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_FileName.AppearanceHeader.Options.UseFont = true;
            this.gc_FileName.AppearanceHeader.Options.UseForeColor = true;
            this.gc_FileName.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_FileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FileName.Caption = "파일명";
            this.gc_FileName.FieldName = "FileName";
            this.gc_FileName.Name = "gc_FileName";
            this.gc_FileName.OptionsColumn.AllowEdit = false;
            this.gc_FileName.OptionsColumn.AllowFocus = false;
            this.gc_FileName.OptionsFilter.AllowAutoFilter = false;
            this.gc_FileName.OptionsFilter.AllowFilter = false;
            this.gc_FileName.Visible = true;
            this.gc_FileName.VisibleIndex = 0;
            this.gc_FileName.Width = 405;
            // 
            // gc_FileVersion
            // 
            this.gc_FileVersion.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_FileVersion.AppearanceCell.Options.UseFont = true;
            this.gc_FileVersion.AppearanceCell.Options.UseTextOptions = true;
            this.gc_FileVersion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FileVersion.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_FileVersion.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_FileVersion.AppearanceHeader.Options.UseFont = true;
            this.gc_FileVersion.AppearanceHeader.Options.UseForeColor = true;
            this.gc_FileVersion.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_FileVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FileVersion.Caption = "파일 버전";
            this.gc_FileVersion.FieldName = "FileVersion";
            this.gc_FileVersion.Name = "gc_FileVersion";
            this.gc_FileVersion.OptionsColumn.AllowEdit = false;
            this.gc_FileVersion.OptionsColumn.AllowFocus = false;
            this.gc_FileVersion.OptionsFilter.AllowAutoFilter = false;
            this.gc_FileVersion.OptionsFilter.AllowFilter = false;
            this.gc_FileVersion.Visible = true;
            this.gc_FileVersion.VisibleIndex = 1;
            this.gc_FileVersion.Width = 233;
            // 
            // gc_IsCurrentYN
            // 
            this.gc_IsCurrentYN.AppearanceCell.Options.UseTextOptions = true;
            this.gc_IsCurrentYN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_IsCurrentYN.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_IsCurrentYN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_IsCurrentYN.AppearanceHeader.Options.UseFont = true;
            this.gc_IsCurrentYN.AppearanceHeader.Options.UseForeColor = true;
            this.gc_IsCurrentYN.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_IsCurrentYN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_IsCurrentYN.Caption = "패치 대상";
            this.gc_IsCurrentYN.FieldName = "IsCurrentYN";
            this.gc_IsCurrentYN.Name = "gc_IsCurrentYN";
            this.gc_IsCurrentYN.OptionsColumn.AllowEdit = false;
            this.gc_IsCurrentYN.OptionsColumn.AllowFocus = false;
            this.gc_IsCurrentYN.Visible = true;
            this.gc_IsCurrentYN.VisibleIndex = 2;
            this.gc_IsCurrentYN.Width = 155;
            // 
            // gc_UploadTime
            // 
            this.gc_UploadTime.AppearanceCell.Options.UseTextOptions = true;
            this.gc_UploadTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_UploadTime.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_UploadTime.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_UploadTime.AppearanceHeader.Options.UseFont = true;
            this.gc_UploadTime.AppearanceHeader.Options.UseForeColor = true;
            this.gc_UploadTime.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_UploadTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_UploadTime.Caption = "업로드 일시";
            this.gc_UploadTime.FieldName = "UploadTime";
            this.gc_UploadTime.Name = "gc_UploadTime";
            this.gc_UploadTime.OptionsColumn.AllowEdit = false;
            this.gc_UploadTime.OptionsColumn.AllowFocus = false;
            this.gc_UploadTime.Visible = true;
            this.gc_UploadTime.VisibleIndex = 3;
            this.gc_UploadTime.Width = 206;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 15);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Version";
            // 
            // tb_Version
            // 
            this.tb_Version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Version.Location = new System.Drawing.Point(58, 9);
            this.tb_Version.Name = "tb_Version";
            this.tb_Version.Size = new System.Drawing.Size(130, 23);
            this.tb_Version.TabIndex = 10;
            this.tb_Version.Text = "1.0.0";
            this.tb_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Change.Location = new System.Drawing.Point(787, 9);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(98, 23);
            this.btn_Change.TabIndex = 11;
            this.btn_Change.Text = "패치 대상 변경";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // tb_FileName
            // 
            this.tb_FileName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_FileName.Location = new System.Drawing.Point(225, 9);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(195, 23);
            this.tb_FileName.TabIndex = 12;
            this.tb_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(201, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 15);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "File";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Delete.Location = new System.Drawing.Point(891, 9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Download.Location = new System.Drawing.Point(634, 8);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(98, 23);
            this.btn_Download.TabIndex = 15;
            this.btn_Download.Text = "다운로드";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // PatchFileUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.tb_Version);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gc_File);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_SelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatchFileUploader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManager 파일 관리자";
            ((System.ComponentModel.ISupportInitialize)(this.gc_File)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_File)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Button btn_Upload;
        private DevExpress.XtraGrid.GridControl gc_File;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_File;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FileName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FileVersion;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsCurrentYN;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox tb_Version;
        private System.Windows.Forms.Button btn_Change;
        private DevExpress.XtraGrid.Columns.GridColumn gc_UploadTime;
        private System.Windows.Forms.TextBox tb_FileName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Download;
    }
}

