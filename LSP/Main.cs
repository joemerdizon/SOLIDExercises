using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Main
    {
        static void main(string[] args)
        {
            ICar electricCar = new MotorCar();

            electricCar.turnOnEngine();
            electricCar.accelerate();

            ICar motorCar = new ElectricCar();

            motorCar.turnOnEngine();
            motorCar.accelerate();
        }
    }
}
