using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient.UCtlProd {
    public partial class UCtlProd_Repo : UCtlProdBase {
        public UCtlProd_Repo() {
            InitializeComponent();
        }

        public override Task<bool> Save() {
            throw new NotImplementedException();
        }
    }
}
