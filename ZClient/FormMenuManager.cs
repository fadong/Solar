using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.ZClient {
    public partial class FormMenuManager : Form {
        public FormMenuManager() {
            InitializeComponent();
            SetInit();
        }

        private void SetInit() {
            MngLayoutManager.BE.SetMenuTreeLayout(tv);
            cmbLoadType.Items.AddRange(new string[] { "Action Command", "FormLoad Command", "TabPageLoad Command" });
            cmbLoadType.SelectedIndex = 0;
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            try {
                if (e.Node.Tag != null) {
                    ClsMenuInfo minfo = (ClsMenuInfo)e.Node.Tag;
                    txtMenuName.Text = minfo.MenuName;
                    txtMenuText.Text = minfo.MenuText;
                    chkIsSeparator.Checked = minfo.IsSeperator;
                    cmbLoadType.SelectedIndex = (int)minfo.LoadType;
                    txtAssemblyName.Text = minfo.AssemblyName;
                    txtTargetName.Text = minfo.TargetName;
                    txtParentName.Text = minfo.Parent;
                }
            } catch (Exception err) {
                Logger.Error(this, err);
            }
        }

        private void tv_MouseClick(object sender, MouseEventArgs e) {
            try {
                if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ctxMenu.Show(this, e.Location, ToolStripDropDownDirection.Default);
                }
            } catch (Exception err) {
                Logger.Error(this, err);
            }
        }
    }
}
