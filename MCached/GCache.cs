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
    /// EntityObject을 Caching하기 위한 Class
    /// EntityObject Loading시 LoadDB사용
    ///</summary>
    ///<remarks>Author : Jaekyoon,Lee (2014-02-05)</remarks>
    public abstract class GCache<T> : IEnumerable<T> where T : class {

        public bool Add(int key, T t) {
            return _dic.TryAdd(key, t);
        }

        public T Remove(int key) {
            T cls = null;
            _dic.TryRemove(key, out cls);
            return cls;
        }

        public T Get(int key) {
            T cls = null;
            _dic.TryGetValue(key, out cls);
            return cls;
        }

        public abstract void Load<Ts>() where Ts : class;

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator() {
            return _dic.Values.GetEnumerator();
        }

        private ConcurrentDictionary<int, T> _dic = new ConcurrentDictionary<int, T>();
    }
}
