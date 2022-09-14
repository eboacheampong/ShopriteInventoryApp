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

namespace ShopriteInventoryApp
{
    public partial class UserForm : Form
    {
        private MySqlConnection _connection;
        private string server;
        private string username;
        private string database;
        private string full_Name;
        private string password;
        private int phone;
        public UserForm()
        {
            database = "user form";
            server = "localhost";
            username = "";
            full_Name = "";
            password = "";
            phone = int.Parse("");
            
           

            string connString;
            connString = $"SERVER={server}; DATABASE={database}; USERNAME={username}; FULL_NAME={full_Name}; PASSWORD={password}; PHONE = {phone}";

            _connection = new MySqlConnection(connString);  

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }
            /*   Register(tbUser.Text, tbPass.Text);
           }
           public bool Register (string username, string password)
           {
               string query = $"INSERT INTO users (username, full_name, password) VALUES ('', '{username}', '{password}');";
           } */
        }
    }
