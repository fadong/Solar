namespace Com.Fadong.ZClient.UCtlViewer {
    partial class UCtlViewerGrid {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCtlViewerGrid));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridG = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridG)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(141, 23);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Size = new System.Drawing.Size(240, 150);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // gridG
            // 
            this.gridG.ColumnInfo = "5,0,0,0,0,105,Columns:";
            this.gridG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridG.ExtendLastCol = true;
            this.gridG.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridG.Location = new System.Drawing.Point(0, 25);
            this.gridG.Name = "gridG";
            this.gridG.Rows.Count = 1;
            this.gridG.Rows.DefaultSize = 21;
            this.gridG.Size = new System.Drawing.Size(884, 214);
            this.gridG.StyleInfo = resources.GetString("gridG.StyleInfo");
            this.gridG.TabIndex = 1;
            this.gridG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridG_MouseClick);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuSearch});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // cmnuSearch
            // 
            this.cmnuSearch.Name = "cmnuSearch";
            this.cmnuSearch.Size = new System.Drawing.Size(152, 22);
            this.cmnuSearch.Text = "Search...";
            this.cmnuSearch.Click += new System.EventHandler(this.cmnuSearch_Click);
            // 
            // UCtlViewerGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridG);
            this.Name = "UCtlViewerGrid";
            this.Size = new System.Drawing.Size(884, 239);
            this.Controls.SetChildIndex(this.gridG, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridG)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridG;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem cmnuSearch;

    }
}
