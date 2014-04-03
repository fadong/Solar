using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    public class FPnLCalculatorFIFO : FPnLCalculator {
        public FPnLCalculatorFIFO(ITradeGroup tradegroup) 
            : base(tradegroup) {
        
        }

        public override void Calculate() {

        }
    }
}
