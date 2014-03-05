using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Com.Fadong.Adapter;
using Com.Fadong.CommonInterface;

namespace ZClient {
    public class ZServer {
        private ZServer() {
            this._svragent = new ServerAgent();
        }

        public static ZServer BE {
            get { return _instance;  }
        }

        public IClientService Svr {
            get;
            internal set;
        }

        public List<Claim> Claims {
            get { return _claims; }
        }

        public bool Connect(string id, string pw, bool isLocalhost) {
            this._claims = this._svragent.Connect(id, pw, isLocalhost);
            this.Svr = this._svragent.Svr;
            if (this._claims != null) {
                return true;
            } else {
                return false;
            }
        }

        private static ZServer _instance = new ZServer();
        private ServerAgent _svragent = null;
        List<Claim> _claims = new List<Claim>();
    }
}
