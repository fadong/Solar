using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.ZClient.UCtlProd {
    public partial class UCtlProd_Stock : UCtlProdBase {
        public UCtlProd_Stock() {
            InitializeComponent();
            Init(new FInstrumentStock());
        }

        public void Init(FInstrumentStock stock) {
            this._stock = new FInstrumentStock();
            gInfo.txtName.DataBindings.Add("Name", this._stock, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public override Task<bool> Save() {
            List<Exception> exps = new List<Exception>();

            //if (txtName.Text.Length != 0) {
            //    stock.Name = txtName.Text;
            //} else {
            //    exps.Add(new Exception("상품명이 설정되지 않음"));
            //}
            Func<bool> func = delegate() {
                for (int i = 0; i < 100; i++) {
                    ZServer.BE.Svr.SaveInstrument(stock.ToXML());
                }
                return true;
            };

            return Task.Factory.StartNew<bool>(func);
        }

        FInstrumentStock _stock = null;

        FInstrument stock = null;
    }
}
