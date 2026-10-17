using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            string name = txtName.Text.Trim();
            int age, nights, guests;


            bool isAgeValid = int.TryParse(txtAge.Text, out age);
            bool isNightsValid = int.TryParse(txtNights.Text, out nights);
            bool isGuestsValid = int.TryParse(txtGuest.Text, out guests);


            bool isApproved = true;
            string errorMessage = "";


            if (string.IsNullOrEmpty(name))
            {
                isApproved = false;
                errorMessage += "- Guest Name cannot be empty.\n";
            }

            if (!isAgeValid || age < 18 || age > 90)
            {
                isApproved = false;
                errorMessage += "- Guest age must be between 18 and 90.\n";
            }

            if (!isNightsValid || nights < 1 || nights > 30)
            {
                isApproved = false;
                errorMessage += "- Number of nights must be between 1 and 30.\n";
            }

            if (!isGuestsValid || guests < 1 || guests > 6)
            {
                isApproved = false;
                errorMessage += "- Number of guests must be between 1 and 6.\n";
            }


            if (rbStandard.Checked && guests > 2)
            {
                isApproved = false;
                errorMessage += "- Standard rooms can accommodate a maximum of 2 guests.\n";
            }
            else if (rbNormal.Checked && guests > 4)
            {
                isApproved = false;
                errorMessage += "- Normal (Deluxe) rooms can accommodate a maximum of 4 guests.\n";
            }

            if (!isApproved)
            {
                MessageBox.Show(errorMessage, "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }


            double roomRate = 0;
            string roomTypeName = "";


            if (rbStandard.Checked)
            {
                roomRate = 50;
                roomTypeName = "Standard";
            }
            else if (rbNormal.Checked)
            {
                roomRate = 80;
                roomTypeName = "Normal";
            }
            else if (rbHight.Checked)
            {
                roomRate = 130;
                roomTypeName = "Hight";
            }

            double totalCost = roomRate * nights;


            double discountPercent = 0;
            if (nights >= 10)
            {
                discountPercent = 0.12; // 12%
            }
            else if (nights >= 5 && nights <= 9)
            {
                discountPercent = 0.05; // 5%
            }
            double discountAmount = totalCost * discountPercent;
            totalCost -= discountAmount;


            double breakfastCost = 0;
            if (chkBreakfast    .Checked)
            {
                breakfastCost = 10 * guests * nights;
                totalCost += breakfastCost;
            }

            double serviceSurcharge = 0;
            if (guests > 4)
            {
                serviceSurcharge = totalCost * 0.05; // 5% surcharge
                totalCost += serviceSurcharge;
            }

            double seniorDiscount = 0;
            if (age >= 60)
            {
                seniorDiscount = totalCost * 0.05; // 5% discount
                totalCost -= seniorDiscount;
            }


            string details = "--- BOOKING APPROVED ---\n";
            details += $"Guest Name: {name}\n";
            details += $"Room Type: {roomTypeName}\n";
            details += $"Nights: {nights}\n";
            details += $"Guests: {guests}\n";
            details += "-------------------------\n";
            details += $"Base Cost: ${roomRate * nights:F2}\n";
            details += $"Long-Stay Discount: -${discountAmount:F2}\n";

            if (chkBreakfast.Checked)
                details += $"Breakfast Cost: +${breakfastCost:F2}\n";

            if (guests > 4)
                details += $"Service Surcharge (5%): +${serviceSurcharge:F2}\n";

            if (age >= 60)
                details += $"Senior Discount (5%): -${seniorDiscount:F2}\n";

            details += "-------------------------\n";
            details += $"TOTAL COST: ${totalCost:F2}\n";

            
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuest.Clear();
            chkBreakfast.Checked = false;
            rbStandard.Checked = true;
            
            txtName.Focus();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

