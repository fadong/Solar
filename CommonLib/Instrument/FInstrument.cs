using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib
{
    /// <summary>
    /// IInstrumentObject를 구현하는 기본 클래스
    /// 내부적으로 Additional Info 목록과 Exotic Event 목록을 유지
    /// Author : Jaekyoon, Lee
    /// Date : 2014.02.05
    /// </summary>
    public class FInstrument : BObj, IInstrumentObject, INotifyPropertyChanged {

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

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this,
                                new PropertyChangedEventArgs(propertyName));
            }
        }


        /// <summary>
        /// 상품명
        /// </summary>
        public string Name { 
            get{
                return this._name;
            }
            set {
                if (value != this._name) {
                    this._name = value;
                    NotifyPropertyChanged();
                }
            } 
        }

        /// <summary>
        /// 상품타입
        /// </summary>
        public INSTYPE InsType {
            get {
                return this._instype;
            }
            set {
                if (value != this._instype) {
                    if (this._name.Equals("")) {

                    }
                    NotifyPropertyChanged();
                }
            } 
        }

        public override XElement ToXML() {
            XElement xout = new XElement("Instrument");
            xout.Add(new XElement("Id", this.Id));
            xout.Add(new XElement("Type", this.InsType));
            xout.Add(new XElement("Name", this.Name));
            xout.Add(base.ToXML());
            return xout;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private string _name = string.Empty;
        private INSTYPE _instype = INSTYPE.NONE;
    }
}
