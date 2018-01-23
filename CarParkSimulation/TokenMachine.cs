using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class TokenMachine
    {
        //Attributes
        private string message;
        private ActiveTokens activeTokens;
        private CarPark carPark;

        //Constructor
        public TokenMachine(ActiveTokens activeTokens)
        {
            this.activeTokens = activeTokens;
        }

        //Operations
        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please select the type of bay you would like.";
        }

        public void GiveToken()
        {
            message = "Thank you, enjoy your stay.";
            activeTokens.AddToken(new Token());
            carPark.TokenDispensed();
        }

        public void DefaultMessage()              //Setter
        {
            message = "";
        }

        public string GetMessage()              //Getter
        {
            return message;
        }
    }
}
