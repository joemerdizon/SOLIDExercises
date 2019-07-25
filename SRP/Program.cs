using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        public static void Main()
        {
            Book book = new Book();
            
            ReplaceWordInText replaceWordInText = new ReplaceWordInText();

            string replaceResult = replaceWordInText.Replace("OldWord", book._text);

            IsWordInText isWordInText = new IsWordInText();

            bool isWordInTextResult = isWordInText.isWordInText("pays", book._text);

        }

    }
}
