﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    public class FTradeGroup : ITradeGroup {

        public FTradeGroup(List<ITrade> trades) {


        }

        public IEnum PnLMethod { get; set; }
    }
}
