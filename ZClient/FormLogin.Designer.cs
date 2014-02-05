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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabCtlOption = new System.Windows.Forms.TabControl();
            this.tabPg_FiscalDate = new System.Windows.Forms.TabPage();
            this.tabPg_Color = new System.Windows.Forms.TabPage();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOptionShow = new System.Windows.Forms.Button();
            this.tabPg_General = new System.Windows.Forms.TabPage();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabCtlOption.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabCtlOption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.26446F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabCtlOption
            // 
            this.tabCtlOption.Controls.Add(this.tabPg_General);
            this.tabCtlOption.Controls.Add(this.tabPg_FiscalDate);
            this.tabCtlOption.Controls.Add(this.tabPg_Color);
            this.tabCtlOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlOption.Location = new System.Drawing.Point(3, 112);
            this.tabCtlOption.Name = "tabCtlOption";
            this.tabCtlOption.SelectedIndex = 0;
            this.tabCtlOption.Size = new System.Drawing.Size(379, 208);
            this.tabCtlOption.TabIndex = 0;
            // 
            // tabPg_FiscalDate
            // 
            this.tabPg_FiscalDate.Location = new System.Drawing.Point(4, 22);
            this.tabPg_FiscalDate.Name = "tabPg_FiscalDate";
            this.tabPg_FiscalDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_FiscalDate.Size = new System.Drawing.Size(371, 182);
            this.tabPg_FiscalDate.TabIndex = 0;
            this.tabPg_FiscalDate.Text = "결산기준시점 ";
            this.tabPg_FiscalDate.UseVisualStyleBackColor = true;
            // 
            // tabPg_Color
            // 
            this.tabPg_Color.Location = new System.Drawing.Point(4, 22);
            this.tabPg_Color.Name = "tabPg_Color";
            this.tabPg_Color.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_Color.Size = new System.Drawing.Size(371, 182);
            this.tabPg_Color.TabIndex = 1;
            this.tabPg_Color.Text = "색상";
            this.tabPg_Color.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnOptionShow);
            this.panelBottom.Controls.Add(this.btnHelp);
            this.panelBottom.Controls.Add(this.btnConnect);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 326);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(379, 47);
            this.panelBottom.TabIndex = 1;
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
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(74, 14);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(185, 22);
            this.txtUserId.TabIndex = 0;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(74, 42);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(185, 22);
            this.txtPW.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "로그인";
            this.btnConnect.UseVisualStyleBackColor = true;
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
            // btnOptionShow
            // 
            this.btnOptionShow.FlatAppearance.BorderSize = 0;
            this.btnOptionShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionShow.Location = new System.Drawing.Point(9, 11);
            this.btnOptionShow.Name = "btnOptionShow";
            this.btnOptionShow.Size = new System.Drawing.Size(85, 25);
            this.btnOptionShow.TabIndex = 2;
            this.btnOptionShow.Text = "▲▼ 옵션표시";
            this.btnOptionShow.UseVisualStyleBackColor = true;
            // 
            // tabPg_General
            // 
            this.tabPg_General.Location = new System.Drawing.Point(4, 22);
            this.tabPg_General.Name = "tabPg_General";
            this.tabPg_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_General.Size = new System.Drawing.Size(371, 182);
            this.tabPg_General.TabIndex = 2;
            this.tabPg_General.Text = "일반";
            this.tabPg_General.UseVisualStyleBackColor = true;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(9, 19);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(65, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "사용자 ID : ";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(12, 46);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(61, 13);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "비밀번호 : ";
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
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(74, 70);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(185, 21);
            this.cmbServer.TabIndex = 5;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 74);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(61, 13);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "접속서버 : ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabCtlOption.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabCtlOption;
        private System.Windows.Forms.TabPage tabPg_FiscalDate;
        private System.Windows.Forms.TabPage tabPg_Color;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnOptionShow;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TabPage tabPg_General;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUserId;
    }
}