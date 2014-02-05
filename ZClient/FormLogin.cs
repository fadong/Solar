using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClient {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
            _height = tblLayoutPanel.RowStyles[1].Height;

            tblLayoutPanel.RowStyles[1].Height = 0;
            this.Height = this.Height - (int)_height;
            this.btnOptionShow.Text = _dnarrow;
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            try {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void btnOptionShow_MouseClick(object sender, MouseEventArgs e) {
            try {
                if (_isOptOpen) {
                    _height = tblLayoutPanel.RowStyles[1].Height;
                    tblLayoutPanel.RowStyles[1].Height = 0;
                    this.Height = this.Height - (int)_height;
                    this.btnOptionShow.Text = _dnarrow;
                } else {
                    tblLayoutPanel.RowStyles[1].Height = _height;
                    this.Height = this.Height + (int)_height;
                    this.btnOptionShow.Text = _uparrow;
                }
                this._isOptOpen = !_isOptOpen;
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private bool _isOptOpen = false;
        private float _height = 0;
        private string _uparrow = "▲ 옵션 숨기기";
        private string _dnarrow = "▼ 옵션 표시";
    }
}
