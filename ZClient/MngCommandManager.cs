using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using C1.Win.C1Command;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonInterface.AOP;

namespace Com.Fadong.ZClient {

    public delegate void GNotiFormList(List<Tuple<ToolStripMenuItem, MenuItemCommand>> frmlist);

    #region "public class CommandManager : IEnumerable<Command>"
    public class MngCommandManager : IEnumerable<Command> {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnuname"></param>
        
        public void Execute(string cmdname) {
            Stopwatch sw = new Stopwatch();
            ActivityLog.OnEntry(cmdname, true, ACTIVITYLEVEL.All, ref sw);
            if(_dic.ContainsKey(cmdname)) {
                _dic[cmdname].Execute();
                if(_dic[cmdname] is MenuItemCommand) {
                    if(((MenuItemCommand)_dic[cmdname]).IsLoadForm) {
                        if(!_recentForm.Any(k => k.Item2.Name.Equals(cmdname))) {
                            ToolStripMenuItem mnu = (ToolStripMenuItem)((MenuItemCommand)_dic[cmdname]).Menu;
                            _recentForm.Enqueue(new Tuple<ToolStripMenuItem, MenuItemCommand>(mnu, (MenuItemCommand)_dic[cmdname]));
                        }
                        OnOpenFormListChanged(_recentForm.ToList());
                    }
                }
            }
            ActivityLog.OnExit(cmdname, true, ACTIVITYLEVEL.All, ref sw);
        }

        private void OnOpenFormListChanged(List<Tuple<ToolStripMenuItem, MenuItemCommand>> openForms) {
            if(onOpenFormListChanged != null) {
                onOpenFormListChanged(openForms);
            }
        }

        public void Add(Command command) {
            if(!this._dic.ContainsKey(command.Name)) {
                this._dic.Add(command.Name, command);
            }
        }

        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns>IEnuerable<typeparamref name=">"/></returns>
        public IEnumerator<Command> GetEnumerator() {
            return _dic.Values.GetEnumerator();
        }

        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public Dictionary<string, Command> Commands {
            get { return this._dic; }
        }

        public Queue<Tuple<ToolStripMenuItem, MenuItemCommand>> OpenedForms {
            get { return this._recentForm; }
        }

        public static MngCommandManager BE {
            get { return _instance; }
        }

        private static MngCommandManager _instance = new MngCommandManager();
        private Dictionary<string, Command> _dic = new Dictionary<string, Command>();
        private Queue<Tuple<ToolStripMenuItem, MenuItemCommand>> _recentForm = new Queue<Tuple<ToolStripMenuItem, MenuItemCommand>>();
        public event GNotiFormList onOpenFormListChanged;
    }
    #endregion

    #region "public abstract class Command"
    /// <summary>
    /// Command Pattern을 위한 상위 Abstract Class
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public abstract class Command {
        public Command(string name) {
            this.Name = name;
        }

        public abstract void Execute();

        public string Name { get; internal set; }
    }
    #endregion

    #region "public class ActionCommand : Command"
    public class ActionCommand : Command {
        public ActionCommand(string name) 
            :base(name) {

        }

        public override void Execute() {

        }
    }
    #endregion

    #region "public class MenuItemCommand : Command"
    /// <summary>
    /// Command Pattern을 위한 상위 Abstract Class
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public class MenuItemCommand : Command {
        public MenuItemCommand(ToolStripItem menu, bool isloadform, bool haschildctl, string targetname)
            : base(menu.Name) {
            this.Menu = menu;
            this.Name = this.Menu.Name;
            this.IsLoadForm = isloadform;
            this.HasChildCtl = haschildctl;
            this.TargetName = targetname;
        }

        public override void Execute() {

        }

        //public string Name { get; internal set; }
        public ToolStripItem Menu { get; internal set; }
        public bool IsLoadForm { get; internal set; }
        public bool HasChildCtl { get; internal set; }
        public string TargetName { get; internal set; }
    }
    #endregion

    #region "public class MenuItemCommand4Action : MenuItemCommand"
    /// <summary>
    /// 
    /// </summary>
    public class MenuItemCommand4Action : MenuItemCommand {
        public MenuItemCommand4Action(ToolStripItem mnu)
            : base(mnu, false, false, string.Empty) {
        }

