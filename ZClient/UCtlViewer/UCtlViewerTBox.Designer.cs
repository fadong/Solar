namespace ZClient.UCtlViewer {
    partial class UCtlViewerTBox {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent() {
            this.tbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbox
            // 
            this.tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox.Location = new System.Drawing.Point(0, 25);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(742, 193);
            this.tbox.TabIndex = 1;
            this.tbox.Text = "";
            // 
            // UCtlViewerTBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbox);
            this.Name = "UCtlViewerTBox";
            this.Size = new System.Drawing.Size(742, 218);
            this.Controls.SetChildIndex(this.tbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbox;
    }
}
