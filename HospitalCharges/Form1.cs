using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double dailyRate = 350;

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            textBoxTotalFee.Text = CalcTotalCharges().ToString();
        }

        private double CalcStayCharges()
        {
            double input;
            if (double.TryParse(textBoxBaseFee.Text, out input))
            {
                return dailyRate * input;
            }
            else
            {
                throw new System.InvalidCastException("Parameter must be a number");
                return 0;
            }

            
        }

        private double CalcMiscCharges()
        {

            double total = 0;
            double input;
            if (double.TryParse(textBoxLabFee.Text, out input))
            {
                total = total + input;
            }
            else
            {
                throw new System.InvalidCastException("Parameter must be a number");
            }
            if (double.TryParse(textBoxMedFee.Text, out input))
            {
                total = total + input;
            }
            else
            {
                throw new System.InvalidCastException("Parameter must be a number");
            }
            if (double.TryParse(textBoxRehabFee.Text, out input))
            {
                total = total + input;
            }
            else
            {
                throw new System.InvalidCastException("Parameter must be a number");
            }
            if (double.TryParse(textBoxSurgFee.Text, out input))
            {
                total = total + input;
            }
            else
            {
                throw new System.InvalidCastException("Parameter must be a number");
            }
            return total;

        }
        private double CalcTotalCharges()
        {
            try
            {
                double miscCharges = CalcMiscCharges();
                double baseCharges = CalcStayCharges();
                return miscCharges + baseCharges;
                 
            }
            catch (InvalidCastException ex)
            {
                labelStatus.Text = ex.Message;
                return 0;
            }

        }

        private void clearFrom()
        {
            textBoxLabFee.Clear();
            textBoxMedFee.Clear();
            textBoxRehabFee.Clear();
            textBoxSurgFee.Clear();
            textBoxBaseFee.Clear();
            textBoxTotalFee.Clear();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearFrom();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
