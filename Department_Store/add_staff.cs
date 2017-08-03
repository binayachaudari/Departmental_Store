using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Department_Store
{
    public partial class add_staff : Form
    {
        string staffid;
        public add_staff()
        {
            InitializeComponent();
        }

        public add_staff(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO department_store.staff values ('" + this.staff_id.Text + "','" + this.staff_name.Text + "','" + this.designation.Text + "','" + this.phone_number.Text + "','" + this.address.Text + "'," + this.salary.Text + ");", Con);
            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                count = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (count == 1)
            {
                this.status.Text = "STAFF ADDED SUCCESSFULLY!!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
            this.status.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page form = new main_page(staffid);
            form.Show();

        }

        private void add_staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void staff_id_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
        }
    }
}
