using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Fadong.CommonInterface;
using Com.Fadong.CommonLib;

namespace Com.Fadong.ZClient.UMViewer {
    public partial class UMViewer : UserControl {
        public UMViewer() {
            InitializeComponent();
        }

        public void Binding(ViewTable vt) {
        


        }

        private void gBase_MouseClick(object sender, MouseEventArgs e) {
            try {
                if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ctxMenu.Show((Control)sender, new Point(e.X, e.Y), ToolStripDropDownDirection.Default);
                    if (gBase.ColSel >= 0 && gBase.ColSel < gBase.Cols.Count) {
                        cmnuCWidthAutoSize.Enabled = true;
                    } else {
                        cmnuCWidthAutoSize.Enabled = false;
                    }
                }
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void cmnuSearch_Click(object sender, EventArgs e) {
            try {
                UMViewerSearch frm = new UMViewerSearch();
                frm.Show();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void cmnuColLayout_Click(object sender, EventArgs e) {
            try {
                UMViewerCLayoutDesigner frm = new UMViewerCLayoutDesigner();
                frm.ShowDialog();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        protected abstract void CustomCtxMenu();
    }
}
