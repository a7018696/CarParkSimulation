using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class TokenValidator
    {
        //Attributes
        private ActiveTokens activeTokens;
        private CarPark carPark;
        private string message;

        //Constructor
        public TokenValidator(ActiveTokens activeTokens)
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
            message = "Please insert your ticket.";
        }

        public void TicketEntered(int index)
        {
            if (index != -1) //Index is -1 if no ticket was selected
            {
                if (activeTokens.FetchToken(index) == true)
                {
                    activeTokens.RemoveToken(index);
                    message = "Thank you, drive safely.";
                    carPark.TicketValidated();
                }
                else
                {
                    message = "Ticket invalid, insert valid ticket.";
                }
            }
        }
        public void ClearMessage()              //Setter
        {
            message = "";
        }

        public string GetMessage()              //Getter
        {
            return message;
        }
    }
}
