using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {

    public class FInstrumentStock : FInstrument {
        public FInstrumentStock() {
            this.InsType = INSTYPE.Stock;
            this.CreatedTime = DateTime.Now;
            this.UpdatedTime = DateTime.Now;
            this.ObjectStatus = OBJECTSTATUS.Created;
        }




    }
}
