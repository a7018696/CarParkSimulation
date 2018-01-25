using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class PayMachine
    {
        //Attributes
        private string message;
        private bool tokenIn;
        private bool feePaid;
        private int tokenIndex;
        private double tokenPrice = 4.99;
        ActiveTokens activeTokens;

        //Constructor
        public PayMachine(ActiveTokens activeTokens)
        {
            this.activeTokens = activeTokens;
        }

        //Operations
        public void TokenEntered(int index)
        {
            if (index != -1)        //index is -1 when no item was selected
            {
                tokenIndex = index;
                tokenIn = true;
                feePaid = false;
                message = "The fee is £" + Convert.ToString(tokenPrice) + ".";
            }
        }

        public void PayFee(string money)
        {
            if (Convert.ToDouble(money) == tokenPrice)
            {
                activeTokens.PayToken(tokenIndex);
                message = "Fee is paid, please take your ticket.";
                feePaid = true;
            }
            else
            {
                message = "Enter the correct amount.";
            }
        }

        public void ClearMachine()              //Setter
        {
            tokenIn = false;
            feePaid = false;
            message = "";
        }

        public string GetMessage()              //Getter
        {
            return message;
        }

        public bool GetTicketIn()               //Getter
        {
            return tokenIn;
        }

        public bool GetFeePaid()                //Getter
        {
            return feePaid;
        }
    }
}
