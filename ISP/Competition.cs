using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Competition : ICompetition
    {
        public void Compete()
        {
            Console.WriteLine("Compete Competition");
        }

        public void Swim()
        {
            Console.WriteLine("Swim Competition");
        }

        public void HighJump()
        {
            Console.WriteLine("Swim Competition");
        }

        public void LongJump()
        {
            Console.WriteLine("Swim Competition");
        }
    }
}
