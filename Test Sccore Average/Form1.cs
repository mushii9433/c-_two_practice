using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Test Score Average + Validation + Nested Loop

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TextBox[] scoreBoxes = { txtScore1, txtScore2, txtScore3 };
            double[] scores = new double[3];
            // Nested Loop - Check Validation
            for (int i = 0; i < scoreBoxes.Length; i++)
            {
                bool valid = false;
                while (!valid)
                {
                    if (double.TryParse(scoreBoxes[i].Text, out scores[i]))
                    {
                        if (scores[i] >= 0 && scores[i] <= 100)
                        {
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Score must be between 0 and 100.");
                            scoreBoxes[i].Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid score.");
                        scoreBoxes[i].Focus();
                        return;
                    }
                }
            }
            // Calculate Average
            double total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            double average = total / scores.Length;
            txtAverage.Text = average.ToString("0.0");
        }
        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtAverage.Clear();
            txtScore1.Focus();
        }
        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}