using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Main
    {
        public static void MainCar(String[] args)
        {
            ICar _electricCar = new ElectricCar();
            _electricCar.accelerate();
            _electricCar.turnOnEngine();

            ICar _motorCar = new MotorCar();
            _motorCar.accelerate();
            _motorCar.turnOnEngine();
            
        }
    }
}
