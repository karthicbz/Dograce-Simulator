using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = Name+" hasn't placed a bet";
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
            
            if (Cash >= 5)
            {
                MyLabel.Text = MyBet.GetDescription();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
