using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Windows.Forms;

namespace Com.Fadong.CommonInterface {

    /// <summary>
    /// 
    /// </summary>
    public class RichTextBoxTraceListener : TraceListener {
        private RichTextBox _textbox;
        private StringSendDelegate _invokeWrite;
        private bool _isTracable = false;

        public RichTextBoxTraceListener(RichTextBox textbox) {
            _textbox = textbox;
            string value = ConfigurationManager.AppSettings["Tracable"];
            _isTracable = (value != null && value.ToUpper().Equals("TRUE"))  ? true : false;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        public override void Write(string message) {
            if (_isTracable) {
                _textbox.Invoke(_invokeWrite, new object[] { message });
            }
        }

        public override void WriteLine(string message) {
            if (_isTracable) {
                _textbox.Invoke(_invokeWrite, new object[] { message + Environment.NewLine });
            }
        }

        private delegate void StringSendDelegate(string message);

        private void SendString(string message) {
            _textbox.Text += message;
        }
    }
}
