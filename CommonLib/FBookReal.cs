using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    /// <summary>
    /// 실제 Trade를 담는 ReadBook
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-03-08)</remarks>
    public class FBookReal : FBook, IEnumerable<ITrade> {


        public override List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp = false) {
            List<ITradeGroup> tg = new List<ITradeGroup>();
            

            return tg;
        }

        public IEnumerator GetEnumerator() {
            return this._trades.GetEnumerator();
        }

        IEnumerator<ITrade> IEnumerable<ITrade>.GetEnumerator() {
            return this._trades.Values.GetEnumerator();
        }

        private Dictionary<int, ITrade> _trades = new Dictionary<int, ITrade>();
    }
}
