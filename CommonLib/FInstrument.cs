using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib
{
    /// <summary>
    /// IInstrumentObject를 구현하는 기본 클래스
    /// 내부적으로 Additional Info 목록과 Exotic Event 목록을 유지
    /// Author : Jaekyoon, Lee
    /// Date : 2014.02.05
    /// </summary>
    public class FInstrument : BObj, IInstrumentObject {

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
        /// 상품명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 상품타입
        /// </summary>
        public INSTYPE InsType { get; set; }

    }
}
