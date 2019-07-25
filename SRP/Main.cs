using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Main
    {
        static void main(string[] args)
        {
           Book book = new Book();
           string word = ReplaceWordInText.replaceWordInText("Lannister");

           Console.WriteLine(book.isWordInText(word));

        }
    }
}
