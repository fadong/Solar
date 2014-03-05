using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Fadong.CommonLib {
    public class FBookCompound : FBook {

        public FBook Add(FBook book) {
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



        private Dictionary<string, FBook> _books = new Dictionary<string, FBook>();
    }
}
