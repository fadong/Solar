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

namespace Com.Fadong.CommonLib.Instrument
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

        #region "public string Name"
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
        #endregion

        #region "public INSTYPE InsType"
        /// <summary>
        /// 상품타입
        /// </summary>
        public INSTYPE InsType {
            get {
                return this._instype;
            }
            set {
                if (value != this._instype) {
                    this._instype = value;
                    NotifyPropertyChanged();
                }
            } 
        }
        #endregion

        #region "public string ISINCode"
        public string ISINCode {
            get { return this._isincode; }
            set {
                if(value != this._isincode) {
                    this._isincode = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region "public DateTime StartDay"
        public DateTime StartDay {
            get { return this._startday; }
            set {
                if(value != this._startday) {
                    this._startday = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region "public DateTime ExpDay"
        public DateTime ExpDay {
            get { return this._expday; }
            set {
                if (value != this._expday) {
                    this._expday = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region "public override XElement ToXML()"
        public override XElement ToXML() {
            XElement xout = new XElement("Instrument");
            xout.Add(new XElement("Id", this.Id));
            xout.Add(new XElement("Type", this.InsType));
            xout.Add(new XElement("Name", this.Name));
            xout.Add(new XElement("ISINCode", this.ISINCode));
            xout.Add(base.ToXML());
            return xout;
        }
        #endregion

        #region "public override string ToString()"
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:{1}" + Environment.NewLine, "Id", this.Id);
            sb.AppendFormat("{0}:{1}" + Environment.NewLine, "Name", this.Name);
            sb.AppendFormat("{0}:{1}" + Environment.NewLine, "Type", this.InsType);
            sb.AppendFormat("{0}:{1}" + Environment.NewLine, "ISINCode", this.ISINCode);
            return sb.ToString();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private string _name = string.Empty;
        private INSTYPE _instype = INSTYPE.NONE;
        private string _isincode = string.Empty;
        private DateTime _startday = DateTime.MinValue;
        private DateTime _expday = DateTime.MinValue;
    }
}
