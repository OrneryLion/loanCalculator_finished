using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loanCalculator
{
    public partial class Form1 : Form
    {
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.005m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // assign new values to the variables. 
            if (decimal.TryParse(txt_startingBalance.Text, out loan_amount))
            {
                if (int.TryParse(txt_numMonths.Text, out number_of_months))
                {
                    if (decimal.TryParse(txt_interestRate.Text, out interest_rate))
                    {
                        // Success

                        // calculate the loan
                        int counter = 0;
                        while (counter < number_of_months)
                        {
                            loan_amount = loan_amount + loan_amount * interest_rate;
                            listBox1.Items.Add("At Month " + counter + " the loan is " + loan_amount.ToString("c"));
                            counter = counter + 1;
                        }
                        txt_endingBalance.Text = loan_amount.ToString("c"); 
                    }



                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_startingBalance.Clear();
            txt_numMonths.Clear();
            txt_interestRate.Clear();
            txt_endingBalance.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
