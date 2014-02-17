using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Claims;
using Adapter4Server;
using CommonInterface;

namespace UnitTest_Solar {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void TestMethod_GetInstruments() {
            IClientService proxy = ConnectSolar();
            Assert.IsNotNull(proxy);
            List<Tuple<int, string>> kv = proxy.GetInstrumentKeyValues();
            Assert.IsTrue(kv.Count > 0);

        }

        private IClientService ConnectSolar() {
            Agent agent = new Agent();
            List<Claim> claims = agent.Connect("d3176383", "0000", false);
            return agent.Svr;
        }

        [TestMethod]
        public void TestMethod_Connection() {
            Assert.IsNotNull(ConnectSolar());

        }
    }
}
