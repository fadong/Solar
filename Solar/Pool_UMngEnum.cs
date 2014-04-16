//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Com.Fadong.CommonLib.Sys;
//using Com.Fadong.MCached;
//using Com.Fadong.CommonInterface.Poco;

//namespace Com.Fadong.Solar {
//    public class Pool_UMngEnum : IEnumerable<UMngEnum> {

//        private Pool_UMngEnum() {
//            GCacheDB<MkEnum> mkenum = DBCachePool.BE.GetTEntity<MkEnum>("MkEnum");
//            foreach (IGrouping<string, MkEnum> v in mkenum.GroupBy(k => k.Entry)) {
//                var entry = v.Select(k => new UMngEnumTag(k.Entry, k.Tag, k.Value, k.Description, (k.Order.HasValue ? k.Order.Value : 0))).ToList();
//                this._dic.Add(v.Key, new UMngEnum(entry));
//            }
//        }

//        #region "public IEnumerator<T> GetEnumerator()"
//        /// <summary>
//        /// GetEnumerator 구현
//        /// </summary>
//        /// <returns>IEnuerable<typeparamref name=">"/></returns>
//        public IEnumerator<UMngEnum> GetEnumerator() {
//            return _dic.Values.GetEnumerator();
//        }
//        #endregion

//        #region "IEnumerator IEnumerable.GetEnumerator()"
//        /// <summary>
//        /// GetEnumerator 구현
//        /// </summary>
//        /// <returns></returns>
//        IEnumerator IEnumerable.GetEnumerator() {
//            return GetEnumerator();
//        }
//        #endregion

//        public static Pool_UMngEnum BE {
//            get { return _instance; }
//        }

//        public Dictionary<string, UMngEnum> _dic = new Dictionary<string, UMngEnum>();
//        private static Pool_UMngEnum _instance = new Pool_UMngEnum();

//    }
//}
