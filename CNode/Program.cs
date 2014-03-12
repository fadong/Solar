using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.Caculator.CNode {
    class Program {

        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        static EventHandler _handler;
        static bool _running = true;
        static SubMain _sm = null;
        static Thread _t = null;

        private delegate bool EventHandler(CtrlType sig);

        enum CtrlType {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        /// <summary>
        /// Keyboard 이벤트 처리
        /// </summary>
        /// <param name="sig"></param>
        /// <returns></returns>
        private static bool Handler(CtrlType sig) {
            switch (sig) {
                case CtrlType.CTRL_C_EVENT:
                    StopProc();
                    break;
                case CtrlType.CTRL_LOGOFF_EVENT:
                    StopProc();
                    break;
                case CtrlType.CTRL_SHUTDOWN_EVENT:
                    StopProc();
                    break;
                case CtrlType.CTRL_CLOSE_EVENT:
                    StopProc();
                    break;
                default:
                    break;
            }
            return true;
        }

        static void Main(string[] args) {
            try {
                _handler += new EventHandler(Handler);      // 키보드 이벤트 등록
                SetConsoleCtrlHandler(_handler, true);

                if (args.Length == 0) {
                    // 이벤트 수신 처리부
                    _sm = new SubMain();
                    ThreadStart ts = new ThreadStart(_sm.Run);
                    _t = new Thread(ts);
                    _t.Start();
                    Console.WriteLine("CNode Opened!!");
                    Logger.Info("", "CNode Opened!!");
                    // 이벤트 수신을 위한 Looping
                    while (_running) {
                        string cmd = Console.ReadLine();
                        if (cmd == null || cmd.ToUpper().Equals("EXIT")) {
                            StopProc();
                        }
                    }
                } else if (args.Length == 1) {

                }
            } catch (Exception err) {
                Logger.Error(typeof(Program), "", err);
            }
        }

        /// <summary>
        /// Server Stop을 위한 함수
        /// </summary>
        static void StopProc() {
            Logger.Info("", "CNode Stopping!!");
            _sm.Stop();
            _t.Join();
            _running = false;
            Logger.Info("", "CNode Stopped!!");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class SubMain {
        private bool _isrunning = true;

        public SubMain() {
            //DBCachePool dbpool = DBCachePool.BE;
        }

        public void Run() {
            //CalcService service = new CalcService();
            //service.OpenClientServiceHost();
            while (this._isrunning) {
                Thread.Sleep(30);
            }
        }

        public void Stop() {
            this._isrunning = false;
        }
    }
}
