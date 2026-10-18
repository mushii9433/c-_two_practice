using System;
using System.Windows.Forms;

namespace UniversityRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            string studentName = txtEnterStudentName.Text;
            string studentId = txtEnterStudentid.Text;

            
            int courses;
            int studyYear;

            if (!int.TryParse(txtEnterNumberofcourses.Text, out courses) || !int.TryParse(txtEnterStudylevel.Text, out studyYear))
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah koorsooyinka iyo sannadka.");
                return;
            }

         
            if (courses < 1 || courses > 10)
            {
                MessageBox.Show("Courses must be between 1 and 10.");
                return;
            }

            if (studyYear < 1 || studyYear > 6)
            {
                MessageBox.Show("Study year must be between 1 and 6.");
                return;
            }

            
            double transportFee = 0;
            double tuition = courses * 100;
            double discount = 0;

            if (studyYear >= 3)
            {
                discount = tuition * 0.10;
            }

            double finalAmount = tuition - discount + transportFee;

            
            lblName.Text = "Name: " + studentName;
            lblid.Text = "ID: " + studentId;
            lblCourses.Text = "Number Courses: " + courses.ToString();
            lblStudyyear.Text = "Study year: " + studyYear.ToString();
            lblTransport.Text = "Transport Fee: " + transportFee.ToString();
            lblDiscount.Text = "Discount: " + discount.ToString();
            lblTution.Text = "Tuition fee: " + tuition.ToString();
            lblFInalAmount.Text = "Final Amount: " + finalAmount.ToString();
        }
    }
}