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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            DBConnect.open_connection();
            MySqlCommand command;
            if (TextBox_Username.Text != "" && TextBox_Password.Text != "")
            {
                try
                {
                    string query = "select * from user where username = '" + TextBox_Username.Text + "'&& password = '" + TextBox_Password.Text + "'";
                    command = new MySqlCommand(query, DBConnect.connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        reader.Close();
                        MainForm mainform = new MainForm();
                        this.Hide();
                        mainform.Show();

                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Incorrect credentials!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBConnect.close_connection();
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }

        private void Label_Exit_MouseEnter(object sender, EventArgs e)
        {
            Label_Exit.ForeColor = Color.Red;
        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            Label_Exit.ForeColor = Color.ForestGreen;
        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Username.Clear();
            TextBox_Password.Clear();

        }
    }
}
