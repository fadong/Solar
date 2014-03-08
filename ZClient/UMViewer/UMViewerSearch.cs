using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient.UMViewer {
    public partial class UMViewerSearch : Form {
        public UMViewerSearch() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
