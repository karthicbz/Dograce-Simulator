using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    public partial class Form1 : Form
    {
        Guy[] guy = new Guy[3];
        Bet bet = new Bet();
        public Form1()
        {
            InitializeComponent();
            guy[0] = new Guy() { Name = "Karthick", Cash = 50, MyRadioButton = radioButtonJoe, MyLabel = labelJoeBet };
            guy[1] = new Guy() { Name = "Sangeetha", Cash = 75, MyRadioButton = radioButtonBob, MyLabel = labelBobBet };
            guy[2] = new Guy() { Name = "Dinesh", Cash = 45, MyRadioButton = radioButtonAl, MyLabel =labelAlBet };

            LabelUpdater();
            guy[0].PlaceBet(0,0);
            guy[1].PlaceBet(0,0);
            guy[2].PlaceBet(0,0);

            labelMinimumBet.Text = "Minimum bet: "+numericUpDownAmount.Value.ToString()+" bucks";
        }

        Greyhound[] Greyhounds = new Greyhound[4];
        Random random = new Random();
 
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
            Greyhounds[0] = new Greyhound();
            Greyhounds[0].Randomizer = random;
            Greyhounds[0].MyPictureBox = pictureBox1;
            Greyhounds[0].StartingPoint = pictureBox1.Left;


            Greyhounds[1] = new Greyhound();
            Greyhounds[1].Randomizer = random;
            Greyhounds[1].MyPictureBox = pictureBox2;
            Greyhounds[1].StartingPoint = pictureBox1.Left;

            Greyhounds[2] = new Greyhound();
            Greyhounds[2].Randomizer = random;
            Greyhounds[2].MyPictureBox = pictureBox3;
            Greyhounds[2].StartingPoint = pictureBox1.Left;

            Greyhounds[3] = new Greyhound();
            Greyhounds[3].Randomizer = random;
            Greyhounds[3].MyPictureBox = pictureBox4;
            Greyhounds[3].StartingPoint = pictureBox1.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            for(int i=0; i<4; i++)
            {
                if(Greyhounds[i] != null)
                {
                    Greyhounds[i].Move();
                    if(Greyhounds[i].Move())
                    {
                        timer1.Stop();
                        
                        //Console.WriteLine("Winner: Dog{0}",i+1);
                        winner = i+1;
                        MessageBox.Show("Dog " + winner);
                        //LabelUpdater();
                        collectWinningAmount(winner);
                        groupBox1.Enabled = true;
                        for (int j=0; j<4; j++)
                        {
                            Greyhounds[j].StartingPosition();
                        }
                    }
                    
                }
            }
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if(radioButtonJoe.Checked)
            {
                if (guy[0].PlaceBet((int)numericUpDownAmount.Value, (int)numericUpDownDog.Value))
                {
                    //guy[0].UpdateLabels();
                    
                    labelJoeBet = guy[0].MyLabel;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");
                    guy[0].PlaceBet(0, 0); //Amount less than 5.
                }
            }
            else if(radioButtonBob.Checked)
            {
                if (guy[1].PlaceBet((int)numericUpDownAmount.Value, (int)numericUpDownDog.Value))
                {
                    //guy[0].UpdateLabels();
                    labelJoeBet = guy[1].MyLabel;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");
                    guy[1].PlaceBet(0, 0);
                }
            }
            else if(radioButtonAl.Checked)
            {
                if (guy[2].PlaceBet((int)numericUpDownAmount.Value, (int)numericUpDownDog.Value))
                {
                    //guy[0].UpdateLabels();
                    labelJoeBet = guy[2].MyLabel;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");
                    guy[2].PlaceBet(0, 0);
                }
            }
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = guy[0].Name;
        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = guy[1].Name;
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = guy[2].Name;
        }

        private void LabelUpdater()
        {
            for (int i = 0; i < 3; i++)
            {
                guy[i].UpdateLabels();
            }
        }

        private void collectWinningAmount(int winnerDog)
        {
            for(int i=0; i<3; i++)
            {
                guy[i].Collect(winnerDog);
            }
        }
    }
}
