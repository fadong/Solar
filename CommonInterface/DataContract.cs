using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Com.Fadong.CommonInterface {

    #region "ClientInfo"

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class ClientInfo {
        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string Identifier { get; set; }

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
    #endregion

    //[Serializable]
    //[DataContract]
    //public class DCInstrument {
    //    [DataMember]
    //    public int Id { get; set; }

    //    [DataMember]
    //    public string Name { get; set; }

    //    [DataMember]
    //    public INSTYPE InsType { get; set; }

    //    [DataMember]
    //    public string ISIN { get; set; }

    //    [DataMember]
    //    public string Extn_ID1 { get; set; }

    //    [DataMember]
    //    public string Extn_ID2 { get; set; }

    //    [DataMember]
    //    public DateTime IssueDay { get; set; }

    //    [DataMember]
    //    public DateTime StartDay { get; set; }

    //    [DataMember]
    //    public DateTime EndDay { get; set; }

    //    [DataMember]
    //    public int ExPeriodCount { get; set; }

    //    //[DataMember]
    //    //public PERIODUNIT ExPeriodUnit { get; set; }

    //    [DataMember]
    //    public int Currency { get; set; }

    //    [DataMember]
    //    public bool Callable { get; set; }

    //    [DataMember]
    //    public bool Putable { get; set; }

    //    [DataMember]
    //    public bool IsOTC { get; set; }

    //    [DataMember]
    //    public bool IsGeneric { get; set; }

    //    [DataMember]
    //    public int Categ_ID1 { get; set; }

    //    [DataMember]
    //    public int Categ_ID2 { get; set; }

    //    [DataMember]
    //    public decimal ContrSize { get; set; }
    //}
}
