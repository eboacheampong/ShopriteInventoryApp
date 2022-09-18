using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopriteInventoryApp
{
    public partial class StockControl : UserControl
    {
        DBConnect db = new DBConnect();
        public StockControl()
        {
            InitializeComponent();
            loadCategory();
            loadProduct();
            loaduser();
            Loadstock();
        }


        public void loadCategory()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = db.getTable("SELECT * FROM category");
            comboBox1.DisplayMember = "categoryName";
        }

        public void loadProduct()
        {
            comboBox2.Items.Clear();
            comboBox2.DataSource = db.getTable("SELECT * FROM products");
            comboBox2.DisplayMember = "productName";
        }

        public void loaduser()
        {
            comboBox3.Items.Clear();
            comboBox3.DataSource = db.getTable("SELECT * FROM user");
            comboBox3.DisplayMember = "username";
        }
        private string generateStockID()
        {
            string num = "123456789";
            string user_id = string.Empty;
            int otp_digits = 5;
            string otp;
            int get_index;

            for (int i = 0; i < otp_digits; i++)
            {
                do
                {
                    get_index = new Random().Next(0, num.Length);
                    otp = num.ToCharArray()[get_index].ToString();
                } while (user_id.IndexOf(otp) != -1);

                user_id += otp;
            }

            return user_id;
        }

        public void Loadstock()
        {
            int i = 0;
            guna2DataGridView1.Rows.Clear();
            string query = "Select * from stock";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[1].ToString(), dr[5].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox2.Text == "" || comboBox1.Text == "" || textBox_Price.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DBConnect.open_connection();
                    MySqlCommand command;
                    command = new MySqlCommand();


                    string query = "";
                    bool stock_exits = false;

                    query = "Select * from stock where product = '" + comboBox1.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("stockID already Exist !");
                        stock_exits = true;
                    }
                    else
                    {
                        stock_exits = false;
                    }
                    dr.Close();
                    if (!stock_exits)
                    {
                        query = "Insert into stock(id,product,categoryName,quantity,attendantName,Date) values(NULL,@comboBox2,@comboBox1,@textBox_Price,@comboBox3,@dateTimePicker_stock)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@comboBox2", comboBox2.Text);
                        command.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                        command.Parameters.AddWithValue("@textBox_Price", textBox_Price.Text);
                        command.Parameters.AddWithValue("@comboBox3", comboBox3.Text);
                        command.Parameters.AddWithValue("@dateTimePicker_stock", dateTimePicker_stock.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loadstock();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "" || comboBox1.Text == "" || textBox_Price.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DBConnect.open_connection();
                    MySqlCommand command;
                    command = new MySqlCommand();


                    string query = "";
                    bool product_exits = false;

                    query = "Select * from stock where id = '" + TextBox_Id.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        product_exits = true;
                    }
                    else
                    {
                        MessageBox.Show("Stock ID not found");
                        product_exits = false;
                    }
                    dr.Close();
                    if (product_exits)
                    {
                        query = "UPDATE `stock` SET `attendantName` = @comboBox3, `product` = @comboBox2, `categoryName` = @comboBox1, `quantity` = @textBox_Price, `Date` = @dateTimePicker_stock WHERE `stock`.`id` = @TextBox_Id;";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@TextBox_Id", TextBox_Id.Text);
                        command.Parameters.AddWithValue("@comboBox2", comboBox2.Text);
                        command.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                        command.Parameters.AddWithValue("@textBox_Price", textBox_Price.Text);
                        command.Parameters.AddWithValue("@comboBox3", comboBox3.Text);
                        command.Parameters.AddWithValue("@dateTimePicker_stock", dateTimePicker_stock.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Update has been successfully done", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loadstock();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string message = "Do you want Remove item?";
            string title = "Remove item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            try
            {
                DBConnect.open_connection();
                MySqlCommand command;
                command = new MySqlCommand();


                string query = "";
                bool product_exits = false;

                query = "Select * from stock where id = '" + TextBox_Id.Text + "'";
                command = new MySqlCommand(query, DBConnect.connection);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows && result == DialogResult.Yes)
                {
                    product_exits = true;
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Remove stopped");
                }

                else
                {
                    MessageBox.Show("Stock ID not found");
                    product_exits = false;
                }
                dr.Close();
                if (product_exits)
                {
                    query = "DELETE FROM stock WHERE `stock`.`id` = @TextBox_Id";
                    command = new MySqlCommand(query, DBConnect.connection);
                    command.Parameters.AddWithValue("@TextBox_Id", TextBox_Id.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete has been successfully done", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadstock();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
