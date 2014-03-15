using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Claims;
using System.Net;
using System.Net.Sockets;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.Adapter {
    public class ServerAgent : IClientCB
    {

        #region "접속관련 함수군(Connect, RemoteConnect)"
        /// <summary>
        /// Client Server 접속 Adapter용 함수
        /// </summary>
        /// <param name="id">사용자 Id</param>
        /// <param name="pw">사용자 비번</param>
        /// <param name="isLocalhost"></param>
        /// <returns></returns>
        public List<Claim> Connect(string id, string pw, bool isLocalhost) {
            try {
                ClientInfo cinfo = new ClientInfo();
                var ip = Dns.GetHostAddresses(Dns.GetHostName()).Where(k => k.AddressFamily == AddressFamily.InterNetwork).First();
                cinfo.IP = ip.ToString();
                cinfo.UserId = id;
                cinfo.PassWord = pw;
                cinfo.UserName = Environment.UserName;
                cinfo.DomainName = Environment.UserDomainName;
                cinfo.OSVersion = Environment.OSVersion.VersionString;
                cinfo.OSVersion += Environment.Is64BitOperatingSystem ? "64it" : "32bit";
                cinfo.SysDir = Environment.SystemDirectory;
                cinfo.CurrDir = Environment.CurrentDirectory;
                cinfo.RequestTime = DateTime.Now;
                cinfo.ConnectedTime = DateTime.Now;
                return RemoteConnect(cinfo, isLocalhost);
            } catch (Exception) {
                throw;
            }
        }

        /// <summary>
        /// 실제 Channel Open을 통하여 네크워크 상으로 연결 진행
        /// </summary>
        /// <param name="cinfo"></param>
        /// <param name="isLocalhost"></param>
        /// <returns></returns>
        private List<Claim> RemoteConnect(ClientInfo cinfo, bool isLocalhost) {
            try {
                List<Claim> claims = new List<Claim>();
                InstanceContext context = new InstanceContext(this);
                var serviceName = "Com.Fadong.ZClient";
                var factory = new DuplexChannelFactory<IClientService>(context, serviceName);
                factory.Credentials.UserName.UserName = cinfo.UserId;
                factory.Credentials.UserName.Password = cinfo.PassWord;

                this.Svr = factory.CreateChannel();
                ((IDuplexContextChannel)this.Svr).AutomaticInputSessionShutdown = false;
                ((IDuplexContextChannel)this.Svr).OperationTimeout = TimeSpan.MaxValue;
                this.Svr.Connect(cinfo);
                return claims;
            } catch (Exception) {
                throw;
            }
        }
        #endregion

        #region "메세지 전송 함수군(StringMessageReceived)"
        /// <summary>
        /// 수신 Message Handler
        /// </summary>
        /// <param name="msg">수신메세지</param>
        /// <param name="recvtime">수신시점</param>
        public void StringMessageReceived(string msg, DateTime recvtime) {
        

        }
        #endregion

        /// <summary>
        /// ClientService Proxy
        /// </summary>
        public IClientService Svr { get; internal set; }
    }
}
