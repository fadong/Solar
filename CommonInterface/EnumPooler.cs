using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface {

    #region "INSTYPE(Instrument Type에 대한 Enumeration)"
    /// <summary>
    /// Instrument Type에 대한 Enumeration
    /// </summary>
    public enum INSTYPE {
        NONE = 0, 
        Stock = 1, 
        DR = 2, 
        EquityIndex = 3, 
        ETF = 4, 
        ForwardFuture = 5, 
        Option = 6, 
        Convertible = 7, 
        Warrant = 8, 
        EquitySwap = 9, 
        DepositLoan = 20, 
        Zero = 21, 
        Bond = 22, 
        RateIndex = 23, 
        Swap = 24, 
        FRN = 25, 
        Cap = 26, 
        Floor = 27, 
        Collar = 28, 
        FRA = 29, 
        Repo = 32, 
        StructrualBond = 33, 
        Cash = 40,
        NDF = 41, 
        FXOption = 43, 
        CurrSwap = 44, 
        Commoidty = 51, 
        CDS = 61, 
        CLN = 62, 
        MBSABS = 63, 
        Combination = 71, 
        TRS = 72, 
        ELS = 81, 
        DLS = 82, 
        Duet = 91, 
        CDFX = 92
    }
    #endregion

    #region "OJBECT_STATUS(ICommonObject를 구현하는 클래스의 상태에 대한 Enumeration)"
    /// <summary>
    /// ICommonObject를 구현하는 클래스의 상태에 대한 Enumeration
    /// </summary>
    public enum OBJECTSTATUS {
        None = 0,
        Created = 1,
        DBLoaded = 2,
        Updated = 3,
        Deleted = 4
    }
    #endregion
}
