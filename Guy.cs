using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        //GUI Controls
        public RadioButton MyRadioButton;
        public Label MyLabel;
        
        /// <summary>
        /// Updates GUI labels.
        /// </summary>
        public void UpdateLabel()
        {
            MyRadioButton.Text = Name + " has £" + Cash;
            if (MyBet != null){
                MyLabel.Text = MyBet.GetDescription();

            }
            else
            {
                MyLabel.Text = Name + " hasn't placed a bet";
            }
        }

        /// <summary>
        /// Clear bets
        /// </summary>
        public void ClearBet()
        {
            MyBet = new Bet() { Amount = 0, Bettor = this, Dog = 0 };
        }

        /// <summary>
        /// If there is enough cash, creates new Bet object and sets its value, displays informative message box otherwise.
        /// </summary>
        /// <param name="betAmount">Amount of cash to bet.</param>
        /// <param name="DogToWin">No of the dog</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool PlaceBet(int betAmount, int DogToWin)
        {
            if(betAmount <= Cash)
            {
                MyBet.Amount = betAmount;
                MyBet.Dog = DogToWin;
                UpdateLabel();
                return true;
            }
            else
            {
                MessageBox.Show(Name + " doesn't have enough money", "No money!!!");
                return false;
            }
        }

        /// <summary>
        /// Ask Bet object if his Greyhound is the winner, then adds or deducts money from Cash field.
        /// Clear references and updates labels
        /// </summary>
        /// <param name="Winner">No. of wining dog.</param>
        public void CollectMoney(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabel();
        }
    }
}
