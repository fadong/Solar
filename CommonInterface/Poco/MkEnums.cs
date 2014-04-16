using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonInterface.Poco {
    public class MkEnums {
        public MkEnums(List<MkEnum> enumlist) {
            this._vdic = enumlist.ToDictionary(k => k.Value, k => k);
            this._tdic = enumlist.ToDictionary(k => k.Tag, k => k);
        }

        public MkEnum this[int value] {
            get {
                if (this._vdic.ContainsKey(value)) {
                    return this._vdic[value];
                } else {
                    if (this._vdic.ContainsKey(0)) {
                        return this._vdic[0];
                    } else {
                        throw new Exception("Enum이 비정상적으로 설정(None Value가 없음)");
                    }
                }
            }
        }

        public MkEnum this[string tag] {
            get {
                if (this._tdic.ContainsKey(tag)) {
                    return this._tdic[tag];
                } else {
                    if (this._tdic.ContainsKey("None")) {
                        return this._tdic["None"];
                    } else {
                        throw new Exception("Enum이 비정상적으로 설정(None Value가 없음)");
                    }
                }
            }
        }

        public List<MkEnum> EnumList {
            get { return this._vdic.Values.ToList(); }
        }

        private Dictionary<int, MkEnum> _vdic = new Dictionary<int, MkEnum>();
        private Dictionary<string, MkEnum> _tdic = new Dictionary<string, MkEnum>();
    }
}
