namespace Payroll_With_Overtime
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
            this.lblHourWorked = new System.Windows.Forms.Label();
            this.lblHourlyPayrate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.txtHourWorked = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtHourlyPayrate = new System.Windows.Forms.TextBox();
            this.btnCalculateGrossPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHourWorked
            // 
            this.lblHourWorked.AutoSize = true;
            this.lblHourWorked.Location = new System.Drawing.Point(165, 88);
            this.lblHourWorked.Name = "lblHourWorked";
            this.lblHourWorked.Size = new System.Drawing.Size(107, 20);
            this.lblHourWorked.TabIndex = 0;
            this.lblHourWorked.Text = "Hour Worked:";
            // 
            // lblHourlyPayrate
            // 
            this.lblHourlyPayrate.AutoSize = true;
            this.lblHourlyPayrate.Location = new System.Drawing.Point(165, 147);
            this.lblHourlyPayrate.Name = "lblHourlyPayrate";
            this.lblHourlyPayrate.Size = new System.Drawing.Size(120, 20);
            this.lblHourlyPayrate.TabIndex = 1;
            this.lblHourlyPayrate.Text = "Hourly Pay rate:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(165, 199);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(86, 20);
            this.lblGrossPay.TabIndex = 2;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // txtHourWorked
            // 
            this.txtHourWorked.Location = new System.Drawing.Point(416, 75);
            this.txtHourWorked.Name = "txtHourWorked";
            this.txtHourWorked.Size = new System.Drawing.Size(100, 26);
            this.txtHourWorked.TabIndex = 3;
            this.txtHourWorked.TextChanged += new System.EventHandler(this.txtHourWorked_TextChanged);
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(416, 218);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(100, 26);
            this.txtGrossPay.TabIndex = 4;
            // 
            // txtHourlyPayrate
            // 
            this.txtHourlyPayrate.Location = new System.Drawing.Point(416, 141);
            this.txtHourlyPayrate.Name = "txtHourlyPayrate";
            this.txtHourlyPayrate.Size = new System.Drawing.Size(100, 26);
            this.txtHourlyPayrate.TabIndex = 5;
            // 
            // btnCalculateGrossPay
            // 
            this.btnCalculateGrossPay.Location = new System.Drawing.Point(68, 377);
            this.btnCalculateGrossPay.Name = "btnCalculateGrossPay";
            this.btnCalculateGrossPay.Size = new System.Drawing.Size(183, 76);
            this.btnCalculateGrossPay.TabIndex = 6;
            this.btnCalculateGrossPay.Text = "Calculate Gross Pay";
            this.btnCalculateGrossPay.UseVisualStyleBackColor = true;
            this.btnCalculateGrossPay.Click += new System.EventHandler(this.btnCalculateGrossPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(327, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 58);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(520, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 527);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateGrossPay);
            this.Controls.Add(this.txtHourlyPayrate);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtHourWorked);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblHourlyPayrate);
            this.Controls.Add(this.lblHourWorked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHourWorked;
        private System.Windows.Forms.Label lblHourlyPayrate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.TextBox txtHourWorked;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtHourlyPayrate;
        private System.Windows.Forms.Button btnCalculateGrossPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

