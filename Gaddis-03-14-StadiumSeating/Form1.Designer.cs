namespace stadiumSeating
{
    partial class frmStadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassAIncome = new System.Windows.Forms.TextBox();
            this.txtClassBIncome = new System.Windows.Forms.TextBox();
            this.txtClassCIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateIncome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(297, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(88, 117);
            this.txtClassA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(148, 26);
            this.txtClassA.TabIndex = 0;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(88, 177);
            this.txtClassB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(148, 26);
            this.txtClassB.TabIndex = 1;
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(88, 231);
            this.txtClassC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(148, 26);
            this.txtClassC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold\r\nfor each class of seats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalIncome);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtClassAIncome);
            this.groupBox2.Controls.Add(this.txtClassBIncome);
            this.groupBox2.Controls.Add(this.txtClassCIncome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(366, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(297, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Location = new System.Drawing.Point(88, 231);
            this.txtTotalIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(148, 26);
            this.txtTotalIncome.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total";
            // 
            // txtClassAIncome
            // 
            this.txtClassAIncome.Location = new System.Drawing.Point(88, 60);
            this.txtClassAIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassAIncome.Name = "txtClassAIncome";
            this.txtClassAIncome.ReadOnly = true;
            this.txtClassAIncome.Size = new System.Drawing.Size(148, 26);
            this.txtClassAIncome.TabIndex = 6;
            // 
            // txtClassBIncome
            // 
            this.txtClassBIncome.Location = new System.Drawing.Point(88, 117);
            this.txtClassBIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassBIncome.Name = "txtClassBIncome";
            this.txtClassBIncome.ReadOnly = true;
            this.txtClassBIncome.Size = new System.Drawing.Size(148, 26);
            this.txtClassBIncome.TabIndex = 7;
            // 
            // txtClassCIncome
            // 
            this.txtClassCIncome.Location = new System.Drawing.Point(88, 177);
            this.txtClassCIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassCIncome.Name = "txtClassCIncome";
            this.txtClassCIncome.ReadOnly = true;
            this.txtClassCIncome.Size = new System.Drawing.Size(148, 26);
            this.txtClassCIncome.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class A";
            // 
            // btnCalculateIncome
            // 
            this.btnCalculateIncome.Location = new System.Drawing.Point(144, 345);
            this.btnCalculateIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculateIncome.Name = "btnCalculateIncome";
            this.btnCalculateIncome.Size = new System.Drawing.Size(112, 65);
            this.btnCalculateIncome.TabIndex = 3;
            this.btnCalculateIncome.Text = "Calculate Income";
            this.btnCalculateIncome.UseVisualStyleBackColor = true;
            this.btnCalculateIncome.Click += new System.EventHandler(this.btnCalculateIncome_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 345);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 65);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 345);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 65);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateIncome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStadiumSeating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.frmStadiumSeating_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassAIncome;
        private System.Windows.Forms.TextBox txtClassBIncome;
        private System.Windows.Forms.TextBox txtClassCIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateIncome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

