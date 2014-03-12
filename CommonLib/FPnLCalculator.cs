using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {

    /// <summary>
    /// PnL 계산 클래스 및 결과 저장 클래스
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-03-08)</remarks>
    public abstract class FPnLCalculator : IPnLCalculator {
        public FPnLCalculator(ITradeGroup tgroup) {
            this.TradeGroup = tgroup;
        }

        public DateTime SettleDay { get; set; }
        public DateTime FiscalDay { get; set; }
        public decimal SettlePrice { get; set; }
        public decimal FiscalPrice { get; set; }
        public decimal Position { get; set; }
        public decimal InitFaceValue { get; set; }
        public decimal RedempFaceValue { get; set; }
        public decimal FaceValue { get; set; }
        public decimal PubValue { get; set; }
        public decimal PubPrice { get; set; }
        public decimal BookPrice { get; set; }
        public decimal BookValue { get; set; }
        public decimal EValue { get; set; }
        public decimal UnRealizedPnL { get; set; }
        public decimal RealizedPnL { get; set; }
        public decimal TotalPnL { get; set; }
        public decimal FirstPnLTradeItem { get; set; }
        public ITradeGroup TradeGroup { get; internal set; }
        public List<FPnLTradeItem> TradeItems {
            get { return this._tradeitems; }
        }

        public abstract void Calculate();
        List<FPnLTradeItem> _tradeitems = new List<FPnLTradeItem>();
    }
}
