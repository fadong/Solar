using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.Solar {
    public partial class ClientService {

        public bool SaveInstrument(XElement instrument) {
            try {
                Console.WriteLine(instrument);

                return true;
            } catch (Exception err) {
                throw err.CreateFaultException("Instrument Save Failed!!");
            }
        }

    }
}
