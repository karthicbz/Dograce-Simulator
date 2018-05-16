using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLabelMove
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            //Bettor = new Guy();
            if(Amount > 0)
            {
                return Bettor.Name + " Bets " + Amount + " on " + "dog #" + Dog;
            }
            else
            {
                
                return Bettor.Name + " hasn't placed a bet";
            }
        }
        
        public int PayOut(int winner)
        {
            if(Dog == winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
