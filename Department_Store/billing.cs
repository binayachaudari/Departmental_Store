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
        string item_unit_price; // used to store the price of an item from item detail 
        string item_quantity; //used to store the quantity of an item that are going to be purchased by customer from item detail 
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

            item_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            // Query to union all the tables and do mind the syntax...this query solves the "every table must have its own alias" problem
            // grand_table is the alias here...Alias is the reference word for the derived table
            string query = "SELECT grand_table.* from (" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + ") as grand_table where grand_table.item_name = '"+ this.item_name_txt.Text +"';";
          

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

            item_name_txt.AutoCompleteCustomSource = coll;       //loading coll to the customsource
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
            this.date_txt.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

       

        private void item_name_txt_TextChanged(object sender, EventArgs e)
        {

            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", keyword.Text);
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
            // Query to union all the tables and do mind the syntax...this query solves the "every table must have its own alias" problem
            // grand_table is the alias here...Alias is the reference word for the derived table
            string query = "SELECT grand_table.* from (" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + ") as grand_table where grand_table.item_name = '" + this.item_name_txt.Text + "';";
          
            
            string myconn = "datasource=localhost;port=3306;username=root;password=";
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
                    item_unit_price = myReader.GetString("price");
                    this.available_quantity_txt.Text = myReader.GetString("quantity");
                    item_quantity = myReader.GetString("quantity");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salequantity_txt_TextChanged(object sender, EventArgs e)
        {
            float item_price = 0;     //this is the product of unit price and the quantity
            float parsed_unit_price = parse_price(item_unit_price);
            int parsed_sale_quantity = parse_quant(this.salequantity_txt.Text);
            item_price = parsed_unit_price * parsed_sale_quantity;
            this.totalamount_txt.Text = item_price.ToString();
        }
        int parse_quant(string quant)
        {
            int new_quantity = 0;
            try
            {
                new_quantity = (int)Convert.ToInt32(quant.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new_quantity;
        }

        float parse_price(string getPrice)
        {
            float parsed_price = 0;

            try
            {
                parsed_price = (float)Convert.ToDouble(getPrice.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return parsed_price;
        }

       
    }
}
