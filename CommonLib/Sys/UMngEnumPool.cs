using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonLib.Sys {
    public class UMngEnumPool : IEnumerable<UMngEnum> {

        private UMngEnumPool() {
            


        }

        #region "public IEnumerator<T> GetEnumerator()"
        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns>IEnuerable<typeparamref name=">"/></returns>
        public IEnumerator<UMngEnum> GetEnumerator() {
            return _dic.Values.GetEnumerator();
        }
        #endregion

        #region "IEnumerator IEnumerable.GetEnumerator()"
        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        #endregion

        public static UMngEnumPool BE {
            get { return _instance;  }
        }

        public Dictionary<string, UMngEnum> _dic = new Dictionary<string, UMngEnum>();
        private static UMngEnumPool _instance = new UMngEnumPool();
        
    }
}
