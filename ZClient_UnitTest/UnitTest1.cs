using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Com.Fadong.ZClient;

namespace ZClient_UnitTest {
    [TestClass]
    public class CommandManagerTest {
        [TestMethod]
        public void CommandManagerTest_OpenForm() {
            //MenuStrip mnustrip = new MenuStrip();
            //EventHandler evtHandler = CmdHandler;
            //MngLayoutManager.BE.SetMenuLayout(mnustrip, evtHandler);
            //Assert.IsTrue(MngCommandManager.BE.Commands.Count > 0) ;
        }

        [TestMethod]
        public void CommandMangerTest_OpenTabPage() {
            //MenuStrip mnustrip = new MenuStrip();
            //EventHandler evtHandler = CmdHandler;
            //MngLayoutManager.BE.SetMenuLayout(mnustrip, evtHandler);
            //Assert.IsTrue(MngCommandManager.BE.Commands.ContainsKey("mnuL3_Vsys_Server") == true);
            //Assert.IsTrue(((MenuItemCommand)MngCommandManager.BE.Commands["mnuL3_Vsys_Server"]).TargetName.Equals(""));
                
        }

        private void CmdHandler(object sender, EventArgs e) {
            
        }

    }
}
