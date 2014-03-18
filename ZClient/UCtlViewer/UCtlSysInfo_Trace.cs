using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.ZClient.UCtlViewer {
    public partial class UCtlSysInfo_Trace : UCtlViewerTBox {
        public UCtlSysInfo_Trace() {
            InitializeComponent();
            Trace.AutoFlush = true;
            Trace.Listeners.Add(new RichTextBoxTraceListener(base.tbox));
        }
    }
}
