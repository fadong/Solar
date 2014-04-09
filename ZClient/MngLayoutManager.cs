using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Fadong.CommonLib;

namespace Com.Fadong.ZClient {
    //
    // 2014.04.09 ReCoding by JaeKyoon.lee
    //
    public class MngLayoutManager {

        private MngLayoutManager() {
            using (ZClientEntities ctx = new ZClientEntities()) {
                foreach (MenuMaster d in ctx.MenuMasters) {
                    this._dic.Add(d.mnuName, new ClsMenuInfo(d));
                }
            }
        }

        /// <summary>
        /// DB상의 정보를 이용하여 MenuItem들을 생성하고 이벤트 핸들러는 등록함
        /// </summary>
        /// <remarks>Author : Jaekyoon, Lee (2014-04-09)</remarks>
        /// <param name="mstrip">Main ManuStrip</param>
        /// <param name="cmdhandler">Menu Click Event Handler</param>
        public void SetMenuLayout(MenuStrip mstrip, EventHandler cmdhandler) {
            foreach (ClsMenuInfo mi in this._dic.Values.OrderBy(k => k.Order)) {
                if (mi.IsRootMenu) {
                    mstrip.Items.Add(mi.StripItem);
                    AddMenu(mi.StripItem, mi, cmdhandler);
                }
            }
        }

        #region "void AddMenu(ToolStripItem mnu, MenuMaster mmst, ZClientEntities ctx)"
        void AddMenu(ToolStripItem mnu, ClsMenuInfo mmst, EventHandler cmdhandler) {
            foreach (ClsMenuInfo mi in this._dic.Values.Where(k => k.RefId == mmst.Id && !k.IsRootMenu).OrderBy(k => k.Order)) {
                ToolStripItem smnu = mi.StripItem;
                smnu.Click += cmdhandler;
                ((ToolStripMenuItem)mnu).DropDownItems.Add(smnu);
                AddMenu(smnu, mi, cmdhandler);
            }
        }
        #endregion

        public static MngLayoutManager BE {
            get { return _instance; }
        }

        private static MngLayoutManager _instance = new MngLayoutManager();
        private Dictionary<string, ClsMenuInfo> _dic = new Dictionary<string, ClsMenuInfo>();
    }

    /// <summary>
    /// Menu정보를 담아두는 Class
    /// </summary>
    public class ClsMenuInfo {
        public enum LOADTYPE {
            ACTION = 0,
            FORM_WITH_UCTL = 1,
            ONLY_FORM = 2
        }

        /// <summary>
        /// Menu정보를 추가 작업 시 사용하는 생성자
        /// 해당 생성자를 통하여 Menu기초정보를 추가
        /// </summary>
        /// <param name="mnuName"></param>
        /// <param name="mnuText"></param>
        /// <param name="refid"></param>
        /// <param name="mnuType"></param>
        /// <param name="loadType"></param>
        /// <param name="hasChild"></param>
        /// <param name="Assemblyname"></param>
        /// <param name="parentname"></param>
        /// <param name="targetname"></param>
        /// <param name="order"></param>
        public ClsMenuInfo(string mnuName, string mnuText, int refid, int mnuType, LOADTYPE loadType, bool hasChild, 
                        string Assemblyname, string parentname, string targetname, int order, string shortcutkey) {
            this._mmst = MenuMaster.CreateMenuMaster(0, mnuName, mnuType, (int)loadType, hasChild ? 1 : 0, refid, mnuText);
            this.AssemblyName = Assemblyname;
            this.Parent = parentname;
            this.TargetName = targetname;
            this.Order = order;
        }

        public ClsMenuInfo(MenuMaster mmst) {
            this._mmst = mmst;
            
            if (!IsSeperator) {
                this._stripitem = new ToolStripMenuItem(this.MenuText);
                this._stripitem.Name = this._mmst.mnuName;
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
                            string path = this.AssemblyName + ".";
                            cmd = new MenuItemCommand4FormWithUCtl(this._stripitem, path + this.Parent, this.TargetName);
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
                this._stripitem.Name = this._mmst.mnuName;
            }
        }

        public int Id {
            get { return this._mmst.Id; }
            set { this._mmst.Id = value; }
        }

        public string MenuName {
            get { return this._mmst.mnuName; }
            set { this._mmst.mnuName = value; }
        }

        public string MenuText {
            get { return ClientConfig.LANGUAGE == CommonInterface.LANGUAGE.ENGLISH ? this._mmst.mnuTextEng : this._mmst.mnuText; }
            set { this._mmst.mnuText = value; }
        }

        public int RefId {
            get { return this._mmst.RefId; }
            set { this._mmst.RefId = value; }
        }

        public string AssemblyName {
            get { return this._mmst.TgAssembly; }
            set { this._mmst.TgAssembly = value; }
        }

        public string TargetName {
            get { return this._mmst.TgName; }
            set { this._mmst.TgAssembly = value; }
        }

        public string Parent {
            get { return this._mmst.Parent; }
            set { this._mmst.Parent = value; }
        }

        public bool IsRootMenu {
            get { return this._mmst.Id == this._mmst.RefId ? true : false; }
        }

        public bool IsSeperator {
            get { return this._mmst.mnuType == 0 ? true : false;  }
            set { this._mmst.mnuType = value ? 1 : 0; }
        }

        public int Order {
            get { return this._mmst.Order.HasValue ? this._mmst.Order.Value : 0;  }
            set { this._mmst.Order = value; }
        }

        public LOADTYPE LoadType {
            get { return (LOADTYPE)this._mmst.loadType;  }
            set { this._mmst.loadType = (int)value; }
        }

        public bool HasShortCut {
            get { return this._mmst.ShortCutKey != null && this._mmst.ShortCutKey.Length > 0 ? true : false; }
        }

        public Keys GetShortCut() {
            string[] skeyStrs = this._mmst.ShortCutKey.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
            Keys sumkey = Keys.None;
            for(int i = 0; i < skeyStrs.Length; i++) {
                Keys key;
                if (System.Enum.TryParse<Keys>(skeyStrs[i], out key)) {
                    if (i == 0)
                        sumkey = key;
                    else
                        sumkey |= key;
                }
            }
            return sumkey;
        }

        public void RegEventHandler(EventHandler handler) {
            if (!this.IsSeperator) {
                this._stripitem.Click += handler;
            }
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
