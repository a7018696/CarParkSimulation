using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class Barrier
    {
        //Attribute
        private bool lifted;     //true = Lifted | false = Lowered

        //Constructor
        public Barrier()
        {
            lifted = false;
        }

        //Operation
        public void Lower()         //Setter
        {
            lifted = false;
        }

        public void Raise()         //Setter
        {
            lifted = true;
        }

        public bool IsLifted()      //Getter
        {
            return lifted;
        }
    }
}
