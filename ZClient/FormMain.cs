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
            CommandManager.BE.onOpenFormListChanged += BE_onOpenFormListChanged;
        }

        

        /// <summary>
        /// 
        /// </summary>
        private void SetLogin() {
            try {
                FormLogin frm = new FormLogin();
                if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    
                   
                } else {

                }
                frm.Close();
            } catch (Exception) {

            }
        }

        void BE_onOpenFormListChanged(List<string> frmlist) {

        }

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler(object sender, EventArgs e) {
            ToolStripMenuItem mitem = (ToolStripMenuItem)sender;
            CommandManager.BE.Execute(mitem.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuL2Sys_Close(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler() {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFormToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                var data = ZServer.BE.Svr.GetInstrumentKeyValues();
                testOutput.Text = data.Count.ToString();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
