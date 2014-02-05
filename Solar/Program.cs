using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MCached;

namespace Solar {
    class Program {
        static void Main(string[] args) {

            CachePool cpool = CachePool.BE;
            cpool.CacheGen();

            Console.ReadLine();
        }
    }
}
