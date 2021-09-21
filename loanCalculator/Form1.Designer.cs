
namespace loanCalculator
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
            this.lbl_startingBalance = new System.Windows.Forms.Label();
            this.lbl_numMonths = new System.Windows.Forms.Label();
            this.lbl_interestRate = new System.Windows.Forms.Label();
            this.txt_startingBalance = new System.Windows.Forms.TextBox();
            this.txt_numMonths = new System.Windows.Forms.TextBox();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_endingBalance = new System.Windows.Forms.Label();
            this.txt_endingBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_startingBalance
            // 
            this.lbl_startingBalance.AutoSize = true;
            this.lbl_startingBalance.Location = new System.Drawing.Point(133, 50);
            this.lbl_startingBalance.Name = "lbl_startingBalance";
            this.lbl_startingBalance.Size = new System.Drawing.Size(109, 16);
            this.lbl_startingBalance.TabIndex = 0;
            this.lbl_startingBalance.Text = "Starting Balance:";
            // 
            // lbl_numMonths
            // 
            this.lbl_numMonths.AutoSize = true;
            this.lbl_numMonths.Location = new System.Drawing.Point(133, 90);
            this.lbl_numMonths.Name = "lbl_numMonths";
            this.lbl_numMonths.Size = new System.Drawing.Size(119, 16);
            this.lbl_numMonths.TabIndex = 1;
            this.lbl_numMonths.Text = "Number of Months:";
            // 
            // lbl_interestRate
            // 
            this.lbl_interestRate.AutoSize = true;
            this.lbl_interestRate.Location = new System.Drawing.Point(133, 133);
            this.lbl_interestRate.Name = "lbl_interestRate";
            this.lbl_interestRate.Size = new System.Drawing.Size(86, 16);
            this.lbl_interestRate.TabIndex = 2;
            this.lbl_interestRate.Text = "Interest Rate:";
            // 
            // txt_startingBalance
            // 
            this.txt_startingBalance.Location = new System.Drawing.Point(267, 50);
            this.txt_startingBalance.Name = "txt_startingBalance";
            this.txt_startingBalance.Size = new System.Drawing.Size(100, 22);
            this.txt_startingBalance.TabIndex = 3;
            // 
            // txt_numMonths
            // 
            this.txt_numMonths.Location = new System.Drawing.Point(267, 84);
            this.txt_numMonths.Name = "txt_numMonths";
            this.txt_numMonths.Size = new System.Drawing.Size(100, 22);
            this.txt_numMonths.TabIndex = 4;
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Location = new System.Drawing.Point(267, 127);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(100, 22);
            this.txt_interestRate.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(136, 194);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 132);
            this.listBox1.TabIndex = 6;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(136, 387);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(92, 33);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(265, 387);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(377, 387);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 33);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_endingBalance
            // 
            this.lbl_endingBalance.AutoSize = true;
            this.lbl_endingBalance.Location = new System.Drawing.Point(136, 349);
            this.lbl_endingBalance.Name = "lbl_endingBalance";
            this.lbl_endingBalance.Size = new System.Drawing.Size(106, 16);
            this.lbl_endingBalance.TabIndex = 10;
            this.lbl_endingBalance.Text = "Ending Balance:";
            // 
            // txt_endingBalance
            // 
            this.txt_endingBalance.Location = new System.Drawing.Point(267, 342);
            this.txt_endingBalance.Name = "txt_endingBalance";
            this.txt_endingBalance.ReadOnly = true;
            this.txt_endingBalance.Size = new System.Drawing.Size(100, 22);
            this.txt_endingBalance.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.txt_endingBalance);
            this.Controls.Add(this.lbl_endingBalance);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.txt_numMonths);
            this.Controls.Add(this.txt_startingBalance);
            this.Controls.Add(this.lbl_interestRate);
            this.Controls.Add(this.lbl_numMonths);
            this.Controls.Add(this.lbl_startingBalance);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startingBalance;
        private System.Windows.Forms.Label lbl_numMonths;
        private System.Windows.Forms.Label lbl_interestRate;
        private System.Windows.Forms.TextBox txt_startingBalance;
        private System.Windows.Forms.TextBox txt_numMonths;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_endingBalance;
        private System.Windows.Forms.TextBox txt_endingBalance;
    }
}

