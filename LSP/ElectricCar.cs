using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
   public class ElectricCar: ICar
   {
       private Engine engine = new Engine();
        public void turnOnEngine()
        {
            engine.On();
        }

        public void accelerate()
        {
            engine.Accelerate(1000);
        }
    }
}
