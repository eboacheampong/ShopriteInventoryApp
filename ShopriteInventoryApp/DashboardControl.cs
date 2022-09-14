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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }
        private void DashboardControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int progressStart1 = 0;
        int progressStart2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressStart1 += 10;
            ProgressBar1.Value = progressStart1;
            if (ProgressBar1.Value == 80)
            {
                ProgressBar1.Value = 80;
                timer1.Stop();
               
            }
        }

        private void DashboardControl_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressStart2 += 5;
            ProgressBar2.Value = progressStart2;
            if (ProgressBar2.Value == 35)
            {
                ProgressBar2.Value = 35;
                timer2.Stop();

            }
        }
    }
}
