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
using CommonInterface;
using CommonLib;

namespace Adapter4Server {
    public class Agent : IClientCB {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pw"></param>
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
        /// 
        /// </summary>
        /// <param name="cinfo"></param>
        /// <param name="isLocalhost"></param>
        /// <returns></returns>
        private List<Claim> RemoteConnect(ClientInfo cinfo, bool isLocalhost) {
            try {
                List<Claim> claims = new List<Claim>();
                InstanceContext context = new InstanceContext(this);
                var serviceName = "EP_ClientServiceLocal";
                var factory = new DuplexChannelFactory<IClientService>(context, serviceName);
                factory.Credentials.UserName.UserName = cinfo.UserId;
                factory.Credentials.UserName.Password = cinfo.PassWord;

                IClientService proxy = factory.CreateChannel();
                ((IDuplexContextChannel)proxy).AutomaticInputSessionShutdown = false;
                ((IDuplexContextChannel)proxy).OperationTimeout = TimeSpan.MaxValue;
                return claims;
            } catch (Exception) {
                throw;
            }
        }

        public void StringMessageReceived(string msg, DateTime recvtime) {
        

        }
    }
}
