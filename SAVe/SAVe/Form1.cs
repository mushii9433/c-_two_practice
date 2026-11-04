using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAVe
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

        private void btnSave_Click(object sender, EventArgs e)
        {
           


            StreamWriter Writes;
            DialogResult result;

            saveFileDialog1.FileName = "";

            result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Writes = File.AppendText(saveFileDialog1.FileName);

                Writes.WriteLine(txtUserInput.Text);

                Writes.Close();

                MessageBox.Show("File Saved Successfully");
            }
            else
            {
                MessageBox.Show("File was not saved");
            }
        }
    }
}
