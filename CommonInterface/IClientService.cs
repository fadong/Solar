using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;

namespace CommonInterface {
    [ServiceContract(CallbackContract=typeof(IClientServiceCallback),
                      SessionMode=SessionMode.Required)]
    public interface IClientService {

        [OperationContract]
        List<Claim> Connect(ClientInfo cinfo);

    }

    public interface IClientServiceCallback {


    }
}
