using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient.UCtlViewer {
    public partial class UCtlViewerGrid : UCtlViewer {
        public UCtlViewerGrid() {
            InitializeComponent();
        }

        private void gridG_MouseClick(object sender, MouseEventArgs e) {
            try {
                if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ctxMenu.Show((Control)sender, new Point(e.X, e.Y), ToolStripDropDownDirection.Default);
                }
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void cmnuSearch_Click(object sender, EventArgs e) {
            try {
                UMViewer.UMViewerSearch frm = new UMViewer.UMViewerSearch();
                frm.Show(this);
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
