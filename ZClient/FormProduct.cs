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
using System.Reflection;

namespace ZClient {
    public partial class FormProduct : Form {
        public FormProduct(string uctlname) {
            InitializeComponent();
            Type t = Assembly.GetExecutingAssembly().GetType("ZClient.UCtls." + uctlname);
            UCtls.UCtlProd uctl = (UCtls.UCtlProd)Activator.CreateInstance(t);

            uctl.Dock = DockStyle.Fill;
            instPanel.Controls.Add(uctl);

            this.Refresh();
        }

        private UCtls.UCtlProd uctl = null;
    }
}
