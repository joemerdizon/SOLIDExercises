using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Guitar : CoolGuitar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Volume { get; set; }
        public override string FlameColor { get; set; }
    }
}
