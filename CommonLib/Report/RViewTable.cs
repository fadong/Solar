using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace Com.Fadong.CommonLib.Report {
    [Serializable]
    public class RViewTable {
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


        public RViewTable(string templatename) {


        }

        //public ROWKEYTYPE rkeyType { get; private set; }
        public bool IsFilterEnabled { get; private set; }
        public bool IsFreezingEnable { get; private set; }
        public bool IsTotalEnabled { get; private set; }
        public int TitlePos { get; private set; }
        public Color PlusNumericFontColor { get; private set; }
        public Color MinusNumericFontColor { get; private set; }

        public ViewColumns Columns {
            get { return _cols; }
        }

        public ViewRows Rows {
            get { return _rows; }
        }

        public DataTable ToDataTable() {
            DataTable dt = new DataTable();
            dt.Columns.Add("Index", typeof(int));
            foreach (ViewColumn c in _cols) {
                if (c.DataType == DATATYPE.DATE) {
                    dt.Columns.Add(c.Title, typeof(DateTime));
                } else if (c.DataType == DATATYPE.NUMBER) {
                    dt.Columns.Add(c.Title, typeof(decimal));
                } else {
                    dt.Columns.Add(c.Title);
                }
            }

            foreach (ViewRow r in _rows) {
                dt.Rows.Add(r.ToObjectArray());
            }
            return dt;
        }

        ViewColumns _cols = null;
        ViewRows _rows = null;
    }

    #region "public class ViewRows : IEnumerable<ViewRow>"
    
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ViewRows : IEnumerable<ViewRow> {

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<ViewRow> GetEnumerator()
        {
            return this._rows.GetEnumerator();
        }

        List<ViewRow> _rows = new List<ViewRow>();
    }
    #endregion

    #region "public class ViewRow"
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ViewRow {
        public ViewRow(int index, ViewColumns cols) {
            this.Index = index;
            this._cols = cols;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public object this[int i] {
            get {
                return this._cells[i];
            }
            set {
                this._cells[i] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="colname"></param>
        /// <returns></returns>
        public object this[string colname] {
            get {
                ViewColumn vc = this._cols.FirstOrDefault(k => k.Title.Equals(colname));
                return vc != null ? this._cells[vc.Index] : null;
            }
            set {
                ViewColumn vc = this._cols.FirstOrDefault(k => k.Title.Equals(colname));
                if (vc != null) this._cells[vc.Index] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object[] ToObjectArray() {
            object[] objs = new object[_cells.Count + 1];
            objs[0] = this.Index;
            for(int i = 1; i < objs.Length; i++) {
                objs[i] = _cells[i - 1];
            }
            return objs;
        }


        public int Index { get; set; }
        public int KeyValue { get; set; }
        public ViewColumns Columns {
            get { return _cols; }
        }

        private List<object> _cells = new List<object>();
        private ViewColumns _cols = null;
    }
    #endregion

    #region "class ViewColumns : IEnumerable<ViewColumn>"
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

        IEnumerator IEnumerable.GetEnumerator() {
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

    #region "class ViewColumn"
    [Serializable]
    public class ViewColumn {
        private void ViewColumnInit(int index,
                                    string name,
                                    string title,
                                    RViewTable.DATATYPE datatype = RViewTable.DATATYPE.STRING,
                                    string format = "",
                                    RViewTable.TOTALVALUETYPE tvaluetype = RViewTable.TOTALVALUETYPE.NONE,
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
            TextAlign = RViewTable.TextAlign.Left;
            ForeColor = Color.Black;
            BackColor = Color.White;
        }

        public int Index { get; internal set; }
        public string Name { get; internal set; }
        public string Title { get; set; }
        public float Width { get; set; }
        public RViewTable.TOTALVALUETYPE TotalType { get; set; }
        public RViewTable.DATATYPE DataType { get; set; }
        public string Format { get; set; }
        public bool IsVisible { get; set; }
        public bool IsEnable { get; set; }
        public bool IsOriginal { get; set; }
        public int RoundRule { get; set; }
        public RViewTable.TextAlign TextAlign { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
    }
    #endregion

}
