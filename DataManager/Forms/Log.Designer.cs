namespace DataManager
{
    partial class Log
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
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Log.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lb_Log.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.HorizontalScrollbar = true;
            this.lb_Log.ItemHeight = 17;
            this.lb_Log.Location = new System.Drawing.Point(0, 0);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(727, 150);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_Log_DrawItem);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Log);
            this.Name = "Log";
            this.Size = new System.Drawing.Size(727, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Log;
    }
}
