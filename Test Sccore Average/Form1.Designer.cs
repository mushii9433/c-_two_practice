namespace Test_Score_Average
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
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(135, 81);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(100, 20);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "TestScore#1";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(135, 148);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(100, 20);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "TestScore#2";
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Location = new System.Drawing.Point(135, 199);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(100, 20);
            this.lblScore3.TabIndex = 2;
            this.lblScore3.Text = "TestScore#3";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(135, 256);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(355, 92);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 26);
            this.txtScore1.TabIndex = 4;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(355, 193);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 26);
            this.txtScore3.TabIndex = 5;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(355, 142);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 26);
            this.txtScore2.TabIndex = 6;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(355, 250);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 26);
            this.txtAverage.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 129);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(274, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 583);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

