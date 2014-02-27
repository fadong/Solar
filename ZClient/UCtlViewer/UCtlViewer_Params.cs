using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClient.UCtlViewer {
    public partial class UCtlViewer_Params : UCtlViewerGrid {
        public UCtlViewer_Params() {
            InitializeComponent();
            InitCtl();
        }

        private void InitCtl() {
            ToolStripMenuItem menu = new ToolStripMenuItem("aa");
            toolStripBase.Items.Add(menu);

        }
    }
}
