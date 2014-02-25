using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace ZClient {
    public delegate void GNotiFormList(List<string> frmlist);

    public class CommandManager : IEnumerable<Command> {

        /// <summary>
        /// 
        /// </summary>
        private CommandManager() {
            this._dic.Add("mnuL2UDDA", new Command_LoadForm("mnuL2UDDA", true, false, "ZClient.FormAnal_UDDE"));
            this._dic.Add("mnuL3InsEqtStock", new Command_ProdLoadForm("mnuL3InsEqtStock", true, false, "ZClient.FormProduct", "UCtlProd_Stock"));
            this._dic.Add("mnuL3InsEqtOpt", new Command_ProdLoadForm("mnuL3InsEqtOpt", true, false, "ZClient.FormProduct", "UCtlProd_Option"));
            this._dic.Add("mnuL3InsIrBond", new Command_ProdLoadForm("mnuL3InsIrBond", true, false, "ZClient.FormProduct", "UCtlProd_Bond"));
            this._dic.Add("mnuL3InsIrCap", new Command_ProdLoadForm("mnuL3InsIrCap", true, false, "ZClient.FormProduct", "UCtlProd_Cap"));
            this._dic.Add("mnuL3InsFxCash", new Command_ProdLoadForm("mnuL3InsFxCash", true, false, "ZClient.FormProduct", "UCtlProd_Cash"));
            this._dic.Add("mnuL3InsHybridCDFX", new Command_ProdLoadForm("mnuL3InsHybridCDFX", true, false, "ZClient.FormProduct", "UCtlProd_CDFX"));
            this._dic.Add("mnuL3InsCreditCDS", new Command_ProdLoadForm("mnuL3InsCreditCDS", true, false, "ZClient.FormProduct", "UCtlProd_CDS"));
            this._dic.Add("mnuL3InsCreditCLN", new Command_ProdLoadForm("mnuL3InsCreditCLN", true, false, "ZClient.FormProduct", "UCtlProd_CLN"));
            this._dic.Add("mnuL3InsIrCollar", new Command_ProdLoadForm("mnuL3InsIrCollar", true, false, "ZClient.FormProduct", "UCtlProd_Collar"));
            this._dic.Add("mnuL3InsOtherCombi", new Command_ProdLoadForm("mnuL3InsOtherCombi", true, false, "ZClient.FormProduct", "UCtlProd_Combination"));
            this._dic.Add("mnuL3InsCommdity", new Command_ProdLoadForm("mnuL3InsCommdity", true, false, "ZClient.FormProduct", "UCtlProd_Commodity"));
            this._dic.Add("mnuL3InsEqtConv", new Command_ProdLoadForm("mnuL3InsEqtConv", true, false, "ZClient.FormProduct", "UCtlProd_Convertible"));
            this._dic.Add("mnuL3InsFxCurrSwap", new Command_ProdLoadForm("mnuL3InsFxCurrSwap", true, false, "ZClient.FormProduct", "UCtlProd_CurrSwap"));
            this._dic.Add("mnuL3InsIrDepositLoan", new Command_ProdLoadForm("mnuL3InsIrDepositLoan", true, false, "ZClient.FormProduct", "UCtlProd_DepositLoan"));
            this._dic.Add("mnuL3InsLnkSecDLS", new Command_ProdLoadForm("mnuL3InsLnkSecDLS", true, false, "ZClient.FormProduct", "UCtlProd_DLS"));
            this._dic.Add("mnuL3InsHybridDuet", new Command_ProdLoadForm("mnuL3InsHybridDuet", true, false, "ZClient.FormProduct", "UCtlProd_Duet"));
            this._dic.Add("mnuL3InsEqtIdx", new Command_ProdLoadForm("mnuL3InsEqtIdx", true, false, "ZClient.FormProduct", "UCtlProd_EqtIndex"));
            this._dic.Add("mnuL3InsEqtSwap", new Command_ProdLoadForm("mnuL3InsEqtSwap", true, false, "ZClient.FormProduct", "UCtlProd_EquitySwap"));
            this._dic.Add("mnuL3InsEqtETF", new Command_ProdLoadForm("mnuL3InsEqtETF", true, false, "ZClient.FormProduct", "UCtlProd_ETF"));
            this._dic.Add("mnuL3InsIrFloor", new Command_ProdLoadForm("mnuL3InsIrFloor", true, false, "ZClient.FormProduct", "UCtlProd_Floor"));
            this._dic.Add("mnuL3InsEqtFFt", new Command_ProdLoadForm("mnuL3InsEqtFFt", true, false, "ZClient.FormProduct", "UCtlProd_ForwardFuture"));
            this._dic.Add("mnuL3InsIrFRA", new Command_ProdLoadForm("mnuL3InsIrFRA", true, false, "ZClient.FormProduct", "UCtlProd_FRA"));
            this._dic.Add("mnuL3InsIrFRN", new Command_ProdLoadForm("mnuL3InsIrFRN", true, false, "ZClient.FormProduct", "UCtlProd_FRN"));
            this._dic.Add("mnuL3InsFxOption", new Command_ProdLoadForm("mnuL3InsFxOption", true, false, "ZClient.FormProduct", "UCtlProd_FXOption"));
            this._dic.Add("mnuL3InsCreditMBSABS", new Command_ProdLoadForm("mnuL3InsCreditMBSABS", true, false, "ZClient.FormProduct", "UCtlProd_MBSABS"));
            this._dic.Add("mnuL3InsFxNDF", new Command_ProdLoadForm("mnuL3InsFxNDF", true, false, "ZClient.FormProduct", "UCtlProd_NDF"));
            this._dic.Add("mnuL3InsIrRateIndex", new Command_ProdLoadForm("mnuL3InsIrRateIndex", true, false, "ZClient.FormProduct", "UCtlProd_RateIndex"));
            this._dic.Add("mnuL3InsIrRepo", new Command_ProdLoadForm("mnuL3InsIrRepo", true, false, "ZClient.FormProduct", "UCtlProd_Repo"));
            this._dic.Add("mnuL3InsIrStructrualBond", new Command_ProdLoadForm("mnuL3InsIrStructrualBond", true, false, "ZClient.FormProduct", "UCtlProd_StructuralBond"));
            this._dic.Add("mnuL3InsIrSwap", new Command_ProdLoadForm("mnuL3InsIrSwap", true, false, "ZClient.FormProduct", "UCtlProd_Swap"));
            this._dic.Add("mnuL3InsOtherTRS", new Command_ProdLoadForm("mnuL3InsOtherTRS", true, false, "ZClient.FormProduct", "UCtlProd_TRS"));
            this._dic.Add("mnuL3InsEqtWarrant", new Command_ProdLoadForm("mnuL3InsEqtWarrant", true, false, "ZClient.FormProduct", "UCtlProd_Warrant"));
            this._dic.Add("mnuL3InsDR", new Command_ProdLoadForm("mnuL3InsDR", true, false, "ZClient.FormProduct", "UCtlProd_DR"));
            this._dic.Add("mnuL3InsIrZero", new Command_ProdLoadForm("mnuL3InsIrZero", true, false, "ZClient.FormProduct", "UCtlProd_Zero"));
            this._dic.Add("mnuL3InsLnkSecELS", new Command_ProdLoadForm("mnuL3InsLnkSecELS", true, false, "ZClient.FormProduct", "UCtlProd_ELS"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnuname"></param>
        public void Execute(string mnuname) {
            if(_dic.ContainsKey(mnuname)) {
                if(_dic[mnuname].IsLoadForm) {
                    _recentForm.Enqueue((Command_LoadForm)_dic[mnuname]);
                    OnOpenFormListChanged(_recentForm.Select(k => k.TargetName).ToList());
                }
                _dic[mnuname].Execute();
            }
        }

        private void OnOpenFormListChanged(List<string> openForms) {
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

        public Queue<Command_LoadForm> CommandsLoadForm {
            get { return this._recentForm; }
        }

        public static CommandManager BE {
            get { return _instance; }
        }

        private static CommandManager _instance = new CommandManager();
        private Dictionary<string, Command> _dic = new Dictionary<string, Command>();
        private Queue<Command_LoadForm> _recentForm = new Queue<Command_LoadForm>();
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

        public abstract void Execute();

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

        public override void Execute() {
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

        public override void Execute() {
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
}
