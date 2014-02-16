using CommonInterface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCached {

    /// <summary>
    ///
    /// </summary>
    public class DBCachePool {

        /// <summary></summary>
        private DBCachePool() {
            CacheInit();
        }

        /// <summary>
        ///
        /// </summary>
        public void CacheInit() {
            //TODO -Table Caching 로직 필요
            _dic.Add("D_ADDINFO", new GCacheDB());
            _dic.Add("D_ADDINFOSPEC", new GCacheDB());

            _dic.Add("D_INSTRUMENT", new GCacheDB());
            _dic.Add("D_LEG", new GCacheDB());
            //_dic.Add("NGOS_CASHFLOW", new GCacheDB());
            //_dic.Add("NGOS_RESET", new GCacheDB());

            //_dic.Add("NGOS_EXOTICEVENT", new GCacheDB());
            //_dic.Add("NGOS_PORTFOLIO", new GCacheDB());
            //_dic.Add("NGOS_PARTY", new GCacheDB());

            List<Thread> tlist = new List<Thread>();
            foreach(KeyValuePair<string, GCacheDB> v in _dic) {
                ThreadStart ts = null;
                GCacheDB gcdb = v.Value;
                switch(v.Key) {
                    case "NGOS_INSTRUMENT":
                        ts = new ThreadStart(gcdb.Load<D_INSTRUMENT>);
                        break;

                    case "NGOS_LEG":
                        ts = new ThreadStart(v.Value.Load<D_LEG>);
                        break;

                    case "NGOS_CASHFLOW":
                        ts = new ThreadStart(v.Value.Load<D_CASHFLOW>);
                        break;

                    case "NGOS_RESET":
                        ts = new ThreadStart(v.Value.Load<D_RESET>);
                        break;

                    case "NGOS_ADDINFO":
                        ts = new ThreadStart(v.Value.Load<D_ADDINFO>);
                        break;

                    case "NGOS_ADDINFOSPEC":
                        ts = new ThreadStart(v.Value.Load<D_ADDINFOSPEC>);
                        break;
                    //case "NGOS_EXOTICEVENT":
                    //    ts = new ThreadStart(v.Value.Load<NGOS_EXOTICEVENT>);
                    //    break;
                    //case "NGOS_PORTFOLIO":
                    //    ts = new ThreadStart(v.Value.Load<D_PORTFOLIO>);
                    //    break;
                    //case "NGOS_PARTY":
                    //    ts = new ThreadStart(v.Value.Load<NGOS_PARTY>);
                    //    break;
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public GCacheDB this[string tablename] {
            get {
                GCacheDB gcacdb = null;
                if (_dic.ContainsKey(tablename)) {
                    gcacdb = _dic[tablename];
                }
                return gcacdb;
            }
        }

        /// <summary>
        ///
        /// </summary>
        public static DBCachePool BE {
            get { return _instance; }
        }

        private static Dictionary<string, GCacheDB> _dic = new Dictionary<string, GCacheDB>();
        private static DBCachePool _instance = new DBCachePool();
    }
}