using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface {
    public static class MasterConfig {

        public static DateTime DEFAULTFISCALDAY = new DateTime(2013, 3, 1);
        public static DateTime DEFAULTSETTLEDAY = DateTime.Today;
        public static List<string> DEFAULTTRADESTATUS = new List<string>() { "MOCHECKED", "BOCHECKED" };

    }
}
