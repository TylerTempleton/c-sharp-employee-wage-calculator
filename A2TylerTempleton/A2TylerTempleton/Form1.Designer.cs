namespace A2TylerTempleton
{
    partial class WageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.managerBox = new System.Windows.Forms.CheckBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.wageBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.netBox = new System.Windows.Forms.TextBox();
            this.fwtBox = new System.Windows.Forms.TextBox();
            this.earningsBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Wage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gross Earnings";
            // 
            // managerBox
            // 
            this.managerBox.AutoSize = true;
            this.managerBox.Location = new System.Drawing.Point(75, 153);
            this.managerBox.Name = "managerBox";
            this.managerBox.Size = new System.Drawing.Size(15, 14);
            this.managerBox.TabIndex = 5;
            this.managerBox.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(88, 21);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(419, 20);
            this.nameBox.TabIndex = 6;
            // 
            // wageBox
            // 
            this.wageBox.Location = new System.Drawing.Point(88, 62);
            this.wageBox.Name = "wageBox";
            this.wageBox.Size = new System.Drawing.Size(419, 20);
            this.wageBox.TabIndex = 7;
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(88, 101);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(419, 20);
            this.hoursBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.managerBox);
            this.groupBox1.Controls.Add(this.hoursBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wageBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please input the employee information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.netBox);
            this.groupBox2.Controls.Add(this.fwtBox);
            this.groupBox2.Controls.Add(this.earningsBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 188);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated Wage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Net Earnings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Less FWT";
            // 
            // netBox
            // 
            this.netBox.Enabled = false;
            this.netBox.Location = new System.Drawing.Point(88, 140);
            this.netBox.Name = "netBox";
            this.netBox.ReadOnly = true;
            this.netBox.Size = new System.Drawing.Size(419, 20);
            this.netBox.TabIndex = 7;
            // 
            // fwtBox
            // 
            this.fwtBox.Enabled = false;
            this.fwtBox.Location = new System.Drawing.Point(88, 85);
            this.fwtBox.Name = "fwtBox";
            this.fwtBox.ReadOnly = true;
            this.fwtBox.Size = new System.Drawing.Size(419, 20);
            this.fwtBox.TabIndex = 6;
            // 
            // earningsBox
            // 
            this.earningsBox.Enabled = false;
            this.earningsBox.Location = new System.Drawing.Point(88, 31);
            this.earningsBox.Name = "earningsBox";
            this.earningsBox.ReadOnly = true;
            this.earningsBox.Size = new System.Drawing.Size(419, 20);
            this.earningsBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Employees";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // employeeBox
            // 
            this.employeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(100, 477);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(226, 21);
            this.employeeBox.Sorted = true;
            this.employeeBox.TabIndex = 13;
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.employeeBox_SelectedIndexChanged);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(21, 227);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "Calcuate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(502, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(502, 503);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // WageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 536);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.WageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox managerBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox wageBox;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox netBox;
        private System.Windows.Forms.TextBox fwtBox;
        private System.Windows.Forms.TextBox earningsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
    }
}

