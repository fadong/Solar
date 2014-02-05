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
        STOCK = 1,
        STOCKRIGHT = 2,
        FUTURE_FORWARD = 3,
        OPTION = 4,
        WARRANT = 5,
        LEPO = 6,
        BOND = 7,
        FRN = 8,
        PROMISLOAN = 9,
        ZERO = 10,
        BILL = 11,
        CD = 12,
        DEPOSIT = 14,
        FRA = 15,
        SWAP = 16,
        CURRSWAP = 17,
        CAP = 18,
        FLOOR = 19,
        COLLAR = 20,
        CURR = 21,
        EQUITYINDEX = 22,
        BONDINDEX = 23,
        RATEINDEX = 24,
        CONVERTIBLE = 25,
        MULTIOPTION = 26,
        MULTIASSET = 27,
        COMBINATION = 28,
        FREEDEFCF = 29,
        FXSWAP = 30,
        COLLATERAL = 31,
        SECURITYLOAN = 32,
        REPO_REVERSE = 33,
        BUYSELLBACK = 34,
        PRICEINDEX = 35,
        INDEXLINKEDBOND = 36,
        TOTALRETURNSWAP = 37,
        CREDITDEFAULTSWAP = 38,
        //EQUITYSWAP = 39,   //미사용
        COMMODITY = 40,
        DUALCURRBOND = 41,
        MBS_ABS = 42,
        UNKNOWN = 43,
        CLN = 44,
        CALLACCOUNT = 45,
        CASHCOLLATERAL = 46,
        BASKETREPO_REVERSE = 47,
        CREDITINDEX = 48,
        INDEXLINKEDSWAP = 49,
        BASKETSECURITYLOAN = 50,
        CFD = 51,
        VARIANCESWAP = 52,
        FUND = 53,
        DEPOSITARY_RECEIPT = 54,
        FXOPTIONDATEDFWD = 55,
        PORTFOLIO_SWAP = 56,
        ETF = 57,
        ELS = 58
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
