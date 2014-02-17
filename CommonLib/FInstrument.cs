using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using CommonInterface;

namespace CommonLib
{
    /// <summary>
    /// IInstrumentObject를 구현하는 기본 클래스
    /// 내부적으로 Additional Info 목록과 Exotic Event 목록을 유지
    /// Author : Jaekyoon, Lee
    /// Date : 2014.02.05
    /// </summary>
    [Serializable]
    public class FInstrument : IInstrumentObject {

        /// <summary>
        /// 다양한 상품 클래스를 생성할 수 있는 전역생성자
        /// Author : Jaekyoon, Lee
        /// Date : 2014.02.05
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static FInstrument Create<T>() where T : FInstrument, new() {
            T newCls = new T();
            return newCls;
        }

        /// <summary>
        /// 상품 Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 상품명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 상품타입
        /// </summary>
        public INSTYPE InsType { get; set; }

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
