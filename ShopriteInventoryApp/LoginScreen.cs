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
