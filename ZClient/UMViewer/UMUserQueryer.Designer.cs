namespace Com.Fadong.ZClient.UMViewer {
    partial class UMUserQueryer {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.umViewer1 = new Com.Fadong.ZClient.UMViewer.UMViewer();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Controls.Add(this.umViewer1);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "52.9661016949153:True:True;44.4915254237288:False:False;\t99.1150442477876:False:F" +
    "alse;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 25);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1Sizer1.Size = new System.Drawing.Size(678, 472);
            this.c1Sizer1.TabIndex = 1;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // umViewer1
            // 
            this.umViewer1.Location = new System.Drawing.Point(3, 258);
            this.umViewer1.Name = "umViewer1";
            this.umViewer1.Size = new System.Drawing.Size(672, 210);
            this.umViewer1.TabIndex = 0;
            // 
            // UMUserQueryer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "UMUserQueryer";
            this.Size = new System.Drawing.Size(678, 497);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private UMViewer umViewer1;
    }
}
