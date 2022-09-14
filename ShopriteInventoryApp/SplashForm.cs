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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int progressStart = 0; 
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressStart += 2;
            ProgressBar.Value = progressStart;
            if (ProgressBar.Value == 100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                LoginScreen loginScreen = new LoginScreen();
                this.Hide();
                loginScreen.Show();
            }
        }

        private void ProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
