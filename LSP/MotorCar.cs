using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class MotorCar : ICar
    {
        private Engine engine = new Engine();
        public virtual void accelerate()
        {
            engine.Accelerate(0);
        }

        public virtual void turnOnEngine()
        {
            engine.Off();
        }
    }
}
