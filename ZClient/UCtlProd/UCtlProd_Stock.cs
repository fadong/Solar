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
using Com.Fadong.CommonLib.Instrument;
using Com.Fadong.CommonLib.Instrument.Equity;
using ServiceStack.Text;

namespace Com.Fadong.ZClient.UCtlProd {
    public partial class UCtlProd_Stock : UCtlProdBase {
        public UCtlProd_Stock() {
            InitializeComponent();
            Init(new FInstrumentStock());
        }

        public void Init(FInstrumentStock stock) {
            this._stock = new FInstrumentStock();
            gInfo.SetDataBindings(this._stock);
        }

        public override Task<bool> Save() {
            List<Exception> exps = new List<Exception>();

            this._stock.CreatedTime = DateTime.Now;
            this._stock.UpdatedTime = DateTime.Now;
            Func<bool> func = delegate()
            {
                string stock = JsonSerializer.SerializeToString<FInstrument>(this._stock);
                ZServer.BE.Svr.SaveInstrument(stock);
                return true;
            };

            return Task.Factory.StartNew<bool>(func);
        }

        FInstrumentStock _stock = null;
    }
}
