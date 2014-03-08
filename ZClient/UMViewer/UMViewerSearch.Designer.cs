namespace Com.Fadong.ZClient.UMViewer {
    partial class UMViewerSearch {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UMViewerSearch));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkAllCharEqual = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchNext = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.gResult = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gResult)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Controls.Add(this.gResult);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "40.3361344537815:False:True;59.1036414565826:False:False;\t100:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Padding = new System.Windows.Forms.Padding(0);
            this.c1Sizer1.Size = new System.Drawing.Size(512, 357);
            this.c1Sizer1.SplitterWidth = 2;
            this.c1Sizer1.TabIndex = 2;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearchAll);
            this.panel1.Controls.Add(this.btnSearchNext);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.chkAllCharEqual);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkAllCharEqual
            // 
            this.chkAllCharEqual.AutoSize = true;
            this.chkAllCharEqual.Location = new System.Drawing.Point(93, 74);
            this.chkAllCharEqual.Name = "chkAllCharEqual";
            this.chkAllCharEqual.Size = new System.Drawing.Size(115, 17);
            this.chkAllCharEqual.TabIndex = 2;
            this.chkAllCharEqual.Text = "전체 셀 내용 일치";
            this.chkAllCharEqual.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "대소문자 구분";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.Location = new System.Drawing.Point(276, 101);
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(92, 27);
            this.btnSearchNext.TabIndex = 5;
            this.btnSearchNext.Text = "다음 찾기";
            this.btnSearchNext.UseVisualStyleBackColor = true;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(180, 101);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(92, 27);
            this.btnSearchAll.TabIndex = 6;
            this.btnSearchAll.Text = "전체 찾기";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            // 
            // gResult
            // 
            this.gResult.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this.gResult.Location = new System.Drawing.Point(0, 146);
            this.gResult.Name = "gResult";
            this.gResult.Rows.Count = 1;
            this.gResult.Rows.DefaultSize = 21;
            this.gResult.Size = new System.Drawing.Size(512, 211);
            this.gResult.StyleInfo = resources.GetString("gResult.StyleInfo");
            this.gResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "찾을 내용 :";
            // 
            // UMViewerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 379);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UMViewerSearch";
            this.Text = "UMViewerSearch";
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkAllCharEqual;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid gResult;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.Label label1;
    }
}