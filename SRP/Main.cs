using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Main
    {
        static void MainBook(String[] args)
        {
            var _wordInText = new WordInText();
            var _book = new Book();
            _wordInText.ReturnWordInText(String.Empty, "");
            _book.isWordInText(String.Empty);
        }
    }
}
