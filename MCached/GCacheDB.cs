using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Threading.Tasks;
using System.Diagnostics;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.MCached {
    /// <summary>
    /// 
    /// </summary>
    public class GCacheDB : GCache<EntityObject> {

        #region "public override void Load<T>()"
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="Ts"></typeparam>
        public override void Load<T>() {
            string tablename = typeof(T).Name;
            Logger.Info(this, tablename + " Loading Started!!");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (MCtx ctx = new MCtx()) {
                foreach(IEntityWithKey t in ctx.CreateObjectSet<T>()) {
                    if(t.EntityKey.EntityKeyValues.Length == 1) {
                        this.Add(Decimal.ToInt32((decimal)t.EntityKey.EntityKeyValues[0].Value), (EntityObject)t);
                    }
                }
            }
            sw.Stop();
            Logger.Info(this, tablename + " [" + sw.Elapsed.TotalSeconds + " / " + this.Count() + "] Loading Completed!!");
            TableName = tablename;
        }
        #endregion

        public ObjectQuery<T> ReadFromDB<T>(string sql) where T : EntityObject {
            using (MCtx ctx = new MCtx()) {
                return ctx.CreateObjectSet<T>().Where(sql, null);
            }
        }


        private string TableName = string.Empty;
    }
}