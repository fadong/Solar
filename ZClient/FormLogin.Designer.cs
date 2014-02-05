namespace ZClient {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOptionShow = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblServer = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tPage_General = new System.Windows.Forms.TabPage();
            this.tPage_FiscalDate = new System.Windows.Forms.TabPage();
            this.tPage_Color = new System.Windows.Forms.TabPage();
            this.tblLayoutPanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCtl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.ColumnCount = 1;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanel.Controls.Add(this.panelBottom, 0, 2);
            this.tblLayoutPanel.Controls.Add(this.panelTop, 0, 0);
            this.tblLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.tblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 3;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(385, 414);
            this.tblLayoutPanel.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnOptionShow);
            this.panelBottom.Controls.Add(this.btnHelp);
            this.panelBottom.Controls.Add(this.btnConnect);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 362);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(379, 49);
            this.panelBottom.TabIndex = 1;
            // 
            // btnOptionShow
            // 
            this.btnOptionShow.FlatAppearance.BorderSize = 0;
            this.btnOptionShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionShow.Location = new System.Drawing.Point(9, 18);
            this.btnOptionShow.Name = "btnOptionShow";
            this.btnOptionShow.Size = new System.Drawing.Size(90, 25);
            this.btnOptionShow.TabIndex = 2;
            this.btnOptionShow.Text = "▲▼ 옵션표시";
            this.btnOptionShow.UseVisualStyleBackColor = true;
            this.btnOptionShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOptionShow_MouseClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(308, 9);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 29);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "도움말";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "로그인";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblServer);
            this.panelTop.Controls.Add(this.cmbServer);
            this.panelTop.Controls.Add(this.chkRememberMe);
            this.panelTop.Controls.Add(this.lblPW);
            this.panelTop.Controls.Add(this.lblUserId);
            this.panelTop.Controls.Add(this.txtPW);
            this.panelTop.Controls.Add(this.txtUserId);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(379, 103);
            this.panelTop.TabIndex = 2;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 74);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(57, 13);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "접속서버 :";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(74, 70);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(185, 21);
            this.cmbServer.TabIndex = 5;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(272, 18);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(102, 17);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(12, 46);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(57, 13);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "비밀번호 :";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(9, 19);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(61, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "사용자 ID :";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(74, 42);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(185, 22);
            this.txtPW.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(74, 14);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(185, 22);
            this.txtUserId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabCtl);
            this.panel1.Location = new System.Drawing.Point(3, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 244);
            this.panel1.TabIndex = 3;
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tPage_General);
            this.tabCtl.Controls.Add(this.tPage_FiscalDate);
            this.tabCtl.Controls.Add(this.tPage_Color);
            this.tabCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtl.Location = new System.Drawing.Point(0, 0);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(379, 244);
            this.tabCtl.TabIndex = 0;
            // 
            // tPage_General
            // 
            this.tPage_General.Location = new System.Drawing.Point(4, 22);
            this.tPage_General.Name = "tPage_General";
            this.tPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_General.Size = new System.Drawing.Size(371, 218);
            this.tPage_General.TabIndex = 0;
            this.tPage_General.Text = "일반";
            this.tPage_General.UseVisualStyleBackColor = true;
            // 
            // tPage_FiscalDate
            // 
            this.tPage_FiscalDate.Location = new System.Drawing.Point(4, 22);
            this.tPage_FiscalDate.Name = "tPage_FiscalDate";
            this.tPage_FiscalDate.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_FiscalDate.Size = new System.Drawing.Size(371, 218);
            this.tPage_FiscalDate.TabIndex = 1;
            this.tPage_FiscalDate.Text = "결산시점";
            this.tPage_FiscalDate.UseVisualStyleBackColor = true;
            // 
            // tPage_Color
            // 
            this.tPage_Color.Location = new System.Drawing.Point(4, 22);
            this.tPage_Color.Name = "tPage_Color";
            this.tPage_Color.Size = new System.Drawing.Size(371, 218);
            this.tPage_Color.TabIndex = 2;
            this.tPage_Color.Text = "색상";
            this.tPage_Color.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 414);
            this.Controls.Add(this.tblLayoutPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.tblLayoutPanel.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabCtl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnOptionShow;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage tPage_General;
        private System.Windows.Forms.TabPage tPage_FiscalDate;
        private System.Windows.Forms.TabPage tPage_Color;
    }
}