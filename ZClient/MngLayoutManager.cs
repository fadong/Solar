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
            using (ZClientEntities ctx = new ZClientEntities()) {
                foreach (MenuMaster d in ctx.MenuMasters) {
                    this._dic.Add(d.mnuName, new MenuInfo(d));
                }
            }
        }

        public void SetMenuLayout(MenuStrip mstrip, EventHandler cmdhandler) {
            foreach (MenuInfo mi in this._dic.Values.OrderBy(k => k.Order)) {
                if (mi.IsRootMenu) {
                    mstrip.Items.Add(mi.StripItem);
                    AddMenu(mi.StripItem, mi, cmdhandler);
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
        void AddMenu(ToolStripItem mnu, MenuInfo mmst, EventHandler cmdhandler) {
            foreach (MenuInfo mi in this._dic.Values.Where(k => k.RefId == mmst.Id && !k.IsRootMenu).OrderBy(k => k.Order)) {
                ToolStripItem smnu = mi.StripItem;
                ((ToolStripMenuItem)mnu).DropDownItems.Add(smnu);
                AddMenu(smnu, mi, cmdhandler);
            }
        }
        #endregion

        public static MngLayoutManager BE {
            get { return _instance; }
        }

        private static MngLayoutManager _instance = new MngLayoutManager();
        private Dictionary<string, MenuInfo> _dic = new Dictionary<string, MenuInfo>();
    }

    public class MenuInfo {
        public enum LOADTYPE {
            ACTION = 0,
            FORM_WITH_UCTL = 1,
            ONLY_FORM = 2
        }

        public MenuInfo(string mnuName, string mnuText, int refid, int mnuType, LOADTYPE loadType, bool hasChild, string Assemblyname, string parentname, string targetname, int order) {
            this._mmst = MenuMaster.CreateMenuMaster(0, mnuName, mnuType, (int)loadType, hasChild ? 1 : 0, refid, mnuText);
            this._mmst.TgAssembly = Assemblyname;
            this._mmst.Parent = parentname;
            this._mmst.TgName = targetname;
            this._mmst.Order = order;
        }

        public MenuInfo(MenuMaster mmst) {
            this._mmst = mmst;

            if (!IsSeperator) {
                this._stripitem = new ToolStripMenuItem(this.MenuText);
                if (this.HasShortCut) {
                    ((ToolStripMenuItem)this._stripitem).ShortcutKeys = this.GetShortCut();
                }
                Command cmd = null;
                switch (this.LoadType) {
                    case LOADTYPE.ACTION:
                        cmd = new MenuItemCommand4Action(this._stripitem);
                        break;
                    case LOADTYPE.FORM_WITH_UCTL:
                        if (this.HasChild) {
                            cmd = new MenuItemCommand4FormWithUCtl(this._stripitem, this.AssemblyName + "." + this.Parent, this.TargetName);
                        } else {
                            cmd = new MenuItemCommand4Form(this._stripitem, this.AssemblyName + "." + this.TargetName, false);
                        }
                        break;
                    case LOADTYPE.ONLY_FORM:
                        cmd = new MenuItemCommand4Viewer(this._stripitem, this.TargetName);
                        break;
                }
                MngCommandManager.BE.Add(cmd);
            } else {
                this._stripitem = new ToolStripSeparator();
            }
            this._stripitem.Name = this._mmst.mnuName;
        }

        public int Id {
            get { return this._mmst.Id; }
        }

        public string MenuName {
            get { return this._mmst.mnuName; }
        }

        public string MenuText {
            get { return ClientConfig.LANGUAGE == CommonInterface.LANGUAGE.ENGLISH ? this._mmst.mnuTextEng : this._mmst.mnuText; }
        }

        public int RefId {
            get { return this._mmst.RefId;  }
        }

        public string AssemblyName {
            get { return this._mmst.TgAssembly;  }
        }

        public string TargetName {
            get { return this._mmst.TgName; }
        }

        public string Parent {
            get { return this._mmst.Parent; }
        }

        public bool IsRootMenu {
            get { return this._mmst.Id == this._mmst.RefId ? true : false; }
        }

        public bool IsSeperator {
            get { return this._mmst.mnuType == 0 ? true : false;  }
        }

        public int Order {
            get { return this._mmst.Order.HasValue ? this._mmst.Order.Value : 0;  }
        }

        public LOADTYPE LoadType {
            get { return (LOADTYPE)this._mmst.loadType;  }
        }

        public bool HasShortCut {
            get { return this._mmst.ShortCutKey != null && this._mmst.ShortCutKey.Length > 0 ? true : false; }
        }

        public Keys GetShortCut() {
            string[] skeyStrs = this._mmst.ShortCutKey.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
            Keys sumkey = Keys.None;
            for(int i = 0; i < skeyStrs.Length; i++) {
                Keys key;
                if(Enum.TryParse(skeyStrs[i], out key)) {
                    if(i == 0)
                        sumkey = key;
                    else
                        sumkey |= key;
                }
            }
            return sumkey;
        }

        public bool HasChild {
            get { return this._mmst.hasChild == 1 ? true : false; }
        }

        public ToolStripItem StripItem {
            get { return this._stripitem; }
        }

        private MenuMaster _mmst = null;
        ToolStripItem _stripitem = null;
    }
}
