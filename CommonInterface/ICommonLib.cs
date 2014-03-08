using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonInterface {
    public interface ICommonObject {
        int Id { get; set; }


        DateTime CreatedTime { get; set; }
        DateTime UpdatedTime { get; set; }
        int CreateUserId { get; set; }
        int UpdateUserId { get; set; }
        OBJECTSTATUS Status { get; set; }
    }

    public interface IStaticInfoObject {


    }

    public interface ICurrency {



    }


    public interface IInstrumentObject : ICommonObject {
        string Name { get; set; }
        INSTYPE InsType { get; set; }



    }

    public interface ICFInstrumentObject : IInstrumentObject {


    }

    public interface IDerivInstrumentObject : IInstrumentObject {


    }

    public interface ICombiInstrumentObject : IInstrumentObject {


    }

    /// <summary>
    /// 
    /// </summary>
    public interface ILeg : ICommonObject {


    }

    /// <summary>
    /// 
    /// </summary>
    public interface IUser {
        string Name { get; set; }


    }

    /// <summary>
    /// 
    /// </summary>
    public interface IEnum {
        string Tag { get; }
        int Value { get; }
        string Description { get; }
        
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ITrade : ICommonObject {
        decimal Quantity { get; set; }
        decimal TradePrice { get; set; }
        ICurrency Currency { get; set; }
        IParty CounterParty { get; set; }
        DateTime TradeTime { get; set; }
        IEnum TradeType { get; set; }
        IEnum TradeSTatus { get; set; }
        IParty Acquirer { get; set; }
        DateTime AcquireDay { get; set; }
        IParty Broker { get; set; }
        IUser SalesPerson { get; set; }
        decimal InitMargin { get; set; }
        decimal SalesMargin { get; set; }
        decimal TradingMargin { get; set; }
        decimal UpFrontFee { get; set; }
    }

    public interface IParty : ICommonObject {
        string Name { get; set; }
        string Address { get; set; }
        IEnum PartyType { get; set; }
    }

    //public interface IDBPooler<T> : IEnumerable<T> where T : interface {
    //    bool Add(int key, T t);
    //    //bool AddOrUpdate(int key, T t);
    //    T Remove(int key);
    //}

    public interface IBook : ICommonObject {
        string Name { get; set; }
        string Description { get; set; }
        IParty Owner { get; set; }
        IEnum BookType { get; set; }
        ICurrency Currency { get; set; }
        List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp);
    }

    public interface ITradeGroup {
        IEnum PnLMethod { get; set; }

    }

    public interface IPnLCalculator {
        DateTime SettleDay { get; set; }
        DateTime FiscalDay { get; set; }
        decimal SettlePrice { get; set; }
        decimal FiscalPrice { get; set; }
        decimal Position { get; set; }
        decimal InitFaceValue { get; set; }
        decimal RedempFaceValue { get; set; }
        decimal FaceValue { get; set; }
        decimal PubValue { get; set; }
        decimal EValue { get; set; }
        decimal UnRealizedPnL { get; set; }
        decimal RealizedPnL { get; set; }
        decimal TotalPnL { get; set; }
        void Calculate();
    }

}
