namespace Patch
{
    partial class Patch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patch));
            this.lc_Title = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lc_Title
            // 
            this.lc_Title.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_Title.Appearance.Options.UseFont = true;
            this.lc_Title.Appearance.Options.UseTextOptions = true;
            this.lc_Title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_Title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lc_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lc_Title.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lc_Title.ImageOptions.Image")));
            this.lc_Title.IndentBetweenImageAndText = 15;
            this.lc_Title.Location = new System.Drawing.Point(0, 0);
            this.lc_Title.Name = "lc_Title";
            this.lc_Title.Size = new System.Drawing.Size(540, 147);
            this.lc_Title.TabIndex = 0;
            this.lc_Title.Text = "DataManager 버전 확인 중..";
            // 
            // Patch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 147);
            this.Controls.Add(this.lc_Title);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Patch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patch";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lc_Title;
    }
}

