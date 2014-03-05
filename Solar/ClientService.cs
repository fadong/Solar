using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.Solar {

    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant,
                     InstanceContextMode = InstanceContextMode.PerSession,
                     IncludeExceptionDetailInFaults = true)]
    public partial class ClientService : IClientService, IDisposable {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cinfo"></param>
        /// <returns></returns>
        public List<Claim> Connect(ClientInfo cinfo) {
            try {
                List<Claim> clist = OperationContext.Current.ClaimsPrincipal.Claims.ToList();
                cinfo.Identifier = OperationContext.Current.SessionId;
                cinfo.ConnectedTime = DateTime.Now;
                IClientCB client = OperationContext.Current.GetCallbackChannel<IClientCB>();
                OperationContext.Current.Channel.Faulted += new EventHandler(Channel_Faulted);
                OperationContext.Current.Channel.Closed += new EventHandler(Channel_Closed);

                lock (ClientService.CLIENTS) {
                    if (!ClientService.CLIENTS.ContainsKey(client)) {
                        ClientService.CLIENTS.Add(client, cinfo);
                    }
                }

                Logger.Info(this, string.Format("User[{0}] Login", cinfo.UserName));
                return clist;
            } catch (Exception err) {
                throw err.CreateFaultException("Solar Server Connection Failed!!");
            }
        }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="closedGracefully"></param>
        #region "UnregisterCallback(IClientChannel channel, bool closedGracefully)"
        void UnregistCallback(IClientChannel channel, bool closedGracefully) {
            string sessid = channel.SessionId;
            string userid = string.Empty;
            string endip = channel.RemoteAddress.ToString();


            IClientCB cback = null;
            foreach (KeyValuePair<IClientCB, ClientInfo> v in CLIENTS) {
                if (v.Value.Identifier.Equals(sessid)) {
                    cback = v.Key;
                    userid = v.Value.UserId;
                }
            }
            if (cback != null && ClientService.CLIENTS.ContainsKey(cback)) {
                ClientService.CLIENTS.Remove(cback);
            }
            string msg = String.Format("[{0}, {1} : {2}] Cleint Connection Closed !!", userid, endip, DateTime.Now);
            Logger.Info(this, msg);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="msg"></param>
        private void OnClientChanged(object obj, string msg) {
            if (clientChanged != null) {
                clientChanged(this, msg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void OpenClientServiceHost() {
            try {
                this._sh = new ServiceHost(typeof(ClientService));
                this._sh.Faulted += new EventHandler(_sh_Faulted);

                this._sh.Open();
                Uri baddr = this._sh.BaseAddresses.FirstOrDefault(k => k.Scheme.Equals("net.tcp"));
                Logger.Info(this, String.Format("ClientService Host[{0}] Opened!!", baddr.ToString()));

            } catch (Exception err) {
                Logger.Error(this, "OpenClientServiceHost", err);
                throw err.CreateFaultException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _sh_Faulted(object sender, EventArgs e) {
            Logger.Fatal(this, "ClientService Faulted!!");
        }

        public void Dispose() {
            if (_isDisposed) return;
        }

        ServiceHost _sh;
        public static Dictionary<IClientCB, ClientInfo> CLIENTS = new Dictionary<IClientCB, ClientInfo>();
        public static event notiOperation clientChanged;
        private bool _isDisposed = false;
    }
}
