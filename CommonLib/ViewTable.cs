using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Com.Fadong.CommonLib {
    [Serializable]
    public class ViewTable {
        public enum TOTALVALUETYPE {
            NONE = 0,
            SUM = 1,
            AVG = 2,
            MAX = 3,
            MIN = 4,
            COUNT = 5
        }

        public enum DATATYPE {
            STRING = 0,
            NUMBER = 1,
            DATE = 2
        }

        public enum TextAlign {
            Left = 0,
            Center = 1,
            Right = 2
        }


        public ViewTable(string templatename) {


        }




    }

    [Serializable]
    public class ViewRows : IEnumerable<ViewRow> {



    }

    [Serializable]
    public class ViewRow {
        public ViewRow(int index, ViewColumns cols) {


        }

        private List<object> _cells = new List<object>();
        private int _index = 0;
        private int _keyvalue = 0;
        private ViewColumns _cols = null;
    }

    #region "public class ViewColumns : IEnumerable<ViewColumn>"
    [Serializable]
    public class ViewColumns : IEnumerable<ViewColumn> {
        public ViewColumns(string name, int width) {
            int pos = this._cols.Count();

        }

        public bool Contains(ViewColumn row) {
            try {
                return this._cols.Contains(row);
            } catch (Exception) {
                throw;
            }
        }

        public void CopyTo(ViewColumn[] array, int i) {
            this._cols.CopyTo(array, i);
        }

        public bool Remove(ViewColumn row) {
            return _cols.Remove(row);
        }

        public void Clear() {
            this._cols.Clear();
        }

        public ViewColumn this[int i] {
            get { return ((List<ViewColumn>)this._cols)[i]; }
        }

        public ViewColumn this[string title] {
            get { return this._cols.FirstOrDefault(k => k.Title.Equals(title)); }
        }

        public IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public IEnumerator<ViewColumn> GetEnumerator() {
            return this._cols.GetEnumerator();
        }

        public int Count {
            get { return this._cols.Count; }
        }

        public bool IsReadOnly {
            get { return this._cols.IsReadOnly; }
        }

        ICollection<ViewColumn> _cols = new List<ViewColumn>();
    }
    #endregion

    #region "public class ViewColumn"
    [Serializable]
    public class ViewColumn {
        private void ViewColumnInit(int index,
                                    string name,
                                    string title,
                                    ViewTable.DATATYPE datatype = ViewTable.DATATYPE.STRING,
                                    string format = "",
                                    ViewTable.TOTALVALUETYPE tvaluetype = ViewTable.TOTALVALUETYPE.NONE,
                                    bool isVisible = true,
                                    bool isEnable = true,
                                    bool isOriginal = true) {
            Index = index;
            Name = name;
            Title = title;
            DataType = datatype;
            Format = format;
            IsVisible = isVisible;
            IsEnable = isEnable;
            IsOriginal = isOriginal;
            RoundRule = 0;
            TextAlign = ViewTable.TextAlign.Left;
            ForeColor = Color.Black;
            BackColor = Color.White;
        }

        public int Index { get; internal set; }
        public string Name { get; internal set; }
        public string Title { get; set; }
        public float Width { get; set; }
        public ViewTable.TOTALVALUETYPE TotalType { get; set; }
        public ViewTable.DATATYPE DataType { get; set; }
        public string Format { get; set; }
        public bool IsVisible { get; set; }
        public bool IsEnable { get; set; }
        public bool IsOriginal { get; set; }
        public int RoundRule { get; set; }
        public ViewTable.TextAlign TextAlign { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
    }
    #endregion

}
