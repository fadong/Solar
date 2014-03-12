using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.Calculator.GridCalculator {
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant,
                     InstanceContextMode = InstanceContextMode.PerSession,
                     IncludeExceptionDetailInFaults = true)]
    public partial class CalcService : ICalcService, IDisposable {

        #region "public XElement Connect(ClientInfo cinfo)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cinfo"></param>
        /// <returns></returns>
        public XElement Connect(ClientInfo cinfo) {
            try {
                cinfo.Identifier = OperationContext.Current.SessionId;
                cinfo.ConnectedTime = DateTime.Now;
                INodeCB client = OperationContext.Current.GetCallbackChannel<INodeCB>();
                OperationContext.Current.Channel.Faulted += new EventHandler(Channel_Faulted);
                OperationContext.Current.Channel.Closed += new EventHandler(Channel_Closed);

                lock (CalcService.CLIENTS) {
                    if (!CalcService.CLIENTS.ContainsKey(client)) {
                        CalcService.CLIENTS.Add(client, cinfo);
                    }
                }

                Logger.Info(this, string.Format("User[{0}] Login", cinfo.UserName));
                return new XElement("");
            } catch (Exception err) {
                throw err.CreateFaultException("CalcServer Connection Failed!!");
            }
        }
        #endregion

        #region "Channel_Closed(object sender, EventArgs e)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Channel_Closed(object sender, EventArgs e) {
            Logger.Info(this, "Channel is Closed!!");
            UnregistCallback(sender as IClientChannel, true);
        }
        #endregion

        #region "Channel_Faulted(object sender, EventArgs e)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Channel_Faulted(object sender, EventArgs e) {
            Logger.Info(this, "Channel is Faulted!!");
            UnregistCallback(sender as IClientChannel, false);
        }
        #endregion

        #region "UnregisterCallback(IClientChannel channel, bool closedGracefully)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="closedGracefully"></param>
        void UnregistCallback(IClientChannel channel, bool closedGracefully) {
            string sessid = channel.SessionId;
            string userid = string.Empty;
            string endip = channel.RemoteAddress.ToString();


            INodeCB cback = null;
            foreach (KeyValuePair<INodeCB, ClientInfo> v in CLIENTS) {
                if (v.Value.Identifier.Equals(sessid)) {
                    cback = v.Key;
                    userid = v.Value.UserId;
                }
            }
            if (cback != null && CalcService.CLIENTS.ContainsKey(cback)) {
                CalcService.CLIENTS.Remove(cback);
            }
            string msg = String.Format("[{0}, {1} : {2}] Cleint Connection Closed !!", userid, endip, DateTime.Now);
            Logger.Info(this, msg);
        }
        #endregion

        #region "public void Dispose()"
        /// <summary>
        /// 
        /// </summary>
        public void Dispose() {
            if (_isDisposed) return;
        }
        #endregion

        #region "public void OpenClientServiceHost()"
        /// <summary>
        /// 
        /// </summary>
        public void OpenClientServiceHost() {
            try {
                this._sh = new ServiceHost(typeof(CalcService));
                this._sh.Faulted += new EventHandler(_sh_Faulted);

                this._sh.Open();
                Uri baddr = this._sh.BaseAddresses.FirstOrDefault(k => k.Scheme.Equals("net.tcp"));
                Logger.Info(this, String.Format("CalcService Host[{0}] Opened!!", baddr.ToString()));

            } catch (Exception err) {
                Logger.Error(this, "OpenClientServiceHost", err);
                throw err.CreateFaultException();
            }
        }
        #endregion

        #region "void _sh_Faulted(object sender, EventArgs e)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _sh_Faulted(object sender, EventArgs e) {
            Logger.Fatal(this, "ClientService Faulted!!");
        }
        #endregion

        ServiceHost _sh;
        public static Dictionary<INodeCB, ClientInfo> CLIENTS = new Dictionary<INodeCB, ClientInfo>();
        private bool _isDisposed = false;
    }
}
