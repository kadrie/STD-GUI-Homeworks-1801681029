using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Paper
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int userScore = 0;
        int compScore = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblEnteredUsername.Text = tBUsername.Text;
        }

        private void pBStone_Click(object sender, EventArgs e)
        {
            pBPlayer.Image = Rock_Scissors_Paper.Properties.Resources.stone;
            int compChoice = rnd.Next(1, 4);

            switch (compChoice)
            {
                case 1:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.paper;
                    compScore++;
                    lblResultComp.Text = compScore.ToString();
                    MessageBox.Show ("Computer wins because paper covers the rock.");
                    break;

                case 2:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
                    userScore++;
                    lblResultUser.Text = userScore.ToString();
                    MessageBox.Show(tBUsername.Text + " wins because stone breaks the scissors.");
                    break;

                case 3:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.stone;
                    MessageBox.Show ("Tie");
                    break;

            }
        }

        private void pBScissors_Click(object sender, EventArgs e)
        {
            pBPlayer.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
            int compChoice = rnd.Next(1, 4);

            switch (compChoice)
            {
                case 1:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.stone;
                    compScore++;
                    lblResultComp.Text = compScore.ToString();
                    MessageBox.Show("Computer wins because stone breaks the scissors.");
                    break;

                case 2:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.paper;
                    userScore++;
                    lblResultUser.Text = userScore.ToString();
                    MessageBox.Show(tBUsername.Text + " wins because scissors cut the paper.");
                    break;

                case 3:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
                    MessageBox.Show("Tie");
                    break;

            }
        }

        private void pBPaper_Click(object sender, EventArgs e)
        {
            pBPlayer.Image = Rock_Scissors_Paper.Properties.Resources.paper;
            int compChoice = rnd.Next(1, 4);

            switch (compChoice)
            {
                case 1:
                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
                    compScore++;
                    lblResultComp.Text = compScore.ToString();
                    MessageBox.Show("Computer wins because scissors cut the paper.");
                    break;

                case 2:

                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.stone;
                    userScore++;
                    lblResultUser.Text = userScore.ToString();
                    MessageBox.Show(tBUsername.Text + " wins because paper covers the rock.");
                    break;

                case 3:

                    pBComputer.Image = Rock_Scissors_Paper.Properties.Resources.paper;
                    MessageBox.Show("Tie");
                    break;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblEnteredUsername.Text = "Username";
            tBUsername.Text = ""; 
            lblResultComp.Text = "0";
            lblResultUser.Text = "0";
            userScore = 0;
            compScore = 0;
            pBComputer.Image = null;
            pBPlayer.Image = null;

        }
    }
}
