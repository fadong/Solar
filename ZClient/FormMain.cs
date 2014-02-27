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
using CommonInterface;

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

        void BE_onOpenFormListChanged(List<Tuple<ToolStripMenuItem, Command_LoadForm>> frmlist) {
                try {
                    mnuL2Sys_RecentForm.DropDownItems.Clear();
                    foreach (var frm in frmlist) {
                        Command_LoadForm frminfo = frm.Item2;
                        ToolStripMenuItem mnu = new ToolStripMenuItem();
                        mnu.Text = frm.Item1.Text;
                        mnu.Name = frminfo.MenuName;
                        mnu.Click += CmdHandler;
                        mnuL2Sys_RecentForm.DropDownItems.Add(mnu);
                    }
                } catch (Exception err) {
                    Logger.Error(this, err.Message, err);
                }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler(object sender, EventArgs e) {
            ToolStripMenuItem mitem = (ToolStripMenuItem)sender;
            CommandManager.BE.Execute(mitem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuL2Sys_Close_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception err) {
                Logger.Info(this, "System Exit!!");
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
        //private void loadFormToolStripMenuItem_Click(object sender, EventArgs e) {
        //    try {
        //        var data = ZServer.BE.Svr.GetInstrumentKeyValues();
        //        testOutput.Text = data.Count.ToString();
        //    } catch (Exception err) {
        //        MessageBox.Show(err.Message);
        //    }
        //}
    }
}
