using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class WordInText
    {
        public String ReturnWordInText(String word, string text)
        {
            return text.Replace(word, text);
        }
    }
}
