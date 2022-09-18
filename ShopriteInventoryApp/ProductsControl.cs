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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopriteInventoryApp
{
    public partial class ProductsControl : UserControl
    {
        DBConnect db = new DBConnect();
        public ProductsControl()
        {
            InitializeComponent();
            loadCategory();
            LoadProduct();
        }
        public void Clear()
        {
            TextBox_Name.Clear();
            TextBox_Quantity.Clear();
            textBox_Price.Clear();
        }

        private string generateProductID()
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

        public void loadCategory()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = db.getTable("SELECT * FROM category");
            comboBox1.DisplayMember = "categoryName";
        }
        public void LoadProduct()
        {
            int i = 0;
            guna2DataGridView1.Rows.Clear();
            string query = "Select * from products";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString(), dr[1].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Name.Text == "" || comboBox1.Text == "" || textBox_Price.Text == "" || TextBox_Quantity.Text == "")
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

                    query = "Select * from products where productName = '" + TextBox_Name.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Productname already Exist !");
                        product_exits = true;
                    }
                    else
                    {
                        product_exits = false;
                    }
                    dr.Close();
                    if (!product_exits)
                    {
                        query = "Insert into products(id,productName,category,quantity,price) values(NULL,@TextBox_Name,@comboBox1,@TextBox_Quantity,@textBox_Price )";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@TextBox_Name", TextBox_Name.Text);
                        command.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                        command.Parameters.AddWithValue("@TextBox_Quantity", TextBox_Quantity.Text);
                        command.Parameters.AddWithValue("@textBox_Price", textBox_Price.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduct();
                        Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Name.Text == "" || comboBox1.Text == "" || textBox_Price.Text == "" || TextBox_Quantity.Text == "")
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

                    query = "Select * from products where id = '" + TextBox_Id.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        product_exits = true;
                    }
                    else
                    {
                        MessageBox.Show("Product ID not found");
                        product_exits = false;
                    }
                    dr.Close();
                    if (product_exits)
                    {
                        query = "UPDATE `products` SET `category` = @comboBox1, `productName` = @TextBox_Name, `quantity` = @TextBox_Quantity, `price` = @textBox_Price WHERE `products`.`id` = @TextBox_Id;";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@TextBox_Id", TextBox_Id.Text);
                        command.Parameters.AddWithValue("@TextBox_Name", TextBox_Name.Text);
                        command.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                        command.Parameters.AddWithValue("@TextBox_Quantity", TextBox_Quantity.Text);
                        command.Parameters.AddWithValue("@textBox_Price", textBox_Price.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Update has been successfully done", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduct();
                        Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

                    query = "Select * from products where id = '" + TextBox_Id.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows && result == DialogResult.Yes)
                    {
                        product_exits = true;
                    }
                    else if(result == DialogResult.No)
                    {
                        MessageBox.Show("Remove stopped");
                    }

                    else
                    {
                        MessageBox.Show("Product ID not found");
                        product_exits = false;
                    }
                    dr.Close();
                    if (product_exits)
                    {
                        query = "DELETE FROM products WHERE `products`.`id` = @TextBox_Id";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@TextBox_Id", TextBox_Id.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Delete has been successfully done", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduct();
                        Clear();

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
