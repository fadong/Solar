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
using CommonInterface;

namespace ZClient {
    public partial class FormProduct : Form {
        public FormProduct(string uctlname) {
            InitializeComponent();
            Type t = Assembly.GetExecutingAssembly().GetType("ZClient.UCtls." + uctlname);
            UCtls.UCtlProd uctl = (UCtls.UCtlProd)Activator.CreateInstance(t);
            tableLayoutPanel1.ColumnStyles[1].Width = 600;
            this.Width = uctl.Width + (int)tableLayoutPanel1.ColumnStyles[1].Width + 22;
            instPanel.Controls.Add(uctl);
            uctl.Dock = DockStyle.Fill;
            this.Refresh();
        }

        private UCtls.UCtlProd uctl = null;

        /// <summary>
        /// FormProduct 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuL2_Close_Click(object sender, EventArgs e) {
            try {
                Close();
            }
            catch(Exception err) {
                Logger.Error(this, err.Message);
            }
        }
    }
}
