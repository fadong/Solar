using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.CommonLib {
    /// <summary>
    /// Book을 담을 수 있는 Compound Book
    /// </summary>
    /// <remarks>Author : Jaekyoon,Lee (2014-03-08)</remarks>
    public class FBookCompound : FBook, IEnumerable<IBook> {

        public IBook Add(IBook book) {
            this._books.Add(book.Name, book);
            return this._books[book.Name];
        }

        public bool Remove(string bookname) {
            bool rst = false;
            if (this._books.ContainsKey(bookname)) {
                rst = this._books.Remove(bookname);
            }
            return rst;
        }

        public IEnumerator GetEnumerator() {
            return this._books.GetEnumerator();
        }

        IEnumerator<IBook> IEnumerable<IBook>.GetEnumerator() {
            return this._books.Values.GetEnumerator();
        }

        public override List<ITradeGroup> TradeGroups(DateTime fiscalday, DateTime settleday, List<IEnum> tradestatus, bool isMixUp = true) {
            List<ITradeGroup> tg = new List<ITradeGroup>();
            return tg;
        }



        private Dictionary<string, IBook> _books = new Dictionary<string, IBook>();
    }
}
