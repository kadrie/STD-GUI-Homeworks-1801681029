using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            targetNumberTwenty = random.Next(0, 20);
            targetNumberFifty = random.Next(20, 50);
            targetNumberHundred = random.Next(50, 100);
        }

        int targetNumberTwenty = 0;
        int targetNumberFifty = 0;
        int targetNumberHundred = 0;
        int guessedNumber = 0;
        int counter = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {


            if (cBLevels.Text=="0-20")
            {
                guessedNumber = int.Parse(tbUserInput.Text);

                if (guessedNumber == targetNumberTwenty)
                {
                    pBResult.Image = GuessTheNumber.Properties.Resources.Paula_Barrett_Thumbs_Up_Actions;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) < targetNumberTwenty)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.Arrow_up_font_awesome_svg;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) > targetNumberTwenty)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.images;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }
                lblCounter.Text = counter.ToString();
            }



            else if (cBLevels.Text=="20-50")
            {
                guessedNumber = int.Parse(tbUserInput.Text);

                if (guessedNumber == targetNumberFifty)
                {
                    pBResult.Image = GuessTheNumber.Properties.Resources.Paula_Barrett_Thumbs_Up_Actions;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) < targetNumberFifty)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.Arrow_up_font_awesome_svg;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) > targetNumberFifty)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.images;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }

                lblCounter.Text = counter.ToString();
            }

            

            else if (cBLevels.Text=="50-100")
            {
                guessedNumber = int.Parse(tbUserInput.Text);

                if (guessedNumber == targetNumberHundred)
                {
                    pBResult.Image = GuessTheNumber.Properties.Resources.Paula_Barrett_Thumbs_Up_Actions;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) < targetNumberHundred)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.Arrow_up_font_awesome_svg;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }

                else if (int.Parse(tbUserInput.Text) > targetNumberHundred)
                {
                    pBUpOrDown.Image = GuessTheNumber.Properties.Resources.images;
                    pBResult.Image = GuessTheNumber.Properties.Resources.kisspng_thumb_signal_smiley_clip_art_thumbs_down_cliparts_5a88f166dbe628_2373188215189241349007;
                    counter++;
                }
                lblCounter.Text = counter.ToString();
            }
           
        }
        
    }
}
