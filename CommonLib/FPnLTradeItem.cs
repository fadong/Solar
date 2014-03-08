using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    public class FPnLTradeItem {
        public int Order { get; set; }
        public decimal BookPrice { get; set; }
        public decimal BookValue { get; set; }
        public decimal ChgBookValue { get; set; }
        public decimal Position { get; set; }
        public decimal RealizedPnL { get; set; }
        public ITrade Trade { get; set; }
    }
}
