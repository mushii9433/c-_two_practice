using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelassigment
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
        {
            try
            {
                
                double nights = double.Parse(txtNights.Text);
                double price = double.Parse(txtpriceNights.Text);

                double subtotal = nights * price;
                double tax = subtotal * 0.10;
                double discount = subtotal * 0.05;

              
                lblServiceTax.Text = tax.ToString("C");
                lblDiscount.Text = discount.ToString("C");
                lblTotalAmount.Text = (subtotal + tax - discount).ToString("C");
            }
            catch (FormatException)
            {
               
                MessageBox.Show("please geli nambaro sax ah oo kaliya!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("error ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
}
