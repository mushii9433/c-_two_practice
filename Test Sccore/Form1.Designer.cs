namespace Test_Score
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
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Location = new System.Drawing.Point(100, 61);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(104, 20);
            this.lblscore1.TabIndex = 0;
            this.lblscore1.Text = "Test Score#1";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Location = new System.Drawing.Point(100, 118);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(104, 20);
            this.lblscore2.TabIndex = 1;
            this.lblscore2.Text = "Test Score#2";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Location = new System.Drawing.Point(100, 181);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(104, 20);
            this.lblscore3.TabIndex = 2;
            this.lblscore3.Text = "Test Score#3";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(136, 239);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(303, 55);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 26);
            this.txtScore1.TabIndex = 5;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(303, 115);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 26);
            this.txtScore2.TabIndex = 6;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(303, 175);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 26);
            this.txtScore3.TabIndex = 7;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(303, 233);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 26);
            this.txtAverage.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(130, 388);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 112);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(388, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(388, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 542);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblscore3);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

