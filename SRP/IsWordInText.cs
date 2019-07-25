using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class IsWordInText
    {
        public bool isWordInText(String word,String _text)
        {
            return _text.Contains(word);
        }
    }
}
