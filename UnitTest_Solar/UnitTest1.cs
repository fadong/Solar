using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Claims;
using Com.Fadong.Adapter;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace UnitTest_Solar {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void TestMethod_GetInstruments() {
            IClientService proxy = ConnectSolar();
            Assert.IsNotNull(proxy);
            //List<Tuple<int, string>> kv = proxy.GetInstrumentKeyValues();
            //Assert.IsTrue(kv.Count > 0);
        }

        [TestMethod]
        private IClientService ConnectSolar() {
            ServerAgent agent = new ServerAgent();
            List<Claim> claims = agent.Connect("test1", "1tset", false);
            Assert.IsNotNull(agent);
            return agent.Svr;
        }


        [TestMethod]
        public void Calendar_IsBizDay() {
            List<DateTime> holidays = new List<DateTime>() { new DateTime(2014, 1, 1), new DateTime(2014, 1, 1), new DateTime(2014, 5, 5) };
            FCalendar cal = new FCalendar("TestCalendar", holidays);
            Assert.IsTrue(cal.IsBizDay(new DateTime(2014, 3, 5)));
            Assert.IsFalse(cal.IsBizDay(new DateTime(2014, 3, 1)));
            Assert.IsFalse(cal.IsBizDay(new DateTime(2014, 3, 29)));
            Assert.IsFalse(cal.IsBizDay(new DateTime(2014, 4, 20)));
        }
    }
}
