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
        private double tokenRegularPrice = 3.99;
        private double tokenDisabledPrice = 4.99;
        private double tokenFamilyPrice = 5.99;
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
                if (activeTokens.GetPrepaid(index) == true)
                {
                    feePaid = true;
                    tokenIn = true;
                    activeTokens.PayToken(index);
                    message = "Prepaid token confirmed, no payment required.";
                }
                else
                {
                    tokenIndex = index;
                    tokenIn = true;
                    feePaid = false;
                    message = "The fee is £" + Convert.ToString(tokenRegularPrice) + ".";
                }
            }
        }

        public void PayFee(string money)
        {
            if (Convert.ToDouble(money) == tokenRegularPrice)
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
