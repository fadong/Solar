using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    /// <summary>
    /// Book정보 기초 클래스
    /// Book은 Book을 담을 수 있는 CompoundBook과 실제 Trade를 담을 수 있는 RealBook으로 구분
    /// 추출된 TradeGroup은 CalcPnL을 통해 PnL 계산 결과가 산출
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-03-08)</remarks>
    public abstract class FBook : BObj, IBook {

        public string Name { get; set; }
        public string Description { get; set; }
        public ICurrency Currency { get; set; }
        public IParty Owner { get; set; }
        public IEnum BookType { get; set; }

        #region "public abstract List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp)"
        /// <summary>
        /// RealBook은 Trade를 Instrument별로 Grouping하여 TradeGroup을 추출하고 CompoundBook은 하부 Book으로 부터 TradeGroup를 추출
        /// </summary>
        /// <param name="fiscalday"></param>
        /// <param name="settleday"></param>
        /// <param name="tradestatus"></param>
        /// <returns></returns>
        public abstract List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp);
        #endregion

        #region "public List<IPnLCalculator> CalculatePnL(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp = true)"
        /// <summary>
        /// TradeGroup에 PnLMethod가 존재하는 이유는 Instrument Level에서 PnLMehtod를 결정할 수 있게 하기 위함임
        /// </summary>
        /// <param name="fiscalday"></param>
        /// <param name="settleday"></param>
        /// <param name="tradestatus"></param>
        /// <returns></returns>
        /// <remarks>Author : Jaekyoon,Lee (2014-03-08)</remarks>
        public virtual List<IPnLCalculator> CalculatePnL(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp = true) {
            List<IPnLCalculator> calcResult = new List<IPnLCalculator>();
            List<ITradeGroup> tgroups = TradeGroups(fiscalday, settleday, tradestatus, isMixUp);
            foreach (ITradeGroup tgroup in tgroups) {
                FPnLCalculator calculator = null;
                switch(tgroup.PnLMethod.Tag) {
                    case "OpenAverage":
                        calculator = new FPnLCalculatorOpenAvg(tgroup);
                        break;
                    case "OpenAverageLongShort":
                        calculator = new FPnLCalculatorOpenAvgLongShort(tgroup);
                        break;
                    case "FIFO":
                        calculator = new FPnLCalculatorFIFO(tgroup);
                        break;
                    case "LIFO":
                        calculator = new FPnLCalculatorLIFO(tgroup);
                        break;
                    default:
                        break;
                }
                calculator.Calculate();
            }
            return calcResult;
        }
        #endregion
    
    }
}
