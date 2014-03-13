using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using PostSharp.Aspects;

namespace Com.Fadong.CommonInterface.AOP {

    public sealed class LogActivityAttribute : OnMethodBoundaryAspect {
        public LogActivityAttribute(ACTIVITYLEVEL activityLevel) {
            ActivityLevel = activityLevel;
        }

        public LogActivityAttribute() {
            ActivityLevel = ACTIVITYLEVEL.Entry | ACTIVITYLEVEL.Exit;
        }

        public override void OnEntry(MethodExecutionArgs args) {
            try {
               
                Logger.Info(this, "LogIn : " + DateTime.Now.ToString("G"));
                if ((ActivityLevel & ACTIVITYLEVEL.Duration) != 0) {
                    sw = new Stopwatch();
                }
            } catch (Exception err) {
                Logger.Error(this, err.Message);
            }
        }

        public override void OnExit(MethodExecutionArgs args) {
            try {
                Logger.Info(this, "LogOut : " + DateTime.Now.ToString("G"));
                if ((ActivityLevel & ACTIVITYLEVEL.Duration) != 0) {
                    if (sw != null) {
                        sw.Stop();
                        Logger.Info(this, "Duration(Milliseconds) : " + sw.ElapsedMilliseconds);
                    }
                }
            } catch (Exception err) {
                Logger.Error(this, err.Message);
            } finally {
                if (sw != null && sw.IsRunning) {
                    sw.Stop();
                }
            }
        }

        public override void OnException(MethodExecutionArgs args) {
            Logger.Info(this, "");
        }

        public ACTIVITYLEVEL ActivityLevel { get; set; }
        Stopwatch sw = null;
    }
}
