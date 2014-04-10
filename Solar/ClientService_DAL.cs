using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

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
                list.Add(new Tuple<int, string>(1, "test1"));
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

        #region "public List<XElement> GetInstruments(List<int> instlist)"
        public List<XElement> GetInstruments(List<int> instlist) {
            try {
                List<XElement> list = new List<XElement>();
                for (int i = 0; i < 10; i++) {
                    XElement xout = new XElement("Root");
                    xout.Add(new XElement("afafa"));
                    list.Add(xout);
                }
                return list;
            } catch (Exception err) {
                throw err.CreateFaultException("GetIntruments Return Failed!!");
            }
        }
        #endregion
    }
}
