using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class MotorCar : ICar
    {
        private Engine engine = new NoEngine();
        public void Accelerate()
        {
            engine.Accelerate(1000);
        }

        public void TurnOnEngine()
        {
            engine.On();
        }
    }
}
