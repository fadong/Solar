namespace Com.Fadong.ZClient.UMViewer {
    partial class UMViewer {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UMViewer));
            this.gBase = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuColLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCWidthAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCWidthAutoSizeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gBase)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBase
            // 
            this.gBase.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this.gBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBase.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gBase.Location = new System.Drawing.Point(0, 0);
            this.gBase.Name = "gBase";
            this.gBase.Rows.Count = 1;
            this.gBase.Rows.DefaultSize = 21;
            this.gBase.Size = new System.Drawing.Size(864, 520);
            this.gBase.StyleInfo = resources.GetString("gBase.StyleInfo");
            this.gBase.TabIndex = 0;
            this.gBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gBase_MouseClick);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuCWidthAutoSize,
            this.cmnuCWidthAutoSizeAll,
            this.toolStripSeparator2,
            this.cmnuSearch,
            this.toolStripSeparator1,
            this.cmnuColLayout});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(199, 104);
            // 
            // cmnuSearch
            // 
            this.cmnuSearch.Name = "cmnuSearch";
            this.cmnuSearch.Size = new System.Drawing.Size(198, 22);
            this.cmnuSearch.Text = "Search...";
            this.cmnuSearch.Click += new System.EventHandler(this.cmnuSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // cmnuColLayout
            // 
            this.cmnuColLayout.Name = "cmnuColLayout";
            this.cmnuColLayout.Size = new System.Drawing.Size(198, 22);
            this.cmnuColLayout.Text = "컬럼 Layout...";
            this.cmnuColLayout.Click += new System.EventHandler(this.cmnuColLayout_Click);
            // 
            // cmnuCWidthAutoSize
            // 
            this.cmnuCWidthAutoSize.Enabled = false;
            this.cmnuCWidthAutoSize.Name = "cmnuCWidthAutoSize";
            this.cmnuCWidthAutoSize.Size = new System.Drawing.Size(198, 22);
            this.cmnuCWidthAutoSize.Text = "선택 컬럼 자동 폭 설정";
            // 
            // cmnuCWidthAutoSizeAll
            // 
            this.cmnuCWidthAutoSizeAll.Name = "cmnuCWidthAutoSizeAll";
            this.cmnuCWidthAutoSizeAll.Size = new System.Drawing.Size(198, 22);
            this.cmnuCWidthAutoSizeAll.Text = "전체 컬럼 자동 폭 설정";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // UMViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBase);
            this.Name = "UMViewer";
            this.Size = new System.Drawing.Size(864, 520);
            ((System.ComponentModel.ISupportInitialize)(this.gBase)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid gBase;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem cmnuSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmnuColLayout;
        private System.Windows.Forms.ToolStripMenuItem cmnuCWidthAutoSize;
        private System.Windows.Forms.ToolStripMenuItem cmnuCWidthAutoSizeAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
