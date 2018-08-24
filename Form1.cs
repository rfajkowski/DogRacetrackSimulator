using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class Form1 : Form
    {
        Random MyRandomizer = new Random();
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] Players = new Guy[3];
        
        
        public Form1()
        {

            InitializeComponent();
            InitializeGreyhound();
            InitializePlayers();
            minimumBetLabel.Text = "Minimum bet is " + betNumericUpDown.Minimum; 

        }
        private void InitializeGreyhound()
        {
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = dogPicture0,
                StartingPosition = dogPicture0.Left,
                RaceTrackLength = raceTrackPictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = dogPicture1,
                StartingPosition = dogPicture1.Left,
                RaceTrackLength = raceTrackPictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = dogPicture2,
                StartingPosition = dogPicture2.Left,
                RaceTrackLength = raceTrackPictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = dogPicture3,
                StartingPosition = dogPicture3.Left,
                RaceTrackLength = raceTrackPictureBox.Width,
                Randomizer = MyRandomizer
            };
        }

        private void InitializePlayers()
        {
            Players[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyLabel = joeBetLabel,
                MyRadioButton = joeRadioButton
            };
            Players[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton
            };
            Players[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton
            };

            for (int i = 0; i < Players.Length; i++)
            {
                Players[i].ClearBet();
                Players[i].UpdateLabel();
            }
        }

        private void alBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = Players[0].Name;
            
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = Players[1].Name;

        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = Players[2].Name;

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int amount = (int) betNumericUpDown.Value;
            int dogNumber = (int)dogNumericUpDown.Value;
            if (joeRadioButton.Checked == true)
            {
                Players[0].PlaceBet(amount, dogNumber);
            }
            if (bobRadioButton.Checked == true)
            {
                Players[1].PlaceBet(amount, dogNumber);
            }
            if (alRadioButton.Checked == true)
            {
                Players[2].PlaceBet(amount, dogNumber);
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("The winner is dog " + (i + 1));
                    for (int j = 0; j < Players.Length; j++)
                    {
                        Players[j].CollectMoney(i + 1);
                    }

                    groupBox1.Enabled = true;
                    for (int y = 0; y < GreyhoundArray.Length; y++)
                    {
                        GreyhoundArray[y].TakeStartingPosition();
                    }
                }
            }

        }
    }

}
