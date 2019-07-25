using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class ConvertIntoBookText
    {
        private string _mytext = "Jhayar Marimat";

        public void replaceWordInText(String word)
        {
           Console.WriteLine("The content of the book is : " + _mytext.Replace(_mytext, word));
        }
    }
}
