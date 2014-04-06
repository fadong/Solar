using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient.UCtlComps {
    public partial class UCtlProdComp_generalInfo : UserControl {
        public UCtlProdComp_generalInfo() {
            InitializeComponent();


        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            Console.WriteLine("Hello!!");
        }
    }
}
