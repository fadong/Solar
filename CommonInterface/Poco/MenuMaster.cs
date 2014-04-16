
namespace Com.Fadong.CommonInterface.Poco {
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class MenuMaster {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string mnuName { get; set; }
        [DataMember]
        public int mnuType { get; set; }
        [DataMember]
        public int loadType { get; set; }
        [DataMember]
        public int hasChild { get; set; }
        [DataMember]
        public string TgAssembly { get; set; }
        [DataMember]
        public string TgName { get; set; }
        [DataMember]
        public string Parent { get; set; }
        [DataMember]
        public int RefId { get; set; }
        [DataMember]
        public string mnuText { get; set; }
        [DataMember]
        public string mnuTextEng { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreatedTime { get; set; }
        [DataMember]
        public string CreatedUser { get; set; }
        [DataMember]
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        [DataMember]
        public string UpdatedUser { get; set; }
        [DataMember]
        public Nullable<int> Order { get; set; }
        [DataMember]
        public string ShortCutKey { get; set; }
    }
}
