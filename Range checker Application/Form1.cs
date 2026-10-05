using System;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Check Qualification Button
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtInput.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    txtResult.Text =
                        "Valid! The number is within the range of 1 through 10.";
                }
                else
                {
                    txtResult.Text =
                        "Invalid! The number must be between 1 and 10.";
                }
            }
            else
            {
                txtResult.Text =
                    "Please enter a valid integer.";
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtResult.Clear();
            txtInput.Focus();
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}