using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;
using Com.Fadong.CommonLib.Instrument;
using ServiceStack.Text;

namespace Com.Fadong.Solar {
    public partial class ClientService {

        public bool SaveInstrument(string instrument) {
            try {
                FInstrument inst = JsonSerializer.DeserializeFromString<FInstrument>(instrument);

                Console.WriteLine(inst.ToString());

                return true;
            } catch (Exception err) {
                throw err.CreateFaultException("Instrument Save Failed!!");
            }
        }

    }
}
