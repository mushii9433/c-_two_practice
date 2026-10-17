namespace AirlineTicketBookingSystem
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
            this.txtpassengerName = new System.Windows.Forms.TextBox();
            this.txtNumberTickets = new System.Windows.Forms.TextBox();
            this.txtpassengerAge = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.rbFirstClass = new System.Windows.Forms.RadioButton();
            this.rbNormalClass = new System.Windows.Forms.RadioButton();
            this.rbBusinessClass = new System.Windows.Forms.RadioButton();
            this.chkInsurence = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTravelClass = new System.Windows.Forms.Label();
            this.lblAdditionalOption = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblNumberofcticekts = new System.Windows.Forms.Label();
            this.lblBaggageweight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpassengerName
            // 
            this.txtpassengerName.Location = new System.Drawing.Point(665, 64);
            this.txtpassengerName.Name = "txtpassengerName";
            this.txtpassengerName.Size = new System.Drawing.Size(100, 26);
            this.txtpassengerName.TabIndex = 0;
            // 
            // txtNumberTickets
            // 
            this.txtNumberTickets.Location = new System.Drawing.Point(665, 180);
            this.txtNumberTickets.Name = "txtNumberTickets";
            this.txtNumberTickets.Size = new System.Drawing.Size(100, 26);
            this.txtNumberTickets.TabIndex = 1;
            // 
            // txtpassengerAge
            // 
            this.txtpassengerAge.Location = new System.Drawing.Point(665, 119);
            this.txtpassengerAge.Name = "txtpassengerAge";
            this.txtpassengerAge.Size = new System.Drawing.Size(100, 26);
            this.txtpassengerAge.TabIndex = 2;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(665, 234);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(100, 26);
            this.txtBaggageWeight.TabIndex = 3;
            // 
            // rbFirstClass
            // 
            this.rbFirstClass.AutoSize = true;
            this.rbFirstClass.Location = new System.Drawing.Point(107, 393);
            this.rbFirstClass.Name = "rbFirstClass";
            this.rbFirstClass.Size = new System.Drawing.Size(108, 24);
            this.rbFirstClass.TabIndex = 4;
            this.rbFirstClass.TabStop = true;
            this.rbFirstClass.Text = "First Class";
            this.rbFirstClass.UseVisualStyleBackColor = true;
            // 
            // rbNormalClass
            // 
            this.rbNormalClass.AutoSize = true;
            this.rbNormalClass.Location = new System.Drawing.Point(302, 393);
            this.rbNormalClass.Name = "rbNormalClass";
            this.rbNormalClass.Size = new System.Drawing.Size(127, 24);
            this.rbNormalClass.TabIndex = 5;
            this.rbNormalClass.TabStop = true;
            this.rbNormalClass.Text = "Normal Class";
            this.rbNormalClass.UseVisualStyleBackColor = true;
            // 
            // rbBusinessClass
            // 
            this.rbBusinessClass.AutoSize = true;
            this.rbBusinessClass.Location = new System.Drawing.Point(517, 393);
            this.rbBusinessClass.Name = "rbBusinessClass";
            this.rbBusinessClass.Size = new System.Drawing.Size(142, 24);
            this.rbBusinessClass.TabIndex = 6;
            this.rbBusinessClass.TabStop = true;
            this.rbBusinessClass.Text = "Business Class";
            this.rbBusinessClass.UseVisualStyleBackColor = true;
            // 
            // chkInsurence
            // 
            this.chkInsurence.AutoSize = true;
            this.chkInsurence.Location = new System.Drawing.Point(107, 503);
            this.chkInsurence.Name = "chkInsurence";
            this.chkInsurence.Size = new System.Drawing.Size(291, 24);
            this.chkInsurence.TabIndex = 7;
            this.chkInsurence.Text = "Add Travel Insurence($25per Ticket)";
            this.chkInsurence.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(107, 586);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 36);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(302, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblTravelClass
            // 
            this.lblTravelClass.AutoSize = true;
            this.lblTravelClass.Location = new System.Drawing.Point(51, 316);
            this.lblTravelClass.Name = "lblTravelClass";
            this.lblTravelClass.Size = new System.Drawing.Size(94, 20);
            this.lblTravelClass.TabIndex = 11;
            this.lblTravelClass.Text = "Travel Class";
            // 
            // lblAdditionalOption
            // 
            this.lblAdditionalOption.AutoSize = true;
            this.lblAdditionalOption.Location = new System.Drawing.Point(51, 448);
            this.lblAdditionalOption.Name = "lblAdditionalOption";
            this.lblAdditionalOption.Size = new System.Drawing.Size(127, 20);
            this.lblAdditionalOption.TabIndex = 12;
            this.lblAdditionalOption.Text = "Additonal Option";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(228, 67);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(155, 20);
            this.lblPassengerName.TabIndex = 13;
            this.lblPassengerName.Text = "Passenger Name     :";
            this.lblPassengerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Location = new System.Drawing.Point(228, 125);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(142, 20);
            this.lblPassengerAge.TabIndex = 14;
            this.lblPassengerAge.Text = "Passenger Age     :";
            // 
            // lblNumberofcticekts
            // 
            this.lblNumberofcticekts.AutoSize = true;
            this.lblNumberofcticekts.Location = new System.Drawing.Point(228, 186);
            this.lblNumberofcticekts.Name = "lblNumberofcticekts";
            this.lblNumberofcticekts.Size = new System.Drawing.Size(169, 20);
            this.lblNumberofcticekts.TabIndex = 15;
            this.lblNumberofcticekts.Text = "Number of tickets     :   ";
            // 
            // lblBaggageweight
            // 
            this.lblBaggageweight.AutoSize = true;
            this.lblBaggageweight.Location = new System.Drawing.Point(228, 240);
            this.lblBaggageweight.Name = "lblBaggageweight";
            this.lblBaggageweight.Size = new System.Drawing.Size(179, 20);
            this.lblBaggageweight.TabIndex = 16;
            this.lblBaggageweight.Text = "Baggage Weight(kg)     :";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 702);
            this.Controls.Add(this.lblBaggageweight);
            this.Controls.Add(this.lblNumberofcticekts);
            this.Controls.Add(this.lblPassengerAge);
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.lblAdditionalOption);
            this.Controls.Add(this.lblTravelClass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkInsurence);
            this.Controls.Add(this.rbBusinessClass);
            this.Controls.Add(this.rbNormalClass);
            this.Controls.Add(this.rbFirstClass);
            this.Controls.Add(this.txtBaggageWeight);
            this.Controls.Add(this.txtpassengerAge);
            this.Controls.Add(this.txtNumberTickets);
            this.Controls.Add(this.txtpassengerName);
            this.Name = "form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.lblTravelClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassengerName;
        private System.Windows.Forms.TextBox txtNumberTickets;
        private System.Windows.Forms.TextBox txtpassengerAge;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.RadioButton rbFirstClass;
        private System.Windows.Forms.RadioButton rbNormalClass;
        private System.Windows.Forms.RadioButton rbBusinessClass;
        private System.Windows.Forms.CheckBox chkInsurence;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTravelClass;
        private System.Windows.Forms.Label lblAdditionalOption;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblNumberofcticekts;
        private System.Windows.Forms.Label lblBaggageweight;
    }
}

