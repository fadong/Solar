using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MCached {
    public class GCacheDB : GCache<IEntityWithKey> {

        public override void Load<T>() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using(dbctx ctx = new dbctx()) {
                foreach(IEntityWithKey t in ctx.CreateObjectSet<T>()) {
                    if(t.EntityKey.EntityKeyValues.Length == 1) {
                        this.Add((int)t.EntityKey.EntityKeyValues[0].Value, t);
                    }
                }
            }
            sw.Stop();
            string tablename = typeof(T).Name;
            Console.WriteLine(tablename + " : " + sw.Elapsed.TotalSeconds);
            TableName = tablename;
        }

        private string TableName = string.Empty;
    }
}
