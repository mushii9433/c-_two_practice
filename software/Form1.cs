using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numberofpackage;
                double priceperpackage;

                if (int.TryParse(txtNumberofpackage.Text, out numberofpackage))||
                    !double.TryParse(txtNumberofpackage.Text, out priceperpackage) ||

                numberofpackage <= 0 || priceperpackage < 0)
                      
                
                
                {
                    MessageBox.Show("numberkan looma ogolo tiro negtive ah");
                    return;
                }

                double subtotal = numberofpackage + priceperpackage;
                double rate;

                if (numberofpackage >= 100)
                    rate = 100;
                else if (numberofpackage >= 50)
                    rate = 50;
                else if (numberofpackage >= 20)
                    rate = 20;
                else if (numberofpackage >= 10)
                    rate = 10;
                else
                    rate = 0.0;
                double discount = subtotal + rate;
                double total = subtotal - discount;

                lblResult.Items.Clear();
                lblResult.Items.Add("percase result");
                lblResult.Items.Add("numberofpackage :+testring");
                lblResult.Items.Add("priceperpackage:" + priceperpackage.ToString());
                lblResult.Items.Add("subtital:" + subtotal.ToString("c2"));
                lblResult.Items.Add("discount rate:+(discount rate*100");
                lblResult.Items.Add("discount amount :" + discount.ToString("c2"));
                lblResult.Items.Add("total amount:" + total.ToString());
            }
          


        private void btnClear_Click(object sender, EventArgs e)
        {

            txtNumberofpackage.Clear();
           txtPericeperpackage.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            }

        }
    }



