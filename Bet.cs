using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacetrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        /// <summary>
        /// Gets description for Guy object label.
        /// </summary>
        /// <returns>Text property for Guys.MyLabel</returns>
        public string GetDescription()
        {
            return Amount == 0 ? Bettor.Name + " hasn't placed a bet" : Bettor.Name + " bets £" + Amount + " on dog #" + Dog;
            
        }
        /// <summary>
        /// Checks if the dog is the winner
        /// </summary>
        /// <param name="Winner">No of winning dog</param>
        /// <returns>Positive or negative number depending if the dog is the winner.</returns>
        public int PayOut(int Winner)
        {
            return Dog == Winner ? Amount : -Amount;
        }
    }
}
