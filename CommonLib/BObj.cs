using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.CommonLib {
    public class BObj : ICommonObject {

        /// <summary>
        /// 상품 Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 생성일
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 수정일
        /// </summary>
        public DateTime UpdatedTime { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// 수정자
        /// </summary>
        public int UpdateUserId { get; set; }

        /// <summary>
        /// Object 상태정보
        /// </summary>
        public OBJECTSTATUS Status { get; set; }
    }
}
