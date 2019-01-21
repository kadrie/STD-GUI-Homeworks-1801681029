using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double carPrice=0;
        double finalPrice = 0;
        double extrasPrice = 0;
        double cashDiscount = 0;
        double discount = 0;
        double allExtrasDiscount = 0;

    private void rBAlfa_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 80000;
            pBCars.Image = ConfigureMyAuto.Properties.Resources.alfa_romeo_gtv_illo_christianschulte_1530629520;

            if (rBAlfa.Enabled==true)
            {
                tBPrice.Text = carPrice.ToString();
            }
            
        }

        private void rBBmwM4_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 78000;
            pBCars.Image = ConfigureMyAuto.Properties.Resources.BMW_f82_cs_stage2_ts_01;
            
        }

        private void rBMustang_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 68000;
            pBCars.Image = ConfigureMyAuto.Properties.Resources._1;
        }
        

        private void chBABS_CheckedChanged(object sender, EventArgs e)
        {
            if (chBABS.Checked)
            {
                extrasPrice += 2000;
            }
            else
            {
                extrasPrice -= 2000;
            }
        }

        private void chBFogLights_CheckedChanged(object sender, EventArgs e)
        {
            if (chBFogLights.Checked)
            {
                extrasPrice += 1800;
            }
            else
            {
                extrasPrice -= 1800;
            }
        }

        private void chBChains_CheckedChanged(object sender, EventArgs e)
        {
            if (chBChains.Checked)
            {
                extrasPrice += 1500;
            }
            else
            {
                extrasPrice -= 1500;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            discount = allExtrasDiscount + cashDiscount;
            finalPrice = (extrasPrice + carPrice) - (extrasPrice + carPrice) * discount / 100;
            tBPrice.Text = (extrasPrice + carPrice).ToString();
            tBDiscount.Text = discount.ToString();
            tBFinalPrice.Text = finalPrice.ToString();
        }

        private void ExtrasDiscount ()
        {
            if (chBABS.Checked && chBChains.Checked && chBFogLights.Checked)
            {
                allExtrasDiscount += 10;
            }
            else
            {
                allExtrasDiscount -= 10;
            }
        }

        private void rBCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rBCash.Enabled)
            {
                cashDiscount += 5;
            }
            else
            {
                cashDiscount -= 5;
            }
        }
    }
}
