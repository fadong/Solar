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
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonInterface.AOP;

namespace Com.Fadong.ZClient {
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            SetLogin();

            ClientConfig.CONNECTED_TIME = DateTime.Now;
            ClientConfig.MASTER_TIMER.Elapsed += MASTER_TIMER_Elapsed;
            ClientConfig.MASTER_TIMER.Start();

            CommandManager.BE.onOpenFormListChanged += BE_onOpenFormListChanged;



            //Test
            UMViewer.UMViewer viewer = new UMViewer.UMViewer();
            viewer.Dock = DockStyle.Fill;
            C1.Win.C1Command.C1DockingTabPage tp = new C1.Win.C1Command.C1DockingTabPage();
            tp.Text = "TestTabPage";
            tp.Controls.Add(viewer);
            docTabMain.TabPages.Add(tp);
           
        }

        void MASTER_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            this.InvokeEx(k => k.tStripTxt_ConnTime .Text = "현재시각 : " + DateTime.Now.ToString("G"));
            this.InvokeEx(k => k.tStripTxt_ElapsedTime.Text = "경과시각 : " + DateTime.Now.Subtract(ClientConfig.CONNECTED_TIME).ToString("dd\\.hh\\:mm\\:ss"));
        }



        

        /// <summary>
        /// 
        /// </summary>
        private void SetLogin() {
            try {
                FormLogin frm = new FormLogin();
                if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    frm.Close();
                } else {
                    frm.Close();
                    this.Close();
                }
                
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
                Logger.Info(this, "System Exit!!");
            } catch (Exception err) {
                Logger.Error(this, err);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler() {

        }

        private void c1DockingTabPage1_Click(object sender, EventArgs e) {

        }

        [LogActivity(ACTIVITYLEVEL.All)]
        private void loadFormToolStripMenuItem_Click(object sender, EventArgs e) {
            Console.WriteLine(ZServer.BE.Svr.GetInstruments(new List<int>() { 1 }));
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
