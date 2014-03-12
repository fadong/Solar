using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;
using System.Xml.Linq;

namespace Com.Fadong.CommonInterface {
    [ServiceContract(CallbackContract = typeof(IClientCB),
                      SessionMode=SessionMode.Required)]
    public interface IClientService {

        [OperationContract]
        List<Claim> Connect(ClientInfo cinfo);

        [OperationContract]
        List<IInstrumentObject> GetInstruments(List<int> instlist);

        [OperationContract]
        List<Tuple<int, string>> GetInstrumentKeyValues();

        [OperationContract]
        bool SaveInstrument(XElement instrument);
    }

    public interface IClientCB {
        [OperationContract(IsOneWay = true)]
        void StringMessageReceived(string msg, DateTime time);
    }
}
