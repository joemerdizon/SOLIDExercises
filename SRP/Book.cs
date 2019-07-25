using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Book
    {
        public static void Main()
        {          
            ConvertIntoBookText BookConvert = new ConvertIntoBookText();
            BookComposition book = new BookComposition();
            BookConvert.replaceWordInText(book._text);

            CheckWordintheBook isexisting = new CheckWordintheBook();
            Console.WriteLine("Is your looking word is in the book? : " + isexisting.isWordInText(book._text));
        }
    }
}
