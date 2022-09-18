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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            dashboardControl1.Visible = true;
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            productsControl1.Visible = true;
            dashboardControl1.Visible = false;      

        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            categoryControl1.Visible = true;
            productsControl1.Visible = false;
            dashboardControl1.Visible = false;
        }

        private void button_stocks_Click(object sender, EventArgs e)
        {
            stockControl1.Visible = true;
            categoryControl1.Visible=false;
            productsControl1.Visible=false;
            dashboardControl1.Visible = false;
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            usersControl1.Visible = true;
            stockControl1.Visible = false;
            categoryControl1.Visible = false;
            productsControl1.Visible = false;
            dashboardControl1.Visible=false;
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            reportControl1.Visible = true;
            usersControl1.Visible = false;
            stockControl1.Visible = false;
            categoryControl1.Visible = false;
            productsControl1.Visible = false;
            dashboardControl1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want Logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                timer1.Start();
                logoutControl1.Visible = true;
                reportControl1.Visible = false;
                usersControl1.Visible = false;
                stockControl1.Visible = false;
                categoryControl1.Visible = false;
                productsControl1.Visible = false;
                dashboardControl1.Visible = false;
            }
            else
            {
                dashboardControl1.Visible = true;
                logoutControl1.Visible = false;
                reportControl1.Visible = false;
                usersControl1.Visible = false;
                stockControl1.Visible = false;
                categoryControl1.Visible = false;
                productsControl1.Visible = false;
            }
            
            
            
            
        }
        int progressStart = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressStart += 2;
            ProgressBar_Logout.Value = progressStart;
            if (ProgressBar_Logout.Value == 100)
            {
                ProgressBar_Logout.Value = 0;
                timer1.Stop();
                LoginScreen loginScreen = new LoginScreen();
                this.Hide();
                loginScreen.Show();
            }
        }

        private void productsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
