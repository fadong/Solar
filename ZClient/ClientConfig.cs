using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.ZClient {
    public static class ClientConfig {

        public static string MAINFORM_NAME = "FormMain";
        public static string DOCTAB_SUBINFONAME = "docTabSubInfo";
        public static string UCTLVIEWER_PREFIX = "Com.Fadong.ZClient.UCtlViewer.";

        public static Timer SYSTIMER = null;
        public static int SYSTIMER_INTERNVAL = 500;

        public static DateTime CONNECTED_TIME = DateTime.MaxValue;
        public static System.Timers.Timer MASTER_TIMER = new System.Timers.Timer(500);

        public static LANGUAGE LANGUAGE = CommonInterface.LANGUAGE.KOREAN;


    }
}
