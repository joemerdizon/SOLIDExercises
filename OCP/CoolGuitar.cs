using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class CoolGuitar: Guitar
    {
        private string color;

        public string Color
        {
            get { return color = "Flame"; }
            set { color = "Flame"; }
        }

    }
}
