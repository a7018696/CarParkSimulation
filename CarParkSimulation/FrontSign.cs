using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class FrontSign
    {
        private int Normal;
        private int Disabled;
        private int Family;
        
        //Constructor
        public FrontSign()
        {
        }

        //Operations
        //Getters
        public int GetNormal()
        {
            return Normal;
        }
        public int GetDisabled()
        {
            return Disabled;
        }
        public int GetFamily()
        {
            return Family;
        }

        //Setters
        public void SetNormal(int normal)
        {
            this.Normal = normal;
        }
        public void SetDisabled(int disabled)
        {
            this.Disabled = disabled;
        }
        public void SetFamily(int family)
        {
            this.Family = family;
        }
    }
}
