namespace Com.Fadong.ZClient.UCtlProd {
    partial class UCtlProd_Stock {
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
            this.gInfo = new Com.Fadong.ZClient.UCtlComps.UCtlProdComp_generalInfo();
            this.SuspendLayout();
            // 
            // gInfo
            // 
            this.gInfo.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gInfo.Location = new System.Drawing.Point(4, 4);
            this.gInfo.Name = "gInfo";
            this.gInfo.Size = new System.Drawing.Size(652, 227);
            this.gInfo.TabIndex = 0;
            // 
            // UCtlProd_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gInfo);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "UCtlProd_Stock";
            this.Size = new System.Drawing.Size(658, 641);
            this.ResumeLayout(false);

        }

        #endregion

        private UCtlComps.UCtlProdComp_generalInfo gInfo;

    }
}
