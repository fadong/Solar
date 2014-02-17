using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterface;

namespace CommonInterface {
    public interface ICommonObject {
        int Id { get; set; }


        DateTime CreatedTime { get; set; }
        DateTime UpdatedTime { get; set; }
        int CreateUserId { get; set; }
        int UpdateUserId { get; set; }
        OBJECTSTATUS Status { get; set; }
    }

    public interface IStaticInfoObject {


    }




    public interface IInstrumentObject : ICommonObject {
        string Name { get; set; }
        INSTYPE InsType { get; set; }



    }

    public interface ICFInstrumentObject : IInstrumentObject {


    }

    public interface IDerivInstrumentObject : IInstrumentObject {


    }

    public interface ICombiInstrumentObject : IInstrumentObject {


    }

    //public interface IDBPooler<T> : IEnumerable<T> {
    //    bool Add(int key, T t);
    //    //bool AddOrUpdate(int key, T t);
    //    T Remove(int key);
    //}
}
