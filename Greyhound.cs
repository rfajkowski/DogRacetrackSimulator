using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer;
        /// <summary>
        /// Moves the dog random points to the right
        /// </summary>
        /// <returns>True if the dog reach is not on finish line, and false otherwise.</returns>
        public bool Run()
        {
            if(MyPictureBox != null )
            {
                Location += Randomizer.Next(5);
                MyPictureBox.Left = StartingPosition + Location;
                if (MyPictureBox.Left >= RaceTrackLength - MyPictureBox.Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Move Greyhound object to the starting position.
        /// </summary>
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
            
        }
    }
}
