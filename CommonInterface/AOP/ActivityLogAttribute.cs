using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using PostSharp.Aspects;

namespace Com.Fadong.CommonInterface.AOP {

    [Serializable]
    public sealed class ActivityLogAttribute : OnMethodBoundaryAspect {
        public ActivityLogAttribute(ACTIVITYLEVEL activityLevel) {
            ActivityLevel = activityLevel;
        }

        public ActivityLogAttribute() {
            ActivityLevel = ACTIVITYLEVEL.Entry | ACTIVITYLEVEL.Exit;
        }

        public override void OnEntry(MethodExecutionArgs args) {
            try {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Method Entry [{0}] : {1}", args.Method.Name, DateTime.Now.ToString("G"));
                Logger.Info(this, sb.ToString());
                if (Trace2TextBox) {
                    Trace.WriteLine(sb.ToString());
                }
                if ((ActivityLevel & ACTIVITYLEVEL.Duration) != 0) {
                    sw = new Stopwatch();
                    sw.Start();
                }
            } catch (Exception err) {
                Logger.Error(this, err.Message);
            }
        }

        public override void OnExit(MethodExecutionArgs args) {
            try {
                StringBuilder sb = new StringBuilder();
                if ((ActivityLevel & ACTIVITYLEVEL.Duration) != 0) {
                    if (sw != null) {
                        sw.Stop();
                        sb.AppendFormat("Duration(Milliseconds) : {0}" + Environment.NewLine, sw.ElapsedMilliseconds);
                        Logger.Info(this, sb.ToString());
                    }
                }
                sb.AppendFormat("Method Exit [{0}] : {1}", args.Method.Name, DateTime.Now.ToString("G"));
                Logger.Info(this, sb.ToString());
                if (Trace2TextBox) {
                    Trace.WriteLine(sb.ToString());
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
            Logger.Info(this, args.Exception.Message);
        }

        public ACTIVITYLEVEL ActivityLevel { get; set; }
        public bool Trace2TextBox { get; set; }

        [NonSerialized]
        Stopwatch sw = null;
    }
}
