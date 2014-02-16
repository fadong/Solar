using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ZClient {
    public partial class FormProduct : Form {
        public FormProduct() {
            InitializeComponent();
            _wpfhost = new ElementHost();

            UCtls.UCtlProd_Option ucl = new UCtls.UCtlProd_Option();
            ucl.Dock = DockStyle.Fill;
            instPanel.Controls.Add(ucl);

            
            //this.Height = _wpfhost.Height + toolStrip1.Height + statusStrip1.Height + 60;
            //_wpfhost.Dock = DockStyle.Fill;
            this.Refresh();

        }

        private ElementHost _wpfhost = null;
    }
}
