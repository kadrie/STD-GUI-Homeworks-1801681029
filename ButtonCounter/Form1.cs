using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gold;
        }
        
        int countOfClicks = 0; 
        private void btnClickCounter_Click(object sender, EventArgs e)
        {
            countOfClicks++;
            lblNumberOfClicks.Text = countOfClicks.ToString();
            if (countOfClicks==5)
            { 
                this.BackColor= Color.Green;
            }
            else if (countOfClicks==10)
            {
                this.BackColor = Color.Blue;
            }
            else if (countOfClicks==15)
            {
                this.BackColor = Color.Red;
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            countOfClicks = 0;
            lblNumberOfClicks.Text = countOfClicks.ToString();
            this.BackColor = Color.Gold;
        }
    }
}
