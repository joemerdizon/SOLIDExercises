using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class JohnDoe : IAthlete
    {
        public void Compete()
        {
          Console.WriteLine("Compete with JohnDoe");
        }

        public void Swim()
        {
          Console.WriteLine("Swim with JohnDoe"); 
        }
    }
}
