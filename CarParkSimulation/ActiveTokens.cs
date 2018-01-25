using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkSimulation
{
    class ActiveTokens
    {
        //Attributes
        private List<Token> tokens;

        //Constructor
        public ActiveTokens()
        {
            tokens = new List<Token>();
        }

        //Operations
        public void AddToken(Token token)
        {
            tokens.Add(token);
        }

        public void RemoveToken(int selectedToken)
        {
            tokens.RemoveAt(selectedToken);
        }

        public void PayToken(int selectedToken)
        {
            tokens.ElementAt(selectedToken).SetPaid();
        }

        //Getters
        public List<Token> GetTokens()
        {
            return tokens;
        }

        public bool GetPaid(int index)
        {
            return tokens.ElementAt(index).IsPaid();
        }
        public bool GetPrepaid(int index)
        {
            return tokens.ElementAt(index).IsPrepaid();
        }
        public int GetBayType(int index)
        {
            return tokens.ElementAt(index).GetBayType();
        }
    }
}
