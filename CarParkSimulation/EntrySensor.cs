using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class EntrySensor:Sensor
    {
        //Attribute
        private CarPark carPark;

        //Constructor
        public EntrySensor(CarPark carPark)
        {
            this.carPark = carPark;
        }

        //Operations
        public override void CarDetected() //setter
        {
            carOnSensor = true;
            carPark.CarArrivedAtEntrance();
        }

        public override void CarLeftSensor() //setter
        {
            carOnSensor = false;
            carPark.CarEnteredCarpark();
        }
    }
}
