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
    public partial class Product_info : Form
    {
        DataTable dbdataset;
        public Product_info()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            main_page form = new main_page();
            form.Show();
        }


        private void Product_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store." + this.comboBox1.Text + ";", Con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_info_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store." + this.comboBox1.Text + ";", Con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
