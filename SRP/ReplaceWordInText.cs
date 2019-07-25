using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ReplaceWordInText
    {
        public static String replaceWordInText(String word)
        {
            Book book = new Book();
            return book._text.Replace(book._text, word);
        }
    }
}
