using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Annotations;

namespace ZClient {
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            SetLogin();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetLogin() {
            try {
                FormLogin frm = new FormLogin();
                DialogResult rst = frm.ShowDialog();
                if (rst == System.Windows.Forms.DialogResult.OK) {
                    
                   
                } else {

                }
                frm.Close();
            } catch (Exception) {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler(object sender, EventArgs e) {
            ToolStripMenuItem mitem = (ToolStripMenuItem)sender;
            MessageBox.Show(mitem.Name);
            FormProduct frm = new FormProduct();
            frm.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuClose_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void CmdHandler() {

        }
    }
}
