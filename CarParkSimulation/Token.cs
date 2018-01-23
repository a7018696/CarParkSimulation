using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class Token
    {
        //Attribute
        private bool paid;

        //Constructor
        public Token()
        {
            paid = false;
        }

        //Operations
        public bool IsPaid()            //Getter
        {
            return paid;
        }

        public void SetPaid()           //Setter
        {
            paid = true;
        }
    }
}
