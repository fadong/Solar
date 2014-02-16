using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Diagnostics;
using CommonInterface;


namespace MCached {
    ///<summary>
    /// Object을 Caching하기 위한 Class
    /// Object Loading시 Load사용
    ///</summary>
    ///<remarks>Author : Jaekyoon,Lee (2014-02-05)</remarks>
    public abstract class GCache<T> : IEnumerable<T> where T : class {

        /// <summary>
        /// Caching된 Object를 담아두는 ConcurrentDictionary
        /// </summary>
        private ConcurrentDictionary<int, T> _dic = new ConcurrentDictionary<int, T>();

        /// <summary>
        /// EntityObject Add
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="t">대상 Object</param>
        /// <returns>성공여부(bool)</returns>
        public bool Add(int key, T t) {
            return _dic.TryAdd(key, t);
        }

        /// <summary>
        /// Dictionary의 총갯수(Caching Size)
        /// </summary>
        /// <returns>총갯수</returns>
        public int Count() {
            return this._dic.Count;
        }

        /// <summary>
        /// EntityObject Get
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Key에 해당되는 Object (대상없는 경우 null)</returns>
        public T Get(int key) {
            T cls = null;
            _dic.TryGetValue(key, out cls);
            return cls;
        }

        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns>IEnuerable<typeparamref name=">"/></returns>
        public IEnumerator<T> GetEnumerator() {
            return _dic.Values.GetEnumerator();
        }

        /// <summary>
        /// GetEnumerator 구현
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        /// <summary>
        ///  Data Loading에 관련된 Abstraction Method
        /// </summary>
        /// <typeparam name="Ts"></typeparam>
        public abstract void Load<Ts>() where Ts : class;

        /// <summary>
        /// Object Remove
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>삭제대상 </returns>
        public T Remove(int key) {
            T cls = null;
            _dic.TryRemove(key, out cls);
            return cls;
        }
    }
}
