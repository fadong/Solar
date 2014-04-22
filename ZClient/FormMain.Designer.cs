namespace Com.Fadong.ZClient {
    partial class FormMain {
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tBtn_FormalView = new System.Windows.Forms.ToolStripButton();
            this.tBtn_WideView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tStripTxt_ConnTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripTxt_ElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.c1Sizer2 = new C1.Win.C1Sizer.C1Sizer();
            this.docTabSubInfo = new C1.Win.C1Command.C1DockingTab();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.숨기기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.별도창으로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.docTabMain = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.docTabLeft = new C1.Win.C1Command.C1DockingTab();
            this.docPage_Book = new C1.Win.C1Command.C1DockingTabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.docPage_Bookmark = new C1.Win.C1Command.C1DockingTabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mnuMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabSubInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabMain)).BeginInit();
            this.docTabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabLeft)).BeginInit();
            this.docTabLeft.SuspendLayout();
            this.docPage_Book.SuspendLayout();
            this.docPage_Bookmark.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1205, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtn_FormalView,
            this.tBtn_WideView,
            this.toolStripSeparator3});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1205, 36);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tBtn_FormalView
            // 
            this.tBtn_FormalView.Image = ((System.Drawing.Image)(resources.GetObject("tBtn_FormalView.Image")));
            this.tBtn_FormalView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_FormalView.Name = "tBtn_FormalView";
            this.tBtn_FormalView.Size = new System.Drawing.Size(33, 33);
            this.tBtn_FormalView.Text = "일반";
            this.tBtn_FormalView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tBtn_FormalView.Click += new System.EventHandler(this.tBtn_FormalView_Click);
            // 
            // tBtn_WideView
            // 
            this.tBtn_WideView.Image = ((System.Drawing.Image)(resources.GetObject("tBtn_WideView.Image")));
            this.tBtn_WideView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_WideView.Name = "tBtn_WideView";
            this.tBtn_WideView.Size = new System.Drawing.Size(35, 33);
            this.tBtn_WideView.Text = "Data";
            this.tBtn_WideView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // statusMain
            // 
            this.statusMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.statusMain.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripTxt_ConnTime,
            this.tStripTxt_ElapsedTime,
            this.toolStripStatusLabel1});
            this.statusMain.Location = new System.Drawing.Point(0, 654);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1205, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // tStripTxt_ConnTime
            // 
            this.tStripTxt_ConnTime.BackColor = System.Drawing.Color.Indigo;
            this.tStripTxt_ConnTime.ForeColor = System.Drawing.Color.White;
            this.tStripTxt_ConnTime.Name = "tStripTxt_ConnTime";
            this.tStripTxt_ConnTime.Size = new System.Drawing.Size(57, 17);
            this.tStripTxt_ConnTime.Text = "접속시점 :";
            // 
            // tStripTxt_ElapsedTime
            // 
            this.tStripTxt_ElapsedTime.BackColor = System.Drawing.Color.Indigo;
            this.tStripTxt_ElapsedTime.ForeColor = System.Drawing.Color.White;
            this.tStripTxt_ElapsedTime.Name = "tStripTxt_ElapsedTime";
            this.tStripTxt_ElapsedTime.Size = new System.Drawing.Size(57, 17);
            this.tStripTxt_ElapsedTime.Text = "경과시간 :";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Indigo;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "사용자 ID :";
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Controls.Add(this.c1Sizer2);
            this.c1Sizer1.Controls.Add(this.docTabMain);
            this.c1Sizer1.Controls.Add(this.docTabLeft);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "55.8922558922559:True:False;42.0875420875421:False:True;\t24.896265560166:True:Tru" +
    "e;74.1078838174274:True:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1205, 594);
            this.c1Sizer1.TabIndex = 5;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.Controls.Add(this.docTabSubInfo);
            this.c1Sizer2.Controls.Add(this.toolStrip1);
            this.c1Sizer2.GridDefinition = "9.6:False:True;88.8:False:False;\t100:False:False;";
            this.c1Sizer2.Location = new System.Drawing.Point(308, 340);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Padding = new System.Windows.Forms.Padding(0);
            this.c1Sizer2.Size = new System.Drawing.Size(893, 250);
            this.c1Sizer2.TabIndex = 11;
            this.c1Sizer2.Text = "c1Sizer2";
            // 
            // docTabSubInfo
            // 
            this.docTabSubInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.docTabSubInfo.CanMoveTabs = true;
            this.docTabSubInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docTabSubInfo.Location = new System.Drawing.Point(0, 25);
            this.docTabSubInfo.Name = "docTabSubInfo";
            this.docTabSubInfo.SelectedTabBold = true;
            this.docTabSubInfo.ShowTabList = true;
            this.docTabSubInfo.Size = new System.Drawing.Size(893, 225);
            this.docTabSubInfo.TabIndex = 8;
            this.docTabSubInfo.TabsSpacing = 3;
            this.docTabSubInfo.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
            this.docTabSubInfo.VisualStyle = C1.Win.C1Command.VisualStyle.System;
            this.docTabSubInfo.VisualStyleBase = C1.Win.C1Command.VisualStyle.System;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton5,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.숨기기ToolStripMenuItem,
            this.별도창으로ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 숨기기ToolStripMenuItem
            // 
            this.숨기기ToolStripMenuItem.Name = "숨기기ToolStripMenuItem";
            this.숨기기ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.숨기기ToolStripMenuItem.Text = "숨기기";
            // 
            // 별도창으로ToolStripMenuItem
            // 
            this.별도창으로ToolStripMenuItem.Name = "별도창으로ToolStripMenuItem";
            this.별도창으로ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.별도창으로ToolStripMenuItem.Text = "별도창으로";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // docTabMain
            // 
            this.docTabMain.Controls.Add(this.c1DockingTabPage1);
            this.docTabMain.Location = new System.Drawing.Point(308, 4);
            this.docTabMain.Name = "docTabMain";
            this.docTabMain.Padding = new System.Drawing.Point(3, 2);
            this.docTabMain.SelectedTabBold = true;
            this.docTabMain.ShowCaption = true;
            this.docTabMain.ShowTabList = true;
            this.docTabMain.Size = new System.Drawing.Size(893, 332);
            this.docTabMain.TabIndex = 10;
            this.docTabMain.TabsSpacing = 3;
            this.docTabMain.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
            this.docTabMain.VisualStyle = C1.Win.C1Command.VisualStyle.System;
            this.docTabMain.VisualStyleBase = C1.Win.C1Command.VisualStyle.System;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionVisible = true;
            this.c1DockingTabPage1.Location = new System.Drawing.Point(2, 25);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(887, 303);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Start";
            // 
            // docTabLeft
            // 
            this.docTabLeft.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.docTabLeft.Controls.Add(this.docPage_Book);
            this.docTabLeft.Controls.Add(this.docPage_Bookmark);
            this.docTabLeft.Location = new System.Drawing.Point(4, 4);
            this.docTabLeft.Name = "docTabLeft";
            this.docTabLeft.Padding = new System.Drawing.Point(3, 2);
            this.docTabLeft.SelectedIndex = 2;
            this.docTabLeft.SelectedTabBold = true;
            this.docTabLeft.Size = new System.Drawing.Size(300, 586);
            this.docTabLeft.TabAreaSpacing = 3;
            this.docTabLeft.TabIndex = 9;
            this.docTabLeft.TabsSpacing = 3;
            this.docTabLeft.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
            this.docTabLeft.VisualStyle = C1.Win.C1Command.VisualStyle.System;
            this.docTabLeft.VisualStyleBase = C1.Win.C1Command.VisualStyle.System;
            // 
            // docPage_Book
            // 
            this.docPage_Book.Controls.Add(this.treeView1);
            this.docPage_Book.Location = new System.Drawing.Point(4, 4);
            this.docPage_Book.Name = "docPage_Book";
            this.docPage_Book.Size = new System.Drawing.Size(294, 556);
            this.docPage_Book.TabIndex = 0;
            this.docPage_Book.Text = "Book";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(294, 556);
            this.treeView1.TabIndex = 0;
            // 
            // docPage_Bookmark
            // 
            this.docPage_Bookmark.Controls.Add(this.listView1);
            this.docPage_Bookmark.Location = new System.Drawing.Point(4, 4);
            this.docPage_Bookmark.Name = "docPage_Bookmark";
            this.docPage_Bookmark.Size = new System.Drawing.Size(294, 556);
            this.docPage_Bookmark.TabIndex = 1;
            this.docPage_Bookmark.Text = "Bookmark";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 556);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 676);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            this.c1Sizer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabSubInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docTabMain)).EndInit();
            this.docTabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docTabLeft)).EndInit();
            this.docTabLeft.ResumeLayout(false);
            this.docPage_Book.ResumeLayout(false);
            this.docPage_Bookmark.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel tStripTxt_ConnTime;
        private System.Windows.Forms.ToolStripStatusLabel tStripTxt_ElapsedTime;
        private System.Windows.Forms.ToolStripButton tBtn_WideView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer2;
        private C1.Win.C1Command.C1DockingTab docTabSubInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 숨기기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 별도창으로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private C1.Win.C1Command.C1DockingTab docTabMain;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1Command.C1DockingTab docTabLeft;
        private C1.Win.C1Command.C1DockingTabPage docPage_Book;
        private System.Windows.Forms.TreeView treeView1;
        private C1.Win.C1Command.C1DockingTabPage docPage_Bookmark;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripButton tBtn_FormalView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
    }
}

