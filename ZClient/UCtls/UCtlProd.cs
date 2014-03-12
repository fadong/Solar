using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient.UCtls {
    public abstract partial class UCtlProd : UserControl {
        public UCtlProd() {
            InitializeComponent();
        }

        public abstract bool Save();
    }
}
