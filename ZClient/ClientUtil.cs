using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Fadong.ZClient {
    public static class ClientUtil {

        public static IEnumerable<T> GetChildrens<T>(Control control) {
            var type = typeof(T);
            var allControls = GetAllChildrens(control);
            return allControls.Where(c => c.GetType() == type).Cast<T>();
        }

        private static IEnumerable<Control> GetAllChildrens(Control control) {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(c => GetAllChildrens(c)).Concat(controls);
        }
    }
}
