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

        public bool FetchToken(int selectedToken)
        {
            return tokens.ElementAt(selectedToken).IsPaid();
        }

        public List<Token> GetTokens()                //Getter
        {
            return tokens;
        }
    }
}
