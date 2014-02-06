using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects.DataClasses;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Threading;
using System.Diagnostics;
using CommonInterface;

namespace MCached {
    public class DBCachePool {

        private DBCachePool() {
            CacheInit();
        }

        public void CacheInit() {
            _dic.Add("NGOS_INSTRUMENT", new GCacheDB());
            _dic.Add("NGOS_LEG", new GCacheDB());
            _dic.Add("NGOS_CASHFLOW", new GCacheDB());
            _dic.Add("NGOS_RESET", new GCacheDB());
            _dic.Add("NGOS_ADDINFO", new GCacheDB());
            _dic.Add("NGOS_ADDINFOSPEC", new GCacheDB());
            _dic.Add("NGOS_EXOTICEVENT", new GCacheDB());
            _dic.Add("NGOS_PORTFOLIO", new GCacheDB());
            _dic.Add("NGOS_PARTY", new GCacheDB());

            List<Thread> tlist = new List<Thread>();
            foreach(KeyValuePair<string, GCacheDB> v in _dic) {

                ThreadStart ts = null;
                GCacheDB gcdb = v.Value;
                switch(v.Key) {
                    case "NGOS_INSTRUMENT":
                        ts = new ThreadStart(gcdb.Load<NGOS_INSTRUMENT>);
                        break;
                    case "NGOS_LEG":
                        ts = new ThreadStart(v.Value.Load<NGOS_LEG>);
                        break;
                    case "NGOS_CASHFLOW":
                        ts = new ThreadStart(v.Value.Load<NGOS_CASHFLOW>);
                        break;
                    case "NGOS_RESET":
                        ts = new ThreadStart(v.Value.Load<NGOS_RESET>);
                        break;
                    case "NGOS_ADDINFO":
                        ts = new ThreadStart(v.Value.Load<NGOS_ADDINFO>);
                        break;
                    case "NGOS_ADDINFOSPEC":
                        ts = new ThreadStart(v.Value.Load<NGOS_ADDINFOSPEC>);
                        break;
                    case "NGOS_EXOTICEVENT":
                        ts = new ThreadStart(v.Value.Load<NGOS_EXOTICEVENT>);
                        break;
                    case "NGOS_PORTFOLIO":
                        ts = new ThreadStart(v.Value.Load<NGOS_PORTFOLIO>);
                        break;
                    case "NGOS_PARTY":
                        ts = new ThreadStart(v.Value.Load<NGOS_PARTY>);
                        break;
                    default:
                        break;
                }
                if(ts != null) {
                    Thread t = new Thread(ts);
                    t.Start();
                    tlist.Add(t);
                }
            }

            foreach(Thread t in tlist) {
                t.Join();
            }
        }

        

        public GCacheDB this[string tablename] {
            get {
                GCacheDB gcacdb = null;
                if(_dic.ContainsKey(tablename)) {
                    gcacdb = _dic[tablename];
                }
                return gcacdb;
            }
        }

        public static DBCachePool BE {
            get { return _instance; }
        }

        private static Dictionary<string, GCacheDB> _dic = new Dictionary<string, GCacheDB>();
        private static DBCachePool _instance = new DBCachePool();
        
    }
}
