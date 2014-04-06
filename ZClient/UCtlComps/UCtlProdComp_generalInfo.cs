using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Fadong.CommonLib.Instrument;

namespace Com.Fadong.ZClient.UCtlComps {
    public partial class UCtlProdComp_generalInfo : UserControl {
        public UCtlProdComp_generalInfo() {
            InitializeComponent();
        }

        public void SetDataBindings(FInstrument inst) {


            txtName.DataBindings.Add("Text", inst, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            txtISINCode.DataBindings.Add("Text", inst, "ISINCode", false, DataSourceUpdateMode.OnPropertyChanged);
            testCombo.DataBindings.Add("SelectedItem", inst, "Name", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            Console.WriteLine("Hello!!");
        }

       
    }
}
