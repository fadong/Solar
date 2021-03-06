﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Annotations;
using System.Diagnostics;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonInterface.AOP;
using Com.Fadong.CommonLib.Instrument;
using ServiceStack.Text;

namespace Com.Fadong.ZClient {
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            SetLogin();

            this._cmdHandler = CmdHandler;

            ClientConfig.CONNECTED_TIME = DateTime.Now;
            ClientConfig.MASTER_TIMER.Elapsed += MASTER_TIMER_Elapsed;
            ClientConfig.MASTER_TIMER.Start();

            MngLayoutManager.BE.SetMenuLayout(this.mnuMain, this._cmdHandler);
            MngCommandManager.BE.onOpenFormListChanged += BE_onOpenFormListChanged;

            //Test
            UMViewer.UMViewer viewer = new UMViewer.UMViewer();
            viewer.Dock = DockStyle.Fill;
            C1.Win.C1Command.C1DockingTabPage tp = new C1.Win.C1Command.C1DockingTabPage();
            tp.Text = "TestTabPage";
            tp.Controls.Add(viewer);
            docTabMain.TabPages.Add(tp);
           
        }

        #region "void MASTER_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MASTER_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            this.InvokeEx(k => k.tStripTxt_ConnTime.Text = "현재시각 : " + DateTime.Now.ToString("G"));
            this.InvokeEx(k => k.tStripTxt_ElapsedTime.Text = "경과시각 : " + DateTime.Now.Subtract(ClientConfig.CONNECTED_TIME).ToString("dd\\.hh\\:mm\\:ss"));
        }
        #endregion

        

        #region "private void SetLogin()"
        /// <summary>
        /// Login Process
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
        #endregion

        #region "void BE_onOpenFormListChanged(List<Tuple<ToolStripMenuItem, MenuItemCommand>> frmlist)"
        /// <summary>
        /// Opened Form Container
        /// </summary>
        /// <param name="frmlist"></param>
        void BE_onOpenFormListChanged(List<Tuple<ToolStripMenuItem, MenuItemCommand>> frmlist) {
            try {
                if(MngCommandManager.BE.Commands.ContainsKey("mnuL2_Sys_RecentForm")) {
                    MenuItemCommand mcmd = (MenuItemCommand)MngCommandManager.BE.Commands["mnuL2_Sys_RecentForm"];
                    ToolStripMenuItem qmnu = (ToolStripMenuItem)mcmd.Menu;
                    qmnu.DropDownItems.Clear();
                    foreach(var frm in frmlist) {
                        if(qmnu.Name != frm.Item1.Name) {
                            MenuItemCommand frminfo = frm.Item2;
                            ToolStripMenuItem mnu = new ToolStripMenuItem();
                            mnu.Text = frm.Item1.Text;
                            mnu.Name = frminfo.Name;
                            mnu.Click += CmdHandler;
                            qmnu.DropDownItems.Add(mnu);
                        }
                    }
                }
            }
            catch(Exception err) {
                Logger.Error(this, err.Message, err);
            }
        }
        #endregion

        #region "private void CmdHandler(object sender, EventArgs e)"
        /// <summary>
        /// Command Handler
        /// </summary>
        private void CmdHandler(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                ToolStripMenuItem mitem = (ToolStripMenuItem)sender;
                MngCommandManager.BE.Execute(mitem.Name);
            }
        }
        #endregion


        private EventHandler _cmdHandler = null;

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e) {
            try {
                FormMenuManager frm = new FormMenuManager();
                frm.ShowDialog();

            } catch (Exception err) {
                Logger.Error(this, err.Message);
            }
        }

        private void tBtn_FormalView_Click(object sender, EventArgs e) {
            try {
                //List<string> rsts = ZServer.BE.Svr.GetInstruments(new List<int>() { 1, 2, 3 });
                //List<FInstrument> insts = new List<FInstrument>();
                //foreach (string rst in rsts) {
                //    insts.Add(JsonSerializer.DeserializeFromString<FInstrument>(rst));
                //}
                //MessageBox.Show(insts.Count.ToString());

                List<Tuple<int, string>> lists = ZServer.BE.Svr.GetInstrumentKeyValues();
                MessageBox.Show(lists.Count.ToString());
            } catch (Exception err) {
                Logger.Error(this, err);
            }
        }

    }
}
