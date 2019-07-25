using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class BookComposition
    {
        private string _name;
        private string _author;
        public string _text;

        public void Book()
        {
            this._name = "Fiction";
            this._author = "George R.R. Martin";
            this._text = "Lannister always pays his debts!!";
        }
    }
}
