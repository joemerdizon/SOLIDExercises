using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class ElectricCar : WithnoEngine
    {
        public string NoEngine()
        {
            return this.Accelerate(0);
        }

        private string Accelerate(int v)
        {
            throw new NotImplementedException();
        }
    }
}
