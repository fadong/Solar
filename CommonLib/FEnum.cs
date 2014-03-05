using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonLib {
    [Serializable]
    public class FEnum {
        /// <summary>
        /// Enumeration의 Tag 정보
        /// </summary>
        public string Tag { get; internal set; }

        /// <summary>
        /// Enumeration의 Value 정보
        /// </summary>
        public int Value { get; internal set; }

        /// <summary>
        /// Enumeration의 설명
        /// </summary>
        public string Description { get; internal set; }
    }
}
