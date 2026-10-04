using System;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. BADHANKA CALCULATE GROSS PAY
        
        private void btnCalculateGrossPay_Click(object sender, EventArgs e)
        {
            // --- QAYBTA 1AAD: HUBINTA XOGTA (VALIDATION) ---

            // Hubi in aanay meel bannaan ahayn
            if (string.IsNullOrWhiteSpace(txtHourWorked.Text) ||
                string.IsNullOrWhiteSpace(txtHourlyPayrate.Text))
            {
                MessageBox.Show("Fadlan buuxi dhammaan meelaha bannaan.", "Khalad");
                return; // Jooji shaqada
            }

            // Hubi in xogta la geliyay ay tahay tiro (number)
            if (!double.TryParse(txtHourWorked.Text, out double hoursWorked) ||
                !double.TryParse(txtHourlyPayrate.Text, out double hourlyRate))
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah oo keliya.", "Khalad");
                return; // Jooji shaqada
            }

            // Hubi in aanay tirooyinku taban ahayn (negative)
            if (hoursWorked < 0 || hourlyRate < 0)
            {
                MessageBox.Show("Saacadaha iyo lacagta waa in aanay taban ahayn.", "Khalad");
                return;
            }

            // --- QAYBTA 2AAD: XISAABTA (NESTED LOOP) ---
            double grossPay = 0;

            // Loop-ka dibadda (Saacadaha)
            for (int i = 0; i < hoursWorked; i++)
            {
                // Loop-ka gudaha (Nested Loop)
                for (int j = 0; j < 1; j++)
                {
                    if (i < 40)
                    {
                        // 40 saacadood ee ugu horreeya: lacagta caadiga ah
                        grossPay += hourlyRate;
                    }
                    else
                    {
                        // Saacadaha dheeraadka ah (Overtime): 1.5 jeer lacagta caadiga ah
                        grossPay += (hourlyRate * 1.5);
                    }
                }
            }

            // --- QAYBTA 3AAD: SOO BANDHIGA NATIIJADA ---
            // U qaabee lacag ahaan (Tusaale: $1,234.56)
            lblGrossPay.Text = grossPay.ToString("C2");
        }

       
        // 2. BADHANKA CLEAR
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Nadiifi dhammaan sanduuqyada
            txtHourWorked.Clear();
            txtHourlyPayrate.Clear();
            lblGrossPay.Text = "";

            // Soo celi cursor-ka (focus) sanduuqa ugu horreeya
            txtHourWorked.Focus();
        }

      
      
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xir barnaamijka
            this.Close();
        }

       
        
      
        private void txtHourWorked_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtHourWorked.Clear();
            txtHourlyPayrate.Clear();
            lblGrossPay.Text = "";
            txtHourWorked.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      
    }
    }
    