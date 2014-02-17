using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Adapter4Server;
using CommonInterface;

namespace ZClient {
    public class ZServer {
        private ZServer() {
            this._agent = new Agent();
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
            try {
                this._claims = this._agent.Connect(id, pw, isLocalhost);
                this.Svr = this._agent.Svr;
                return true;
            } catch (Exception err) {
                Logger.Info(this, "Connection Failed [" + err.Message + "]");
                return false;
            }
        }

        private static ZServer _instance = new ZServer();
        private Agent _agent = null;
        List<Claim> _claims = new List<Claim>();
    }
}
