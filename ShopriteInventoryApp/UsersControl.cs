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
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            LoadUser();
        }

        public string user_id;
        public string name;
        public string email;
        public string phone;
        public string role;
        public string gender;


        public void Clear()
        {
            textBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_Password.Clear();
            textBox_phone.Clear();
            comboBox_role.Text = "";
            textBox_username.Focus();
        }

        private string generateUserID()
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
        public void LoadUser()
        {
            int i = 0;
            guna2DataGridView1.Rows.Clear();
            string query = "Select * from user";
            DBConnect.open_connection();
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnect.connection);

            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[2].ToString());
            }
            dr.Close();
            DBConnect.close_connection
                ();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_Name.Text == "" || comboBox_role.Text == "" || TextBox_Password.Text == "" || textBox_username.Text == "" || textBox_email.Text == "" )
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DBConnect.open_connection();
                    MySqlCommand command;
                    command = new MySqlCommand();

                    string role = "";
                    string query = "";
                    bool user_exits = false;

                    if (comboBox_role.Text == "Admin")
                    {
                        role = "admin";
                    }
                    else if (comboBox_role.Text == "user")
                    {
                        role = "user";
                    }
                    query = "Select * from user where username = '" + textBox_username.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Username already Exist !");
                        user_exits = true;
                    }
                    else
                    {
                        user_exits = false;
                    }
                    dr.Close();
                    if (!user_exits)
                    {
                        string enc_pass = Encryption.HashString(TextBox_Password.Text);
                        query = "Insert into user(id,fullName,Email,username,PhoneNumber,Password,Role) values(@textBox_ID,@TextBox_Name,@textBox_email,@textBox_username,@textBox_phone,@TextBox_Password,@comboBox_role)";
                        command = new MySqlCommand(query, DBConnect.connection);
                        command.Parameters.AddWithValue("@textBox_ID", textBox_ID);
                        command.Parameters.AddWithValue("@TextBox_Name", TextBox_Name.Text);
                        command.Parameters.AddWithValue("@textBox_email", textBox_email.Text);
                        command.Parameters.AddWithValue("@textBox_username", textBox_username.Text);
                        command.Parameters.AddWithValue("@textBox_phone", textBox_phone.Text);
                        command.Parameters.AddWithValue("@comboBox_role", comboBox_role.Text);
                        command.Parameters.AddWithValue("@TextBox_Password", TextBox_Password.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account has be successfully created", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUser();
                        Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
