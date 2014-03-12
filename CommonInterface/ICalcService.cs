using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Xml.Linq;

namespace Com.Fadong.CommonInterface {

    [ServiceContract(CallbackContract = typeof(INodeCB),
                      SessionMode = SessionMode.Required)]
    public interface ICalcService {

        [OperationContract]
        XElement Connect(ClientInfo cinfo);
    }

    public interface INodeCB {
        [OperationContract(IsOneWay = true)]
        void StringMessageReceived(string msg, DateTime time);
    }
}
