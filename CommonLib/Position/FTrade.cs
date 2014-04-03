using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {

    [Serializable]
    public class FTrade : BObj, ITrade {
        public decimal Quantity { get; set; }
        public decimal TradePrice { get; set; }
        public IInstrumentObject Instrument { get; set; }
        public ICurrency Currency { get; set; }
        public IParty CounterParty { get; set; }
        public DateTime TradeTime { get; set; }
        public IEnum TradeType { get; set; }
        public IEnum TradeSTatus { get; set; }
        public IParty Acquirer { get; set; }
        public DateTime AcquireDay { get; set; }
        public IParty Broker { get; set; }
        public IUser SalesPerson { get; set; }
        public decimal InitMargin { get; set; }
        public decimal SalesMargin { get; set; }
        public decimal TradingMargin { get; set; }
        public decimal UpFrontFee { get; set; }
    }
}
