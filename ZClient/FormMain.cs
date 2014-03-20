using System;
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
            

            using (ZClientEntities ctx = new ZClientEntities()) {
                foreach (MenuMaster d in ctx.MenuMasters) {
                    if (d.mnuType == 1 && d.Id == d.RefId) {
                        ToolStripItem mnu = new ToolStripMenuItem(d.mnuText);
                        mnuMain.Items.Add(mnu);
                        AddMenu(mnu, d, ctx);
                    }
                }
            }            
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
            this.InvokeEx(k => k.tStripTxt_ConnTime.Text = "현재시각 : " + DateTime.Now.ToString("G"));
            this.InvokeEx(k => k.tStripTxt_ElapsedTime.Text = "경과시각 : " + DateTime.Now.Subtract(ClientConfig.CONNECTED_TIME).ToString("dd\\.hh\\:mm\\:ss"));
        }

        #region "void AddMenu(ToolStripItem mnu, MenuMaster mmst, ZClientEntities ctx)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnu"></param>
        /// <param name="mmst"></param>
        /// <param name="ctx"></param>
        void AddMenu(ToolStripItem mnu, MenuMaster mmst, ZClientEntities ctx) {
            foreach(MenuMaster d in ctx.MenuMasters.Where(k => k.RefId == mmst.Id && k.RefId != k.Id).OrderBy(k => k.Order)) {
                if(mnu is ToolStripMenuItem) {
                    ToolStripItem smnu = null;
                    if(d.mnuType == 1) { 
                        smnu = new ToolStripMenuItem(d.mnuText);
                        smnu.Name = d.mnuName;

                        if(d.ShortCutKey != null && d.ShortCutKey.Length > 0) {
                            string[] skeyStrs = d.ShortCutKey.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
                            Keys sumkey = Keys.None;
                            for(int i = 0; i < skeyStrs.Length; i++) {
                                Keys key;
                                Console.WriteLine(skeyStrs[i]);
                                if(Enum.TryParse(skeyStrs[i], out key)) {
                                    if(i == 0)
                                        sumkey = key;
                                    else
                                        sumkey |= key;
                                }
                            }
                            ((ToolStripMenuItem)smnu).ShortcutKeys = sumkey;
                        }
                        Command cmd = null;
                        if(d.loadType == 0) {
                            cmd = new MenuItemCommand4Action(smnu);
                        }
                        else if(d.loadType == 1) {
                            if(d.hasChild == 1) {
                                cmd = new MenuItemCommand4FormWithUCtl(smnu, d.TgAssembly + "." + d.Parent, d.TgName);
                            }
                            else {
                                cmd = new MenuItemCommand4Form(smnu, d.TgAssembly + "." + d.TgName, false);
                            }
                        }
                        else if(d.loadType == 2) {
                            cmd = new MenuItemCommand4Viewer(smnu, d.TgName);
                        }
                        CommandManager.BE.Add(cmd);
                        ((ToolStripMenuItem)smnu).Click += CmdHandler;
                    }
                    else { 
                        smnu = new ToolStripSeparator(); 
                    }
                    ((ToolStripMenuItem)mnu).DropDownItems.Add(smnu);
                    AddMenu(smnu, d, ctx);
                }
            }
        }
        #endregion

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

        void BE_onOpenFormListChanged(List<Tuple<ToolStripMenuItem, MenuItemCommand>> frmlist) {
            try {
                if(CommandManager.BE.Commands.ContainsKey("mnuL2_Sys_RecentForm")) {
                    MenuItemCommand mcmd = (MenuItemCommand)CommandManager.BE.Commands["mnuL2_Sys_RecentForm"];
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

        /// <summary>
        /// 
        /// </summary>
        private void CmdHandler(object sender, EventArgs e) {
            ToolStripMenuItem mitem = (ToolStripMenuItem)sender;
            CommandManager.BE.Execute(mitem.Name);
        }

    }
}