        public override void Execute() {
            switch(base.Name) {
                case "mnuL2_Sys_Exit":
                    Application.OpenForms["FormMain"].Close();
                    break;
                default:
                    break;
            }
        }
    }
    #endregion

    #region "public class MenuItemCommand4Form : MenuItemCommand"
    /// <summary>
    /// 기본 Form을 Loading하기위한 Class
    /// Modal여부를 입력할 수 있으며 Default는 False임
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public class MenuItemCommand4Form : MenuItemCommand {
        public MenuItemCommand4Form(ToolStripItem menu, string targetname, bool hasChild, bool ismodal = false)
            : base(menu, true, false, targetname) {
            this.IsModal = ismodal;
        }

        public override void Execute() {
            if(base.IsLoadForm) {
                Type t = Assembly.GetExecutingAssembly().GetType(this.TargetName);
                if(t != null) {
                    Form frm = (Form)Activator.CreateInstance(t);
                    if(IsModal) {
                        frm.ShowDialog();
                        Logger.Info(this, "System Exit!!");
                    }
                    else {
                        frm.Show();
                    }
                }
            }
        }

        public bool IsModal { get; internal set; }
    }
    #endregion

    #region "public class MenuItemCommand4FormWithUCtl : MenuItemCommand4Form"
    /// <summary>
    /// ProductForm을 Loading하기위한 Class
    /// 상품입력폼을 담고 있는 UserControl명을 인수로 받음
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public class MenuItemCommand4FormWithUCtl : MenuItemCommand4Form {
        public MenuItemCommand4FormWithUCtl(ToolStripItem menu, string targetname, string uctlname, bool ismodal = false)
            : base(menu, targetname, true, ismodal) {
            this.UCtlName = uctlname;
        }

        public override void Execute() {
            if(base.IsLoadForm) {
                Type t = Assembly.GetExecutingAssembly().GetType(this.TargetName);
                if(t != null) {
                    Form frm = (Form)Activator.CreateInstance(t, new string[] { UCtlName });
                    if(IsModal) {
                        frm.ShowDialog();
                    }
                    else {
                        frm.Show();
                    }
                }
            }
        }

        public string UCtlName { get; internal set; }
    }
    #endregion

    #region "public class MenuItemCommand4Viewer : MenuItemCommand"
    public class MenuItemCommand4Viewer : MenuItemCommand {
        public MenuItemCommand4Viewer(ToolStripItem menu, string targetname)
            : base(menu, false, false, targetname) {
                ((ToolStripMenuItem)menu).CheckOnClick = true;
        }

        public override void Execute() {
            Form mfrm = Application.OpenForms.OfType<Form>().FirstOrDefault(k => k.Name.Equals(ClientConfig.MAINFORM_NAME));
            if(mfrm != null) {
                Type t = typeof(C1DockingTab);
                List<C1DockingTab> doctabs = ClientUtil.GetChildrens<C1DockingTab>(mfrm).Where(k => k.Name.Equals(ClientConfig.DOCTAB_SUBINFONAME)).ToList();
                if(doctabs.Count == 1) {
                    if(((ToolStripMenuItem)base.Menu).Checked) {
                        C1DockingTabPage tp = new C1DockingTabPage();
                        tp.Name = tp.Text = base.Menu.Text;
                        Type ut = Assembly.GetExecutingAssembly().GetType(ClientConfig.UCTLVIEWER_PREFIX + this.TargetName);
                        UCtlViewer.UCtlViewer viewer = (UCtlViewer.UCtlViewer)Activator.CreateInstance(ut);

                        viewer.Dock = DockStyle.Fill;
                        tp.Controls.Add(viewer);
                        doctabs[0].SelectedIndex = ((C1DockingTab)doctabs[0]).TabPages.Add(tp);
                    }
                    else {
                        int tidx = ((C1DockingTab)doctabs[0]).TabPages[base.Menu.Text].TabIndex;
                        ((C1DockingTab)doctabs[0]).TabPages.RemoveAt(tidx);
                    }
                }
            }
        }
    }
    #endregion
}
