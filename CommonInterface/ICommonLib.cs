using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterface;

namespace CommonInterface {
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
}
