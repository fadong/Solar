using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonInterface {

    #region "public interface ICommonObject"
    /// <summary>
    /// 
    /// </summary>
    public interface ICommonObject {
        int Id { get; set; }
        DateTime CreatedTime { get; set; }
        DateTime UpdatedTime { get; set; }
        int CreateUserId { get; set; }
        int UpdateUserId { get; set; }
        OBJECTSTATUS ObjectStatus { get; set; }
    }
    #endregion

    #region "public interface IStaticInfoObject"
    /// <summary>
    /// StaticData를 담기 위한 기초 Interface
    /// </summary>
    public interface IStaticInfoObject {

    }
    #endregion

    #region "public interface ICurrency (지속변경 예정)"
    /// <summary>
    /// Currency는 Instrument이지만 PnL산출 등에 대한 영향도를 고려하여 별도 관리함
    /// </summary>
    public interface ICurrency {

    }
    #endregion

    #region "public interface IInstrumentObject : ICommonObject"
    /// <summary>
    /// 
    /// </summary>
    public interface IInstrumentObject : ICommonObject {
        string Name { get; set; }
        INSTYPE InsType { get; set; }
    }
    #endregion

    #region "public interface ICFInstrumentObject : IInstrumentObject"
    /// <summary>
    /// 
    /// </summary>
    public interface ICFInstrumentObject : IInstrumentObject {

    }
    #endregion

    #region "public interface IDerivInstrumentObject : IInstrumentObject"
    /// <summary>
    /// 
    /// </summary>
    public interface IDerivInstrumentObject : IInstrumentObject {

    }
    #endregion

    #region "public interface ICombiInstrumentObject : IInstrumentObject"
    /// <summary>
    /// 
    /// </summary>
    public interface ICombiInstrumentObject : IInstrumentObject {

    }
    #endregion

    #region "public interface ILeg : ICommonObject"
    /// <summary>
    /// 
    /// </summary>
    public interface ILeg : ICommonObject {


    }
    #endregion

    #region "public interface IUser (지속 변경 예정)"
    /// <summary>
    /// 사용자정보, 사용자별 Permission 정보 등을 담는 Container
    /// </summary>
    public interface IUser {
        string Name { get; set; }

    }
    #endregion

    #region "public interface IEnum"
    /// <summary>
    /// 
    /// </summary>
    public interface IEnum {
        string EnumStr { get; }
        string Tag { get; }
        int Value { get; }
        string Description { get; }
        
    }
    #endregion

    #region "public interface ITrade : ICommonObject"
    /// <summary>
    /// 
    /// </summary>
    public interface ITrade : ICommonObject {
        decimal Quantity { get; set; }
        decimal TradePrice { get; set; }
        IInstrumentObject Instrument { get; set; }
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
    #endregion

    #region "public interface IParty : ICommonObject (지속변경 예정)"
    /// <summary>
    /// Party 구성을 위한 Interface (지속변경 예정)
    /// ConunterParty, InternalDept 같은 경우는 Concrete Class에서 구현예정
    /// </summary>
    public interface IParty : ICommonObject {
        string Name { get; set; }
        string Address { get; set; }
        IEnum PartyType { get; set; }
    }
    #endregion

    #region "public interface IBook : ICommonObject (지속변경 예정)"
    /// <summary>
    /// Book(기존 Portfolio) 구성을 위한 Interface (지속변경 예정)
    /// </summary>
    public interface IBook : ICommonObject {
        string Name { get; set; }
        string Description { get; set; }
        IParty Owner { get; set; }
        IEnum BookType { get; set; }
        ICurrency Currency { get; set; }
        List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp);
    }
    #endregion

    #region "public interface ITradeGroup (지속변경 예정)"
    /// <summary>
    /// TradeGroup 구성을 위한 Interface(지속 변경예정)
    /// </summary>
    public interface ITradeGroup {
        IEnum PnLMethod { get; set; }
    }
    #endregion

    #region "public interface IPnLCalculator"
    /// <summary>
    /// PnLCalculator를 구성을 위한 Interface
    /// </summary>
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
    #endregion

}
