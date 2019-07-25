using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class JohnDoe : ICompete,ISwim
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
        public void compete()
        {
            throw new NotImplementedException();
        }
    }
}
