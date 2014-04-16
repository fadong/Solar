using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonLib.Sys {
    public class UMngEnumTag : BObj {
        public UMngEnumTag(string entry, string tag, int value, string description, int order) {
            this.Entry = entry;
            this.Tag = tag;
            this.Value = value;
            this.Description = description;
            this.Order = order;
        }

        public string Entry {
            get;
            set;
        }

        public string Tag {
            get;
            set;
        }

        public int Value {
            get;
            set;
        }

        public string Description {
            get;
            set;
        }

        public int Order {
            get;
            set;
        }
    }
}
