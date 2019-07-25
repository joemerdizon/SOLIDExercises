using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class ElectricCar : ICar
    {
        private Engine engine = new Engine();

        public void turnOnEngine()
        {
            engine.Accelerate(1000);
        }

        public void accelerate()
        {
            engine.On();
        }
    }
}
