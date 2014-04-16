using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface.Poco;

namespace Com.Fadong.MCached {
    public class GCacheMkEnums : GCacheDB<MkEnum> {

        public GCacheMkEnums(DbContext ctx) : base(ctx) {

        }

        #region "public override void LoadDB()"
        /// <summary>
        /// 
        /// </summary>
        public override void LoadDB() {
            base.LoadDB();
            this._enumdic = base.Entities.GroupBy(k => k.Entry).ToDictionary(k => k.Key, k => new MkEnums(k.ToList()));
        }
        #endregion

        #region "public MkEnums this[string entry]"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public MkEnums this[string entry] {
            get {
                if (_enumdic.ContainsKey(entry)) {
                    return _enumdic[entry];
                } else {
                    throw new Exception(entry + "에 해당되는 Enum 정보가 없음");
                }
            }
        }
        #endregion

        private Dictionary<string, MkEnums> _enumdic = new Dictionary<string, MkEnums>();
    }
}
