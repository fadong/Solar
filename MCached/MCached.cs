using Com.Fadong.CommonInterface;
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
using Oracle.ManagedDataAccess.Client;
using Com.Fadong.CommonInterface.Poco;

namespace Com.Fadong.MCached {

    /// <summary>
    ///
    /// </summary>
    public class DBCachePool {

        /// <summary></summary>
        private DBCachePool() {
            Context = new Entities();
            CacheInit();
        }

        #region "public void CacheInit()"
        /// <summary>
        ///
        /// </summary>
        public void CacheInit() {
            //TODO -Table Caching 로직 필요

            MenuMaster mmaster = new MenuMaster();
            _dic.Add("MkEnum", new GCacheMkEnums(this.Context));
            _dic.Add("MenuMaster", new GCacheDB<MenuMaster>(this.Context));

            List<Thread> threads = new List<Thread>();
            foreach (KeyValuePair<string, object> v in _dic) {
                ThreadStart ts = null;
                switch (v.Key) {
                    case "MkEnum":
                        ts = new ThreadStart(((GCacheMkEnums)v.Value).LoadDB);
                        break;
                    case "MenuMaster":
                        ts = new ThreadStart(((GCacheDB<MenuMaster>)v.Value).LoadDB);
                        break;
                    default:
                        break;

                }
                if (ts != null) {
                    Thread t = new Thread(ts);
                    t.Start();
                    threads.Add(t);
                    Logger.Info(this, v.Key + "Loading");
                }
                foreach (Thread t in threads) {
                    t.Join();
                }
                Logger.Info(this, _dic.Count + "개 Table Loading Completed!!");
            }

            //_dic.Add("D_ADDINFO", new GCacheDB());
            //_dic.Add("D_ADDINFOSPEC", new GCacheDB());

            //_dic.Add("D_INSTRUMENT", new GCacheDB());
            //_dic.Add("D_LEG", new GCacheDB());
            //_dic.Add("NGOS_CASHFLOW", new GCacheDB());
            //_dic.Add("NGOS_RESET", new GCacheDB());

            //_dic.Add("NGOS_EXOTICEVENT", new GCacheDB());
            //_dic.Add("NGOS_PORTFOLIO", new GCacheDB());
            //_dic.Add("NGOS_PARTY", new GCacheDB());

            //List<Thread> tlist = new List<Thread>();
            //foreach(KeyValuePair<string, GCacheDB> v in _dic) {
            //    ThreadStart ts = null;
            //    GCacheDB gcdb = v.Value;
            //    switch(v.Key) {
            //        case "D_INSTRUMENT":
            //            ts = new ThreadStart(v.Value.Load<D_INSTRUMENT>);
            //            break;
            //        case "D_LEG":
            //            ts = new ThreadStart(v.Value.Load<D_LEG>);
            //            break;
            //        case "D_CASHFLOW":
            //            ts = new ThreadStart(v.Value.Load<D_CASHFLOW>);
            //            break;
            //        case "D_RESET":
            //            ts = new ThreadStart(v.Value.Load<D_RESET>);
            //            break;
            //        case "D_ADDINFO":
            //            ts = new ThreadStart(v.Value.Load<D_ADDINFO>);
            //            break;
            //        case "D_ADDINFOSPEC":
            //            ts = new ThreadStart(v.Value.Load<D_ADDINFOSPEC>);
            //            break;
            //        //case "NGOS_EXOTICEVENT":
            //        //    ts = new ThreadStart(v.Value.Load<NGOS_EXOTICEVENT>);
            //        //    break;
            //        //case "NGOS_PORTFOLIO":
            //        //    ts = new ThreadStart(v.Value.Load<D_PORTFOLIO>);
            //        //    break;
            //        //case "NGOS_PARTY":
            //        //    ts = new ThreadStart(v.Value.Load<NGOS_PARTY>);
            //        //    break;
            //        default:
            //            break;
            //    }
            //    if(ts != null) {
            //        Thread t = new Thread(ts);
            //        t.Start();
            //        tlist.Add(t);
            //        Logger.Info(this, v.Key + "Loading");
            //    }
            //}

            //foreach(Thread t in tlist) {
            //    t.Join();
            //}
        }
        #endregion

        #region "public GCacheDB<TEntity> GetTEntity<TEntity>(string key) where TEntity : class"
        /// <summary>
        ///
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public GCacheDB<TEntity> GetTEntity<TEntity>(string key) where TEntity : class {
            try {
                return (GCacheDB<TEntity>)_dic[key];
            }
            catch(Exception err) {
                Logger.Error(this, err.Message);
                throw err;
            }

        }
        #endregion

        #region "public void Dispose()"
        /// <summary>
        /// 
        /// </summary>
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region "protected virtual void Dispose(bool disposing)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                if (this.Context != null) {
                    this.Context.Dispose();
                }
            }
        }
        #endregion

        #region "public Entities Context"
        /// <summary>
        /// 
        /// </summary>
        public Entities Context {
            get;
            internal set;
        }
        #endregion

        #region "public static DBCachePool BE"
        /// <summary>
        ///
        /// </summary>
        public static DBCachePool BE {
            get { return _instance; }
        }
        #endregion

        private static Dictionary<string, object> _dic = new Dictionary<string, object>();
        private static DBCachePool _instance = new DBCachePool();
    }
}