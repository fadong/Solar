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
    public partial class ClientService : IClientService, IDisposable {

        #region "public List<Tuple<int, string>> GetInstrumentKeyValues()"
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Tuple<int, string>> GetInstrumentKeyValues() {
            try {
                List<Tuple<int, string>> list = new List<Tuple<int, string>>();
                for (int i = 0; i < 5000; i++) {
                    list.Add(new Tuple<int, string>(i, "test_" + i.ToString()));
                }
                return list;
            } catch (Exception err) {
                throw err.CreateFaultException("GetInstrumentKeyValues Return Failed!!");
            }
        }
        #endregion

        #region "public Dictionary<INSTYPE, Tuple<int, string>> GetInstrumentKeyValuesByInsType()"
        public Dictionary<INSTYPE, Tuple<int, string>> GetInstrumentKeyValuesByInsType() {
            try {
                Dictionary<INSTYPE, Tuple<int, string>> list = new Dictionary<INSTYPE, Tuple<int, string>>();

                return list;
            } catch (Exception err) {
                throw err.CreateFaultException("GetInstrumentKeyValuesByInsType Return Failed!!");
            }
        }
        #endregion

        #region "public List<string> GetInstruments(List<int> instlist)"
        public List<string> GetInstruments(List<int> instlist) {
            try {
                List<string> list = new List<string>();
                for(int i = 0; i < 10000; i++) {
                    FInstrument inst = new FInstrument();
                    inst.Id = i;
                    inst.Name = i.ToString() + "번째 ELS";
                    inst.ObjectStatus = OBJECTSTATUS.DBLoaded;
                    inst.InsType = INSTYPE.Stock;
                    list.Add(JsonSerializer.SerializeToString<FInstrument>(inst));
                }
                return list;
            } catch (Exception err) {
                throw err.CreateFaultException("GetIntruments Return Failed!!");
            }
        }
        #endregion

        
    }
}
