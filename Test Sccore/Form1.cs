using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score
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
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score1 = Convert.ToDouble(txtScore1.Text);
            double score2 = Convert.ToDouble(txtScore2.Text);
            double score3 = Convert.ToDouble(txtScore3.Text);

            double average = (score1 + score2 + score3) / 3;

            txtAverage.Text = average.ToString("0.0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtAverage.Clear();

            txtScore1.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
