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
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonInterface.AOP;

namespace Com.Fadong.ZClient {

    
    public partial class FormProduct : Form {

        [PermissionCheck]
        public FormProduct(string uctlname) {
            InitializeComponent();
            Type t = Assembly.GetExecutingAssembly().GetType("Com.Fadong.ZClient.UCtlProd." + uctlname);
            uctl = (UCtlProd.UCtlProdBase)Activator.CreateInstance(t);
            tableLayoutPanel1.ColumnStyles[1].Width = 600;
            this.Width = uctl.Width + (int)tableLayoutPanel1.ColumnStyles[1].Width + 22;
            instPanel.Controls.Add(uctl);
            uctl.Dock = DockStyle.Fill;
            this.Refresh();
        }

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

        /// <summary>
        /// Instrument 정보 Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSave_Click(object sender, EventArgs e) {
            try {
                bool outrst = await uctl.Save();
                Console.WriteLine("Hellow");
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        UCtlProd.UCtlProdBase uctl = null;
    }
}
