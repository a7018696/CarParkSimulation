using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class ExitSensor:Sensor
    {
        //Attributes
        private CarPark carPark;

        //Constructor
        public ExitSensor(CarPark carPark)
        {
            this.carPark = carPark;
        }

        //Operations
        public override void CarDetected() //setter
        {
            carOnSensor = true;
            carPark.CarArrivedAtExit();
        }

        public override void CarLeftSensor() //setter
        {
            carOnSensor = false;
            carPark.CarExitedCarPark();
        }
    }
}
