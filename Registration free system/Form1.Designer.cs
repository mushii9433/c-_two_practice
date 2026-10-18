using System;

namespace UniversityRegistration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudyyear = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtEnterStudentName = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtEnterStudylevel = new System.Windows.Forms.TextBox();
            this.txtEnterNumberofcourses = new System.Windows.Forms.TextBox();
            this.txtEnterStudentid = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTution = new System.Windows.Forms.Label();
            this.lblFInalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(303, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registration fee system";
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(175, 196);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(210, 20);
            this.lblCourses.TabIndex = 1;
            this.lblCourses.Text = "Enter Number of courses     :";
            this.lblCourses.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(175, 152);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(149, 20);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "Enter Student id     :";
            this.lblid.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(175, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(179, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Student Name     :";
            // 
            // lblStudyyear
            // 
            this.lblStudyyear.AutoSize = true;
            this.lblStudyyear.Location = new System.Drawing.Point(175, 248);
            this.lblStudyyear.Name = "lblStudyyear";
            this.lblStudyyear.Size = new System.Drawing.Size(152, 20);
            this.lblStudyyear.TabIndex = 4;
            this.lblStudyyear.Text = "Enter Study level     :";
            this.lblStudyyear.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(175, 302);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(128, 20);
            this.lblTransport.TabIndex = 5;
            this.lblTransport.Text = "Transport fee     :";
            // 
            // txtEnterStudentName
            // 
            this.txtEnterStudentName.Location = new System.Drawing.Point(477, 95);
            this.txtEnterStudentName.Name = "txtEnterStudentName";
            this.txtEnterStudentName.Size = new System.Drawing.Size(100, 26);
            this.txtEnterStudentName.TabIndex = 6;
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(477, 296);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(100, 26);
            this.txtTransport.TabIndex = 8;
            // 
            // txtEnterStudylevel
            // 
            this.txtEnterStudylevel.Location = new System.Drawing.Point(477, 245);
            this.txtEnterStudylevel.Name = "txtEnterStudylevel";
            this.txtEnterStudylevel.Size = new System.Drawing.Size(100, 26);
            this.txtEnterStudylevel.TabIndex = 9;
            // 
            // txtEnterNumberofcourses
            // 
            this.txtEnterNumberofcourses.Location = new System.Drawing.Point(477, 190);
            this.txtEnterNumberofcourses.Name = "txtEnterNumberofcourses";
            this.txtEnterNumberofcourses.Size = new System.Drawing.Size(100, 26);
            this.txtEnterNumberofcourses.TabIndex = 10;
            // 
            // txtEnterStudentid
            // 
            this.txtEnterStudentid.Location = new System.Drawing.Point(477, 146);
            this.txtEnterStudentid.Name = "txtEnterStudentid";
            this.txtEnterStudentid.Size = new System.Drawing.Size(100, 26);
            this.txtEnterStudentid.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(160, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 52);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(402, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 52);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(664, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 52);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(233, 513);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(88, 20);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "Discount   :";
            // 
            // lblTution
            // 
            this.lblTution.AutoSize = true;
            this.lblTution.Location = new System.Drawing.Point(233, 556);
            this.lblTution.Name = "lblTution";
            this.lblTution.Size = new System.Drawing.Size(96, 20);
            this.lblTution.TabIndex = 21;
            this.lblTution.Text = "Tution fee  : ";
            // 
            // lblFInalAmount
            // 
            this.lblFInalAmount.AutoSize = true;
            this.lblFInalAmount.Location = new System.Drawing.Point(233, 600);
            this.lblFInalAmount.Name = "lblFInalAmount";
            this.lblFInalAmount.Size = new System.Drawing.Size(117, 20);
            this.lblFInalAmount.TabIndex = 22;
            this.lblFInalAmount.Text = "Final amount   :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 697);
            this.Controls.Add(this.lblFInalAmount);
            this.Controls.Add(this.lblTution);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterStudentid);
            this.Controls.Add(this.txtEnterNumberofcourses);
            this.Controls.Add(this.txtEnterStudylevel);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.txtEnterStudentName);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblStudyyear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudyyear;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtEnterStudentName;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.TextBox txtEnterStudylevel;
        private System.Windows.Forms.TextBox txtEnterNumberofcourses;
        private System.Windows.Forms.TextBox txtEnterStudentid;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTution;
        private System.Windows.Forms.Label lblFInalAmount;
    }
}

