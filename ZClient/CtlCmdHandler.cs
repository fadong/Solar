using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace ZClient {
    public delegate void GNotiFormList(List<Tuple<ToolStripMenuItem, Command_LoadForm>> frmlist);

    public class CommandManager : IEnumerable<Command> {

        /// <summary>
        /// 
        /// </summary>
        private CommandManager() {
            this._dic.Add("mnuL2UDDA", new Command_LoadForm("mnuL2UDDA", true, false, "ZClient.FormAnal_UDDE"));
            this._dic.Add("mnuL3InsEqtStock", new Command_ProdLoadForm("mnuL3InsEqtStock", true, true, "ZClient.FormProduct", "UCtlProd_Stock"));
            this._dic.Add("mnuL3InsEqtOpt", new Command_ProdLoadForm("mnuL3InsEqtOpt", true, true, "ZClient.FormProduct", "UCtlProd_Option"));
            this._dic.Add("mnuL3InsIrBond", new Command_ProdLoadForm("mnuL3InsIrBond", true, true, "ZClient.FormProduct", "UCtlProd_Bond"));
            this._dic.Add("mnuL3InsIrCap", new Command_ProdLoadForm("mnuL3InsIrCap", true, true, "ZClient.FormProduct", "UCtlProd_Cap"));
            this._dic.Add("mnuL3InsFxCash", new Command_ProdLoadForm("mnuL3InsFxCash", true, true, "ZClient.FormProduct", "UCtlProd_Cash"));
            this._dic.Add("mnuL3InsHybridCDFX", new Command_ProdLoadForm("mnuL3InsHybridCDFX", true, true, "ZClient.FormProduct", "UCtlProd_CDFX"));
            this._dic.Add("mnuL3InsCreditCDS", new Command_ProdLoadForm("mnuL3InsCreditCDS", true, true, "ZClient.FormProduct", "UCtlProd_CDS"));
            this._dic.Add("mnuL3InsCreditCLN", new Command_ProdLoadForm("mnuL3InsCreditCLN", true, true, "ZClient.FormProduct", "UCtlProd_CLN"));
            this._dic.Add("mnuL3InsIrCollar", new Command_ProdLoadForm("mnuL3InsIrCollar", true, true, "ZClient.FormProduct", "UCtlProd_Collar"));
            this._dic.Add("mnuL3InsOtherCombi", new Command_ProdLoadForm("mnuL3InsOtherCombi", true, true, "ZClient.FormProduct", "UCtlProd_Combination"));
            this._dic.Add("mnuL3InsCommdity", new Command_ProdLoadForm("mnuL3InsCommdity", true, true, "ZClient.FormProduct", "UCtlProd_Commodity"));
            this._dic.Add("mnuL3InsEqtConv", new Command_ProdLoadForm("mnuL3InsEqtConv", true, true, "ZClient.FormProduct", "UCtlProd_Convertible"));
            this._dic.Add("mnuL3InsFxCurrSwap", new Command_ProdLoadForm("mnuL3InsFxCurrSwap", true, true, "ZClient.FormProduct", "UCtlProd_CurrSwap"));
            this._dic.Add("mnuL3InsIrDepositLoan", new Command_ProdLoadForm("mnuL3InsIrDepositLoan", true, true, "ZClient.FormProduct", "UCtlProd_DepositLoan"));
            this._dic.Add("mnuL3InsLnkSecDLS", new Command_ProdLoadForm("mnuL3InsLnkSecDLS", true, true, "ZClient.FormProduct", "UCtlProd_DLS"));
            this._dic.Add("mnuL3InsHybridDuet", new Command_ProdLoadForm("mnuL3InsHybridDuet", true, true, "ZClient.FormProduct", "UCtlProd_Duet"));
            this._dic.Add("mnuL3InsEqtIdx", new Command_ProdLoadForm("mnuL3InsEqtIdx", true, true, "ZClient.FormProduct", "UCtlProd_EqtIndex"));
            this._dic.Add("mnuL3InsEqtSwap", new Command_ProdLoadForm("mnuL3InsEqtSwap", true, true, "ZClient.FormProduct", "UCtlProd_EquitySwap"));
            this._dic.Add("mnuL3InsEqtETF", new Command_ProdLoadForm("mnuL3InsEqtETF", true, true, "ZClient.FormProduct", "UCtlProd_ETF"));
            this._dic.Add("mnuL3InsIrFloor", new Command_ProdLoadForm("mnuL3InsIrFloor", true, true, "ZClient.FormProduct", "UCtlProd_Floor"));
            this._dic.Add("mnuL3InsEqtFFt", new Command_ProdLoadForm("mnuL3InsEqtFFt", true, true, "ZClient.FormProduct", "UCtlProd_ForwardFuture"));
            this._dic.Add("mnuL3InsIrFRA", new Command_ProdLoadForm("mnuL3InsIrFRA", true, true, "ZClient.FormProduct", "UCtlProd_FRA"));
            this._dic.Add("mnuL3InsIrFRN", new Command_ProdLoadForm("mnuL3InsIrFRN", true, true, "ZClient.FormProduct", "UCtlProd_FRN"));
            this._dic.Add("mnuL3InsFxOption", new Command_ProdLoadForm("mnuL3InsFxOption", true, true, "ZClient.FormProduct", "UCtlProd_FXOption"));
            this._dic.Add("mnuL3InsCreditMBSABS", new Command_ProdLoadForm("mnuL3InsCreditMBSABS", true, true, "ZClient.FormProduct", "UCtlProd_MBSABS"));
            this._dic.Add("mnuL3InsFxNDF", new Command_ProdLoadForm("mnuL3InsFxNDF", true, true, "ZClient.FormProduct", "UCtlProd_NDF"));
            this._dic.Add("mnuL3InsIrRateIndex", new Command_ProdLoadForm("mnuL3InsIrRateIndex", true, true, "ZClient.FormProduct", "UCtlProd_RateIndex"));
            this._dic.Add("mnuL3InsIrRepo", new Command_ProdLoadForm("mnuL3InsIrRepo", true, true, "ZClient.FormProduct", "UCtlProd_Repo"));
            this._dic.Add("mnuL3InsIrStructrualBond", new Command_ProdLoadForm("mnuL3InsIrStructrualBond", true, true, "ZClient.FormProduct", "UCtlProd_StructuralBond"));
            this._dic.Add("mnuL3InsIrSwap", new Command_ProdLoadForm("mnuL3InsIrSwap", true, true, "ZClient.FormProduct", "UCtlProd_Swap"));
            this._dic.Add("mnuL3InsOtherTRS", new Command_ProdLoadForm("mnuL3InsOtherTRS", true, true, "ZClient.FormProduct", "UCtlProd_TRS"));
            this._dic.Add("mnuL3InsEqtWarrant", new Command_ProdLoadForm("mnuL3InsEqtWarrant", true, true, "ZClient.FormProduct", "UCtlProd_Warrant"));
            this._dic.Add("mnuL3InsDR", new Command_ProdLoadForm("mnuL3InsDR", true, true, "ZClient.FormProduct", "UCtlProd_DR"));
            this._dic.Add("mnuL3InsIrZero", new Command_ProdLoadForm("mnuL3InsIrZero", true, true, "ZClient.FormProduct", "UCtlProd_Zero"));
            this._dic.Add("mnuL3InsLnkSecELS", new Command_ProdLoadForm("mnuL3InsLnkSecELS", true, true, "ZClient.FormProduct", "UCtlProd_ELS"));
            this._dic.Add("mnuL2ViewAll", new Command_ViewerAttach("mnuL2ViewAll", false, true, "UCtlViewer_All"));
            this._dic.Add("mnuL2ViewProdInfo", new Command_ViewerAttach("mnuL2ViewProdInfo", false, true, "UCtlViewer_Prod"));
            this._dic.Add("mnuL2ViewTradeList", new Command_ViewerAttach("mnuL2ViewTradeList", false, true, "UCtlViewer_Trades"));
            this._dic.Add("mnuL2ViewPnL", new Command_ViewerAttach("mnuL2ViewPnL", false, true, "UCtlViewer_PnL"));
            this._dic.Add("mnuL2ViewRisk", new Command_ViewerAttach("mnuL2ViewRisk", false, true, "UCtlViewer_Risk"));
            this._dic.Add("mnuL3ViewSysTrace", new Command_ViewerAttach("mnuL3ViewSysTrace", false, true, "UCtlSysInfo_Trace"));
            this._dic.Add("mnuL3ViewSysDebug", new Command_ViewerAttach("mnuL3ViewSysDebug", false, true, "UCtlSysInfo_Debug"));
            this._dic.Add("mnuL3ViewSysPerformance", new Command_ViewerAttach("mnuL3ViewSysPerformance", false, true, "UCtlSysInfo_Performance"));
            this._dic.Add("mnuL2ViewValParams", new Command_ViewerAttach("mnuL2ViewValParams", false, true, "UCtlViewer_Params"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnuname"></param>
        public void Execute(ToolStripMenuItem menu) {
            string mnuname = menu.Name;
            if(_dic.ContainsKey(mnuname)) {
                if(_dic[mnuname].IsLoadForm) {
                    if(!_recentForm.Any(k => k.Item2.MenuName.Equals(mnuname))) {
                        _recentForm.Enqueue(new Tuple<ToolStripMenuItem, Command_LoadForm>(menu, (Command_LoadForm)_dic[mnuname]));
                    }
                    OnOpenFormListChanged(_recentForm.ToList());
                }
                _dic[mnuname].Execute(menu);
            }
        }

        private void OnOpenFormListChanged(List<Tuple<ToolStripMenuItem, Command_LoadForm>> openForms) {
            if(onOpenFormListChanged != null) {
                onOpenFormListChanged(openForms);
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

        public Queue<Tuple<ToolStripMenuItem, Command_LoadForm>> CommandsLoadForm {
            get { return this._recentForm; }
        }

        public static CommandManager BE {
            get { return _instance; }
        }

        private static CommandManager _instance = new CommandManager();
        private Dictionary<string, Command> _dic = new Dictionary<string, Command>();
        private Queue<Tuple<ToolStripMenuItem, Command_LoadForm>> _recentForm = new Queue<Tuple<ToolStripMenuItem, Command_LoadForm>>();
        public event GNotiFormList onOpenFormListChanged;
    }

    /// <summary>
    /// Command Pattern을 위한 상위 Abstract Class
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public abstract class Command {
        public Command(string menuname, bool isloadform, bool haschildctl, string targetname) {
            this.MenuName = menuname;
            this.IsLoadForm = isloadform;
            this.HasChildCtl = haschildctl;
            this.TargetName = targetname;
        }

        public abstract void Execute(ToolStripMenuItem mnu);

        public string MenuName { get; internal set; }
        public bool IsLoadForm { get; internal set; }
        public bool HasChildCtl { get; internal set; }
        public string TargetName { get; internal set; }
    }

    /// <summary>
    /// 기본 Form을 Loading하기위한 Class
    /// Modal여부를 입력할 수 있으며 Default는 False임
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public class Command_LoadForm : Command {
        public Command_LoadForm(string menuname, bool isloadform, bool haschildctl, string targetname, bool ismodal = false)
            : base(menuname, isloadform, haschildctl, targetname) {
                this.IsModal = ismodal;
        }

        public override void Execute(ToolStripMenuItem mnu) {
            if(base.IsLoadForm) {
                Type t = Assembly.GetExecutingAssembly().GetType(this.TargetName);
                if(t != null) {
                    Form frm = (Form)Activator.CreateInstance(t);
                    if(IsModal) {
                        frm.ShowDialog();
                    }
                    else {
                        frm.Show();
                    }
                }
            }
        }

        public bool IsModal { get; internal set; }
    }

    /// <summary>
    /// ProductForm을 Loading하기위한 Class
    /// 상품입력폼을 담고 있는 UserControl명을 인수로 받음
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-02-25)</remarks>
    public class Command_ProdLoadForm : Command_LoadForm {
        public Command_ProdLoadForm(string menuname, bool isloadform, bool haschildctl, string targetname, string uctlname)
            : base(menuname, isloadform, haschildctl, targetname, false) {
                this.UCtlName = uctlname;
        }

        public override void Execute(ToolStripMenuItem mnu) {
            if(base.IsLoadForm) {
                Type t = Assembly.GetExecutingAssembly().GetType(this.TargetName);
                if(t != null) {
                    Form frm = (Form)Activator.CreateInstance(t, new string[] { UCtlName } );
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

    public class Command_ViewerAttach : Command {
        public Command_ViewerAttach(string menuname, bool isloadform, bool haschildctl, string targetname)
            : base(menuname, isloadform, haschildctl, targetname) {
        }

        public override void Execute(ToolStripMenuItem mnu) {
            Form mfrm = Application.OpenForms.OfType<Form>().FirstOrDefault(k => k.Name.Equals(ClientConfig.MAINFORM_NAME));
            if (mfrm != null) {
                Type t = typeof(C1DockingTab);
                List<C1DockingTab> doctabs = ClientUtil.GetChildrens<C1DockingTab>(mfrm).Where(k => k.Name.Equals(ClientConfig.DOCTAB_SUBINFONAME)).ToList();
                if (doctabs.Count == 1) {
                    if (mnu.Checked) {
                        C1DockingTabPage tp = new C1DockingTabPage();
                        tp.Name = tp.Text = mnu.Text;
                        Type ut = Assembly.GetExecutingAssembly().GetType(ClientConfig.UCTLVIEWER_PREFIX + this.TargetName);
                        UCtlViewer.UCtlViewer viewer = (UCtlViewer.UCtlViewer)Activator.CreateInstance(ut);
                        
                        viewer.Dock = DockStyle.Fill;
                        tp.Controls.Add(viewer);
                        doctabs[0].SelectedIndex = ((C1DockingTab)doctabs[0]).TabPages.Add(tp);
                    } else {
                        int tidx = ((C1DockingTab)doctabs[0]).TabPages[mnu.Text].TabIndex;
                        ((C1DockingTab)doctabs[0]).TabPages.RemoveAt(tidx);
                    }
                }
            }
        }
    }
}
