using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class ELectricCar 
    {

        public ICar IntroduceCar()
        {
            ICar icar = new MotorCar();

            icar.turnOnEngine();
            icar.accelerate();

            return icar;
        }



    }
}
