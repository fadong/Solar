using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib.Sys {
    public class UMngEnum : IEnumerable<UMngEnumTag> {
        public UMngEnum(List<UMngEnumTag> enumTag) {
            this._list = enumTag;
        }

        #region "public IEnumerator<T> GetEnumerator()"
        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns>IEnuerable<typeparamref name=">"/></returns>
        public IEnumerator<UMngEnumTag> GetEnumerator() {
            return _list.GetEnumerator();
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

        private List<UMngEnumTag> _list = new List<UMngEnumTag>();
    }
}
