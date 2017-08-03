namespace Department_Store
{
    partial class Product_info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(559, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.masterEntryToolStripMenuItem,
            this.salesDataToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.productToolStripMenuItem,
            this.enquiryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // masterEntryToolStripMenuItem
            // 
            this.masterEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.masterEntryToolStripMenuItem.Name = "masterEntryToolStripMenuItem";
            this.masterEntryToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.masterEntryToolStripMenuItem.Text = "Master Entry";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // salesDataToolStripMenuItem
            // 
            this.salesDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyTransactionToolStripMenuItem,
            this.weeklyTransactionToolStripMenuItem});
            this.salesDataToolStripMenuItem.Name = "salesDataToolStripMenuItem";
            this.salesDataToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.salesDataToolStripMenuItem.Text = "Sales Data";
            // 
            // dailyTransactionToolStripMenuItem
            // 
            this.dailyTransactionToolStripMenuItem.Name = "dailyTransactionToolStripMenuItem";
            this.dailyTransactionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dailyTransactionToolStripMenuItem.Text = "Daily Transaction";
            // 
            // weeklyTransactionToolStripMenuItem
            // 
            this.weeklyTransactionToolStripMenuItem.Name = "weeklyTransactionToolStripMenuItem";
            this.weeklyTransactionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.weeklyTransactionToolStripMenuItem.Text = "Weekly Transaction";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // enquiryToolStripMenuItem
            // 
            this.enquiryToolStripMenuItem.Name = "enquiryToolStripMenuItem";
            this.enquiryToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.enquiryToolStripMenuItem.Text = "About Us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Product Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "beverage",
            "bakery",
            "cereal ",
            "chocolate",
            "dairy",
            "grains",
            "jarred__canned",
            "junk__food",
            "toiletaries"});
            this.comboBox1.Location = new System.Drawing.Point(236, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "beverage";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Category";
            // 
            // Product_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product_info";
            this.Text = "Beverage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Product_info_FormClosed);
            this.Load += new System.EventHandler(this.Product_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquiryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}