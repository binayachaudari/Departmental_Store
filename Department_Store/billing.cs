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
    public partial class billing : Form
    {
        string staffid;
        DataTable dbdataset;
        public billing()
        {
            InitializeComponent();
            AutoCompleteText_item_name();
        }
        public billing(string StaffID)
        {
            InitializeComponent();
            staffid = StaffID;
            AutoCompleteText_item_name();
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
        void AutoCompleteText_item_name()
        {
            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            item_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            item_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
             
            // for union

            string beverage = "select item_name from department_store.beverage";
            string bakery = "select item_name from department_store.bakery";
            string cereal = "select item_name from department_store.cereal";
            string chocolate = "select item_name from department_store.chocolate";
            string dairy = "select item_name from department_store.dairy";
            string grains = "select item_name from department_store.grains";
            string jarred__canned = "select item_name from department_store.jarred__canned";
            string junk_food = "select item_name from department_store.junk_food";
            string toiletaries = "select item_name from department_store.toiletaries";


            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + "", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("item_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            item_name.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", textBox1.Text);
            // for union

            string beverage = "select * from department_store.beverage";
            string bakery = "select * from department_store.bakery";
            string cereal = "select * from department_store.cereal";
            string chocolate = "select * from department_store.chocolate";
            string dairy = "select * from department_store.dairy";
            string grains = "select * from department_store.grains";
            string jarred__canned = "select * from department_store.jarred__canned";
            string junk_food = "select * from department_store.junk_food";
            string toiletaries = "select * from department_store.toiletaries";

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM (" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + ") AS P where P.item_name = '" + this.item_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.unit_price_txt.Text = myReader.GetString("price");
                    this.available_quantity_txt.Text = myReader.GetString("quantity");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void billing_Load(object sender, EventArgs e)
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
