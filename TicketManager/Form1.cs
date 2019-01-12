using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int priceForKids = 3;
        int priceForStudents = 4;
        int priceForUniStudents = 5;
        private void btnValidateMyOrder_Click(object sender, EventArgs e)
        {
            int amountOfTickets = int.Parse(txtBoxAmountOfTickets.Text);
            int price = 0;
            if (rdBtnKids.Checked==true)
            {
                price = amountOfTickets * priceForKids;
            }
            else if (rdBtnStudents.Checked==true)
            {
                price = amountOfTickets * priceForStudents;
            }
            else if(rdBtnUniStudent.Checked==true)
            {
                price = amountOfTickets * priceForUniStudents;
            }
            lblPrice.Text = price.ToString();
        }
    }
}
