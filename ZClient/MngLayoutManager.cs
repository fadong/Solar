using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Fadong.CommonLib;

namespace Com.Fadong.ZClient {
    public class MngLayoutManager {

        private MngLayoutManager() {



        }



        public void SetMenuLayout(MenuStrip mstrip, EventHandler cmdhandler) {
            using (ZClientEntities ctx = new ZClientEntities()) {
                foreach (MenuMaster d in ctx.MenuMasters.OrderBy(k => k.Order)) {
                    if (d.mnuType == 1 && d.Id == d.RefId) {
                        ToolStripItem mnu = new ToolStripMenuItem(d.mnuText);
                        mstrip.Items.Add(mnu);
                        AddMenu(mnu, d, ctx, cmdhandler);
                    }
                }
            }
        }

        #region "void AddMenu(ToolStripItem mnu, MenuMaster mmst, ZClientEntities ctx)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnu"></param>
        /// <param name="mmst"></param>
        /// <param name="ctx"></param>
        void AddMenu(ToolStripItem mnu, MenuMaster mmst, ZClientEntities ctx, EventHandler cmdhandler) {
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
                        MngCommandManager.BE.Add(cmd);
                        ((ToolStripMenuItem)smnu).Click += cmdhandler;
                    }
                    else { 
                        smnu = new ToolStripSeparator(); 
                    }
                    ((ToolStripMenuItem)mnu).DropDownItems.Add(smnu);
                    AddMenu(smnu, d, ctx, cmdhandler);
                }
            }
        }
        #endregion

        public static MngLayoutManager BE {
            get { return _instance; }
        }

        private static MngLayoutManager _instance = new MngLayoutManager();
    }
}
