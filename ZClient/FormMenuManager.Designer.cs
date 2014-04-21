namespace Com.Fadong.ZClient {
    partial class FormMenuManager {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tv = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLoadType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuText = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.chkIsSeparator = new System.Windows.Forms.CheckBox();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddMenu추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlMenu추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.구분선추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTargetName = new System.Windows.Forms.TextBox();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(906, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.64957F));
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44607F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 547);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.c1FlexGrid1.Location = new System.Drawing.Point(250, 285);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 21;
            this.c1FlexGrid1.Size = new System.Drawing.Size(653, 259);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 2;
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(3, 3);
            this.tv.Name = "tv";
            this.tableLayoutPanel1.SetRowSpan(this.tv, 2);
            this.tv.Size = new System.Drawing.Size(241, 541);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            this.tv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tv_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkIsSeparator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(254, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtParentName);
            this.groupBox2.Controls.Add(this.txtTargetName);
            this.groupBox2.Controls.Add(this.txtAssemblyName);
            this.groupBox2.Controls.Add(this.cmbLoadType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMenuText);
            this.groupBox2.Controls.Add(this.txtMenuName);
            this.groupBox2.Location = new System.Drawing.Point(9, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmbLoadType
            // 
            this.cmbLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadType.FormattingEnabled = true;
            this.cmbLoadType.Location = new System.Drawing.Point(115, 84);
            this.cmbLoadType.Name = "cmbLoadType";
            this.cmbLoadType.Size = new System.Drawing.Size(214, 21);
            this.cmbLoadType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu Text :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Name :";
            // 
            // txtMenuText
            // 
            this.txtMenuText.Location = new System.Drawing.Point(115, 53);
            this.txtMenuText.Name = "txtMenuText";
            this.txtMenuText.Size = new System.Drawing.Size(214, 22);
            this.txtMenuText.TabIndex = 1;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(115, 22);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(214, 22);
            this.txtMenuName.TabIndex = 0;
            // 
            // chkIsSeparator
            // 
            this.chkIsSeparator.AutoSize = true;
            this.chkIsSeparator.Location = new System.Drawing.Point(17, 21);
            this.chkIsSeparator.Name = "chkIsSeparator";
            this.chkIsSeparator.Size = new System.Drawing.Size(141, 17);
            this.chkIsSeparator.TabIndex = 0;
            this.chkIsSeparator.Text = "분리선(Separator) 여부";
            this.chkIsSeparator.UseVisualStyleBackColor = true;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu추가ToolStripMenuItem,
            this.tabAddMenu추가ToolStripMenuItem,
            this.userControlMenu추가ToolStripMenuItem,
            this.toolStripSeparator1,
            this.구분선추가ToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(205, 98);
            // 
            // menu추가ToolStripMenuItem
            // 
            this.menu추가ToolStripMenuItem.Name = "menu추가ToolStripMenuItem";
            this.menu추가ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.menu추가ToolStripMenuItem.Text = "Form Load Menu 추가";
            // 
            // tabAddMenu추가ToolStripMenuItem
            // 
            this.tabAddMenu추가ToolStripMenuItem.Name = "tabAddMenu추가ToolStripMenuItem";
            this.tabAddMenu추가ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tabAddMenu추가ToolStripMenuItem.Text = "Tab Add Menu 추가";
            // 
            // userControlMenu추가ToolStripMenuItem
            // 
            this.userControlMenu추가ToolStripMenuItem.Name = "userControlMenu추가ToolStripMenuItem";
            this.userControlMenu추가ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.userControlMenu추가ToolStripMenuItem.Text = "User Control Menu 추가";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // 구분선추가ToolStripMenuItem
            // 
            this.구분선추가ToolStripMenuItem.Name = "구분선추가ToolStripMenuItem";
            this.구분선추가ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.구분선추가ToolStripMenuItem.Text = "구분선 추가";
            // 
            // txtTargetName
            // 
            this.txtTargetName.Location = new System.Drawing.Point(115, 145);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.Size = new System.Drawing.Size(214, 22);
            this.txtTargetName.TabIndex = 6;
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Location = new System.Drawing.Point(115, 114);
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(214, 22);
            this.txtAssemblyName.TabIndex = 5;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(115, 176);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(214, 22);
            this.txtParentName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Load Form Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assembly Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Target Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parent Name :";
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuManager";
            this.Text = "FormMenuManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView tv;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsSeparator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLoadType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuText;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem menu추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabAddMenu추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userControlMenu추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 구분선추가ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtTargetName;
        private System.Windows.Forms.TextBox txtAssemblyName;
    }
}