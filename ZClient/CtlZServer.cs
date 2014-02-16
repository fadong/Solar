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
            this.Svr = new Agent();
        }

        public static ZServer BE {
            get { return _instance;  }
        }

        public Agent Svr {
            get;
            internal set;
        }

        public List<Claim> Claims {
            get { return _claims; }
        }

        public bool Connect(string id, string pw, bool isLocalhost) {
            try {
                this._claims = Svr.Connect(id, pw, isLocalhost);
                return true;
            } catch (Exception err) {
                Logger.Info(this, "Connection Failed [" + err.Message + "]");
                return false;
            }
        }

        private static ZServer _instance = new ZServer();
        List<Claim> _claims = new List<Claim>();
    }
}
