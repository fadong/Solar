using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Objects.DataClasses;
using MCached;

namespace Solar {
    class Program {
        static void Main(string[] args) {

            DBCachePool cpool = DBCachePool.BE;
            GCacheDB gInst = cpool["NGOS_INSTRUMENT"];
            GCacheDB gLeg = cpool["NGOS_LEG"];

            

            var instlist = gInst.Where(k => ((NGOS_INSTRUMENT)k).INSTYPE == 4);

            Console.WriteLine(gInst.Count() + " / " + gLeg.Count() + " / " + instlist.Count());



            Console.ReadLine();
        }
    }
}
