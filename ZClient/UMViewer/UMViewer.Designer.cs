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
            this.cmnuCWidthAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCWidthAutoSizeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuColLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보관함등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자유셀선택변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.부분복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.셀선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.행선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다중행선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다중열선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.임의셀선택모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.속성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
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
            this.셀선택모드ToolStripMenuItem,
            this.toolStripSeparator9,
            this.cmnuSearch,
            this.toolStripSeparator1,
            this.cmnuColLayout,
            this.toolStripSeparator3,
            this.dataExportToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.toolStripSeparator7,
            this.보관함등록ToolStripMenuItem,
            this.toolStripSeparator12,
            this.속성ToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(199, 238);
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
            // cmnuSearch
            // 
            this.cmnuSearch.Name = "cmnuSearch";
            this.cmnuSearch.Size = new System.Drawing.Size(198, 22);
            this.cmnuSearch.Text = "Search ...";
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
            this.cmnuColLayout.Text = "컬럼 Layout ...";
            this.cmnuColLayout.Click += new System.EventHandler(this.cmnuColLayout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // dataExportToolStripMenuItem
            // 
            this.dataExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.toolStripSeparator4,
            this.pdfToolStripMenuItem,
            this.toolStripSeparator5,
            this.cSVToolStripMenuItem,
            this.textToolStripMenuItem,
            this.toolStripSeparator6,
            this.xMLToolStripMenuItem});
            this.dataExportToolStripMenuItem.Name = "dataExportToolStripMenuItem";
            this.dataExportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dataExportToolStripMenuItem.Text = "Data Export ...";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pdfToolStripMenuItem.Text = "PDF";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cSVToolStripMenuItem.Text = "CSV(쉼표 분리)";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.textToolStripMenuItem.Text = "Text(공백 분리)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(154, 6);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // 보관함등록ToolStripMenuItem
            // 
            this.보관함등록ToolStripMenuItem.Name = "보관함등록ToolStripMenuItem";
            this.보관함등록ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.보관함등록ToolStripMenuItem.Text = "보관함 등록";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(195, 6);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체ToolStripMenuItem,
            this.toolStripSeparator8,
            this.자유셀선택변환ToolStripMenuItem,
            this.부분복사ToolStripMenuItem});
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 전체ToolStripMenuItem
            // 
            this.전체ToolStripMenuItem.Name = "전체ToolStripMenuItem";
            this.전체ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.전체ToolStripMenuItem.Text = "전체 복사";
            // 
            // 자유셀선택변환ToolStripMenuItem
            // 
            this.자유셀선택변환ToolStripMenuItem.Name = "자유셀선택변환ToolStripMenuItem";
            this.자유셀선택변환ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.자유셀선택변환ToolStripMenuItem.Text = "자유 셀 선택 모드 변환";
            // 
            // 부분복사ToolStripMenuItem
            // 
            this.부분복사ToolStripMenuItem.Name = "부분복사ToolStripMenuItem";
            this.부분복사ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.부분복사ToolStripMenuItem.Text = "부분 복사";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(195, 6);
            // 
            // 셀선택모드ToolStripMenuItem
            // 
            this.셀선택모드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.행선택모드ToolStripMenuItem,
            this.열선택모드ToolStripMenuItem,
            this.toolStripSeparator10,
            this.다중행선택모드ToolStripMenuItem,
            this.다중열선택모드ToolStripMenuItem,
            this.toolStripSeparator11,
            this.임의셀선택모드ToolStripMenuItem});
            this.셀선택모드ToolStripMenuItem.Name = "셀선택모드ToolStripMenuItem";
            this.셀선택모드ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.셀선택모드ToolStripMenuItem.Text = "셀 선택 모드";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(195, 6);
            // 
            // 행선택모드ToolStripMenuItem
            // 
            this.행선택모드ToolStripMenuItem.Name = "행선택모드ToolStripMenuItem";
            this.행선택모드ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.행선택모드ToolStripMenuItem.Text = "단일 행 선택 모드";
            // 
            // 열선택모드ToolStripMenuItem
            // 
            this.열선택모드ToolStripMenuItem.Name = "열선택모드ToolStripMenuItem";
            this.열선택모드ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.열선택모드ToolStripMenuItem.Text = "단일 열 선택 모드";
            // 
            // 다중행선택모드ToolStripMenuItem
            // 
            this.다중행선택모드ToolStripMenuItem.Name = "다중행선택모드ToolStripMenuItem";
            this.다중행선택모드ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.다중행선택모드ToolStripMenuItem.Text = "다중 행 선택 모드";
            // 
            // 다중열선택모드ToolStripMenuItem
            // 
            this.다중열선택모드ToolStripMenuItem.Name = "다중열선택모드ToolStripMenuItem";
            this.다중열선택모드ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.다중열선택모드ToolStripMenuItem.Text = "다중 열 선택 모드";
            // 
            // 임의셀선택모드ToolStripMenuItem
            // 
            this.임의셀선택모드ToolStripMenuItem.Name = "임의셀선택모드ToolStripMenuItem";
            this.임의셀선택모드ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.임의셀선택모드ToolStripMenuItem.Text = "임의 셀 선택 모드";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(167, 6);
            // 
            // 속성ToolStripMenuItem
            // 
            this.속성ToolStripMenuItem.Name = "속성ToolStripMenuItem";
            this.속성ToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.속성ToolStripMenuItem.Text = "정보";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(195, 6);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem dataExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 보관함등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 셀선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 행선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem 다중행선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다중열선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem 임의셀선택모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 자유셀선택변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 부분복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem 속성ToolStripMenuItem;
    }
}
