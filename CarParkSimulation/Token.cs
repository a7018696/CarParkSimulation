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
        private bool prepaid;
        private int bayType;

        //Constructor
        public Token(int bayType, bool prepaid)
        {
            this.prepaid = prepaid;
            this.bayType = bayType;
            paid = false;
        }

        //Operations
        //Getters
        public bool IsPaid()
        {
            return paid;
        }
        public bool IsPrepaid()
        {
            return prepaid;
        }
        public int GetBayType()
        {
            return bayType;
        }

        //Setter
        public void SetPaid()           
        {
            paid = true;
        }
    }
}
