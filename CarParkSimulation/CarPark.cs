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
        private Barrier exitBarrier;

        //Attributes
        private int currentNormal;
        private int currentDisabled;
        private int currentFamily;

        private int normalSpaces = 30;
        private int disabledSpaces = 10;
        private int familySpaces = 10;

        //Constructor
        public CarPark(TokenMachine tokenMachine, TokenValidator tokenValidator, 
            FrontSign frontSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.tokenMachine = tokenMachine;
            this.tokenValidator = tokenValidator;
            this.frontSign = frontSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;

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

        public void TokenDispensed(int bayType)
        {
            switch (bayType)
            {
                case 0:
                    currentNormal--;
                    break;
                case 1:
                    currentDisabled--;
                    break;
                case 2:
                    currentFamily--;
                    break;
            }
            entryBarrier.Raise();
            UpdateSpaces();
        }

        public void TicketValidated(int bayType)
        {
            switch (bayType)
            {
                case 0:
                    currentNormal++;
                    break;
                case 1:
                    currentDisabled++;
                    break;
                case 2:
                    currentFamily++;
                    break;
            }
            exitBarrier.Raise();
            UpdateSpaces();
        }

        public void CarEnteredCarpark()
        {
            entryBarrier.Lower();
            tokenMachine.DefaultMessage();
        }

        public void CarExitedCarPark()
        {
            exitBarrier.Lower();
            tokenValidator.ClearMessage();
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
