using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CommonInterface
{
    [Serializable]
    [DataContract]
    public class ClientInfo {
        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string Identifer { get; set; }

        [DataMember]
        public string IP { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public string PassWord { get; set; }

        [DataMember]
        public DateTime RequestTime { get; set; }

        [DataMember]
        public DateTime ConnectedTime { get; set; }

        [DataMember]
        public int Port { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string DomainName { get; set; }

        [DataMember]
        public string SysDir { get; set; }

        [DataMember]
        public string CurrDir { get; set; }

        [DataMember]
        public string OSVersion { get; set; }

        [DataMember]
        public int ProcessNum { get; set; }

        public override string ToString() {
            return string.Format("{0} [{1}]", UserId, IP);
        }
    }
}
