using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class CarPark
    {
        private TokenMachine tokenMachine;
        private TokenValidator tokenValidator;
        private FrontSign frontSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier1;
        private Barrier exitBarrier2;

        //Attributes
        private int currentNormal;
        private int currentDisabled;
        private int currentFamily;

        private int normalSpaces = 30;
        private int disabledSpaces = 10;
        private int familySpaces = 10;

        //Constructor
        public CarPark(TokenMachine tokenMachine, TokenValidator tokenValidator, 
            FrontSign frontSign, Barrier entryBarrier, Barrier exitBarrier1, Barrier exitBarrier2)
        {
            this.tokenMachine = tokenMachine;
            this.tokenValidator = tokenValidator;
            this.frontSign = frontSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier1 = exitBarrier1;
            this.exitBarrier2 = exitBarrier2;

            currentNormal = normalSpaces;
            currentDisabled = disabledSpaces;
            currentFamily = familySpaces;
        }

        //Operations
        public void CarArrivedAtEntrance()
        {
            tokenMachine.CarArrived();
        }
        public void CarArrivedAtExit()
        {
            tokenValidator.CarArrived();
        }

        public void TokenDispensed()
        {
            entryBarrier.Raise();
            currentNormal--;
            UpdateSpaces();
        }

        public void TicketValidated()
        {
            exitBarrier1.Raise();
            currentNormal++;
            UpdateSpaces();
        }

        public void CarEnteredCarpark()
        {
            entryBarrier.Lower();
            tokenMachine.DefaultMessage();
        }

        public void CarExitedCarPark()
        {
            exitBarrier1.Lower();
            tokenValidator.DefaultMessage();
        }

        public void UpdateSpaces()
        {
            frontSign.SetNormal(currentNormal);
            frontSign.SetDisabled(currentDisabled);
            frontSign.SetFamily(currentFamily);
        }

        //Getters
        public int GetCurrentNormal()
        {
            return currentNormal;
        }
        public int GetCurrentDisabled()
        {
            return currentDisabled;
        }
        public int GetCurrentFamily()
        {
            return currentFamily;
        }
    }
}
