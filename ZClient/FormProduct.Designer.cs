namespace Com.Fadong.ZClient {
    partial class FormProduct {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.docTabTrade = new C1.Win.C1Command.C1DockingTab();
            this.tp_Trade = new C1.Win.C1Command.C1DockingTabPage();
            this.tp_Valuation = new C1.Win.C1Command.C1DockingTabPage();
            this.tp_HistPrice = new C1.Win.C1Command.C1DockingTabPage();
            this.tp_RTPrice = new C1.Win.C1Command.C1DockingTabPage();
            this.instPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuL1_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuL2_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuL2_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuL2_SaveAsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuL2_SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuL2_RecentProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuL2_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabTrade)).BeginInit();
            this.docTabTrade.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.toolStripSeparator4,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(39, 33);
            this.btnOpen.Text = "Open";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 33);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1120, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel1.Controls.Add(this.docTabTrade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.instPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 562);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // docTabTrade
            // 
            this.docTabTrade.Controls.Add(this.tp_Trade);
            this.docTabTrade.Controls.Add(this.tp_Valuation);
            this.docTabTrade.Controls.Add(this.tp_HistPrice);
            this.docTabTrade.Controls.Add(this.tp_RTPrice);
            this.docTabTrade.Controls.Add(this.c1DockingTabPage1);
            this.docTabTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docTabTrade.Location = new System.Drawing.Point(473, 3);
            this.docTabTrade.Name = "docTabTrade";
            this.docTabTrade.SelectedIndex = 4;
            this.docTabTrade.SelectedTabBold = true;
            this.docTabTrade.Size = new System.Drawing.Size(644, 556);
            this.docTabTrade.TabIndex = 0;
            this.docTabTrade.TabsSpacing = 3;
            this.docTabTrade.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
            this.docTabTrade.VisualStyle = C1.Win.C1Command.VisualStyle.System;
            this.docTabTrade.VisualStyleBase = C1.Win.C1Command.VisualStyle.System;
            // 
            // tp_Trade
            // 
            this.tp_Trade.Location = new System.Drawing.Point(2, 27);
            this.tp_Trade.Name = "tp_Trade";
            this.tp_Trade.Size = new System.Drawing.Size(638, 525);
            this.tp_Trade.TabIndex = 0;
            this.tp_Trade.Text = "Trade";
            // 
            // tp_Valuation
            // 
            this.tp_Valuation.Location = new System.Drawing.Point(2, 27);
            this.tp_Valuation.Name = "tp_Valuation";
            this.tp_Valuation.Size = new System.Drawing.Size(638, 525);
            this.tp_Valuation.TabIndex = 2;
            this.tp_Valuation.Text = "Valuation";
            // 
            // tp_HistPrice
            // 
            this.tp_HistPrice.Location = new System.Drawing.Point(2, 27);
            this.tp_HistPrice.Name = "tp_HistPrice";
            this.tp_HistPrice.Size = new System.Drawing.Size(638, 525);
            this.tp_HistPrice.TabIndex = 3;
            this.tp_HistPrice.Text = "HistPrice";
            // 
            // tp_RTPrice
            // 
            this.tp_RTPrice.Location = new System.Drawing.Point(2, 27);
            this.tp_RTPrice.Name = "tp_RTPrice";
            this.tp_RTPrice.Size = new System.Drawing.Size(638, 525);
            this.tp_RTPrice.TabIndex = 4;
            this.tp_RTPrice.Text = "RTPrice";
            // 
            // instPanel
            // 
            this.instPanel.AutoSize = true;
            this.instPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instPanel.Location = new System.Drawing.Point(3, 3);
            this.instPanel.Name = "instPanel";
            this.instPanel.Size = new System.Drawing.Size(464, 556);
            this.instPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuL1_File,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuL1_File
            // 
            this.mnuL1_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuL2_Open,
            this.toolStripSeparator1,
            this.mnuL2_Save,
            this.mnuL2_SaveAsNew,
            this.mnuL2_SaveAsFile,
            this.toolStripSeparator2,
            this.mnuL2_RecentProd,
            this.toolStripSeparator3,
            this.mnuL2_Close});
            this.mnuL1_File.Name = "mnuL1_File";
            this.mnuL1_File.Size = new System.Drawing.Size(36, 20);
            this.mnuL1_File.Text = "File";
            // 
            // mnuL2_Open
            // 
            this.mnuL2_Open.Name = "mnuL2_Open";
            this.mnuL2_Open.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_Open.Text = "열기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuL2_Save
            // 
            this.mnuL2_Save.Name = "mnuL2_Save";
            this.mnuL2_Save.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_Save.Text = "저장";
            // 
            // mnuL2_SaveAsNew
            // 
            this.mnuL2_SaveAsNew.Name = "mnuL2_SaveAsNew";
            this.mnuL2_SaveAsNew.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_SaveAsNew.Text = "신규저장";
            // 
            // mnuL2_SaveAsFile
            // 
            this.mnuL2_SaveAsFile.Name = "mnuL2_SaveAsFile";
            this.mnuL2_SaveAsFile.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_SaveAsFile.Text = "파일로 저장";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuL2_RecentProd
            // 
            this.mnuL2_RecentProd.Name = "mnuL2_RecentProd";
            this.mnuL2_RecentProd.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_RecentProd.Text = "최근 사용된 상품";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuL2_Close
            // 
            this.mnuL2_Close.Name = "mnuL2_Close";
            this.mnuL2_Close.Size = new System.Drawing.Size(159, 22);
            this.mnuL2_Close.Text = "종료";
            this.mnuL2_Close.Click += new System.EventHandler(this.mnuL2_Close_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(43, 20);
            this.mnuHelp.Text = "Help";
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Location = new System.Drawing.Point(2, 27);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(638, 525);
            this.c1DockingTabPage1.TabIndex = 5;
            this.c1DockingTabPage1.Text = "FA";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabTrade)).EndInit();
            this.docTabTrade.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1Command.C1DockingTab docTabTrade;
        private C1.Win.C1Command.C1DockingTabPage tp_Trade;
        private System.Windows.Forms.Panel instPanel;
        private C1.Win.C1Command.C1DockingTabPage tp_Valuation;
        private C1.Win.C1Command.C1DockingTabPage tp_HistPrice;
        private C1.Win.C1Command.C1DockingTabPage tp_RTPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuL1_File;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_Close;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_Save;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_SaveAsNew;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_RecentProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuL2_SaveAsFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSave;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
    }
}