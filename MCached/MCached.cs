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
    public class CachePool {

        private CachePool() {
            

        }

        public void CacheGen() {

            _dic.Add("NGOS_INSTRUMENT", new GCacheDB());
            _dic.Add("NGOS_LEG", new GCacheDB());
            _dic.Add("NGOS_CASHFLOW", new GCacheDB());
            _dic.Add("NGOS_RESET", new GCacheDB());
            _dic.Add("NGOS_ADDINFO", new GCacheDB());
            _dic.Add("NGOS_ADDINFOSPEC", new GCacheDB());

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
                    default:
                        break;
                }

                Thread t = new Thread(ts);
                t.Start();
            }


 







            

            //GCache<NGOS_INSTRUMENT> gcache = new GCache<NGOS_INSTRUMENT>();
            //ThreadStart ts = new ThreadStart(gcache.LoadDB);
            //Thread t = new Thread(ts);
            //t.Start();

            //GCache<NGOS_ADDINFO> gcacheA = new GCache<NGOS_ADDINFO>();
            //ThreadStart ts = new ThreadStart(gcacheA.LoadDB);
            //Thread t = new Thread(ts);
            //t.Start();
        }

        public static CachePool BE {
            get { return _instance; }
        }

        private static CachePool _instance = new CachePool();
        private static Dictionary<string, GCacheDB> _dic = new Dictionary<string, GCacheDB>();
    }
}
