using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class Sensor
    {
        //Attribute
        protected bool carOnSensor;

        //Constructor
        public Sensor() // Constructor
        {
        }

        //Operations
        public virtual void CarDetected() //setter
        {
            carOnSensor = true;
        }
        public virtual void CarLeftSensor() //setter
        {
            carOnSensor = false;
        }
        public virtual bool IsCarOnSensor() //getter
        {
            return carOnSensor;
        }
    }
}
