namespace Com.Fadong.CommonInterface.Poco {
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class MkEnum {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Entry { get; set; }
        [DataMember]
        public string Tag { get; set; }
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<int> Order { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreatedTime { get; set; }
        [DataMember]
        public Nullable<System.DateTime> UpdatedTime { get; set; }


    }
}