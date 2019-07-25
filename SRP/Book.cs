using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Book
    {
        private string _name;
        private string _author;
        private string _text;

        public Book()
        {
            this._name = "Fiction";
            this._author = "George R.R. Martin";
            this._text = "Lannister always pays his debts!!";
        }

        public bool isWordInText(String word)
        {
            return _text.Contains(word);
        }
    }
}
