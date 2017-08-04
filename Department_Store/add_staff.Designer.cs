namespace Department_Store
{
    partial class add_staff
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
            this.label6 = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.TextBox();
            this.staff_name = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.designation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.messagebox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deisgnation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // staff_id
            // 
            this.staff_id.Location = new System.Drawing.Point(173, 41);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(100, 20);
            this.staff_id.TabIndex = 5;
            // 
            // staff_name
            // 
            this.staff_name.Location = new System.Drawing.Point(173, 84);
            this.staff_name.Name = "staff_name";
            this.staff_name.Size = new System.Drawing.Size(100, 20);
            this.staff_name.TabIndex = 6;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(173, 280);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 11;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(173, 237);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 10;
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(173, 196);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD STAFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // designation
            // 
            this.designation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.designation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.designation.FormattingEnabled = true;
            this.designation.Items.AddRange(new object[] {
            "Cashier",
            "Accountant",
            "Sales Boy",
            "Cleaner",
            "Guard"});
            this.designation.Location = new System.Drawing.Point(173, 156);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(100, 21);
            this.designation.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            // 
            // sex
            // 
            this.sex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.sex.Location = new System.Drawing.Point(173, 120);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 21);
            this.sex.TabIndex = 7;
            // 
            // messagebox
            // 
            this.messagebox.AutoSize = true;
            this.messagebox.Location = new System.Drawing.Point(43, 385);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(0, 13);
            this.messagebox.TabIndex = 17;
            // 
            // add_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 422);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.staff_name);
            this.Controls.Add(this.staff_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_staff";
            this.Text = "add_staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_staff_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox staff_id;
        private System.Windows.Forms.TextBox staff_name;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox designation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label messagebox;
    }
}