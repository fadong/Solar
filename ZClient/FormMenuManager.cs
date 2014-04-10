using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient {
    public partial class FormMenuManager : Form {
        public FormMenuManager() {
            InitializeComponent();
            SetInit();
        }

        private void SetInit() {

            cmbLoadType.SelectedIndex = 0;

        }
    }
}
