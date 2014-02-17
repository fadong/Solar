using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Threading.Tasks;
using System.Diagnostics;
using CommonInterface;

namespace MCached {
    /// <summary>
    /// 
    /// </summary>
    public class GCacheDB : GCache<EntityObject> {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="Ts"></typeparam>
        public override void Load<Ts>() {
            string tablename = typeof(Ts).Name;
            Logger.Info(this, tablename + " Loading Started!!");
            Stopwatch sw = new Stopwatch();
            sw.Start();


            using (MCtx ctx = new MCtx()) {
                foreach(IEntityWithKey t in ctx.CreateObjectSet<Ts>()) {
                    if(t.EntityKey.EntityKeyValues.Length == 1) {
                        this.Add(Decimal.ToInt32((decimal)t.EntityKey.EntityKeyValues[0].Value), (EntityObject)t);
                    }
                }
            }
            sw.Stop();
            Logger.Info(this, tablename + " [" + sw.Elapsed.TotalSeconds + " / " + this.Count() + "] Loading Completed!!");
            TableName = tablename;
        }

        private string TableName = string.Empty;
    }
}
