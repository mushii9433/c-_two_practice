using System;
using System.Windows.Forms;

namespace AirlineTicketBookingSystem
{
    public partial class Form1 : Form
    {
        bool bookingApproved = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bookingApproved = false;

            string name = txtpassengerName.Text.Trim();

            int age, tickets;
            double baggage;

            if (name == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtpassengerAge.Text, out age) ||
                !int.TryParse(txtNumberTickets.Text, out tickets) ||
                !double.TryParse(txtBaggageWeight.Text, out baggage))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (baggage < 0 || baggage > 50 * tickets)
            {
                MessageBox.Show(
                    "Baggage cannot exceed 50 kg per passenger.");
                return;
            }

            if (!rbFirstClass.Checked &&
                !rbNormalClass.Checked &&
                !rbBusinessClass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            if (age < 12 && rbFirstClass.Checked)
            {
                MessageBox.Show(
                    "Passengers below 12 cannot book First Class.");
                return;
            }

            // Ticket price according to travel class
            double ticketPrice;

            if (rbFirstClass.Checked)
                ticketPrice = 300;
            else if (rbBusinessClass.Checked)
                ticketPrice = 200;
            else
                ticketPrice = 100;

            double basicCost = ticketPrice * tickets;

            // Discount for number of tickets
            double ticketDiscountRate = 0;

            if (tickets == 5)
                ticketDiscountRate = 0.10;
            else if (tickets >= 3)
                ticketDiscountRate = 0.05;

            double ticketDiscount =
                basicCost * ticketDiscountRate;

            // Child or senior discount
            double ageDiscountRate = 0;

            if (age < 12)
                ageDiscountRate = 0.20;
            else if (age >= 60)
                ageDiscountRate = 0.10;

            double ageDiscount =
                basicCost * ageDiscountRate;

            double totalDiscount =
                ticketDiscount + ageDiscount;

            // Insurance costs $25 per ticket
            double insuranceCost = chkInsurence.Checked
                ? 25 * tickets
                : 0;

            double finalAmount =
                basicCost - totalDiscount + insuranceCost;

            bookingApproved = true;

            string travelClass;

            if (rbFirstClass.Checked)
                travelClass = "First Class";
            else if (rbBusinessClass.Checked)
                travelClass = "Business Class";
            else
                travelClass = "Normal Class";

            string baggageMessage =
                baggage <= 20 * tickets
                ? "Free"
                : "Exceeds free baggage allowance";

                 txtNumberTickets.Text =
                "AIRLINE BOOKING DETAILS\n" +
                "------------------------------\r\n" +
                "Passenger Name: " + name + "\r\n" +
                "Passenger Age: " + age + "\r\n" +
                "Number of Tickets: " + tickets + "\r\n" +
                "Travel Class: " + travelClass + "\r\n" +
                "Baggage Weight: " + baggage + " kg\r\n" +
                "Baggage Status: " + baggageMessage + "\r\n" +
                "Basic Ticket Cost: $" + basicCost.ToString("0.00") + "\r\n" +
                "Ticket Discount: $" + ticketDiscount.ToString("0.00") + "\r\n" +
                "Age Discount: $" + ageDiscount.ToString("0.00") + "\r\n" +
                "Total Discount: $" + totalDiscount.ToString("0.00") + "\r\n" +
                "Insurance: $" + insuranceCost.ToString("0.00") + "\r\n" +
                "FINAL AMOUNT: $" + finalAmount.ToString("0.00") + "\r\n" +
                "Booking Approved: " + bookingApproved;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpassengerName.Clear();
            txtpassengerAge.Clear();
            txtNumberTickets.Clear();
            txtBaggageWeight.Clear();
            

            rbFirstClass.Checked = false;
            rbNormalClass.Checked = false;
            rbBusinessClass.Checked = false;
            chkInsurence.Checked = false;

            bookingApproved = false;

            txtpassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}