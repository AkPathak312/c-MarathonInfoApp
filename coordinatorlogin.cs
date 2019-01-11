using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonProject
{
    public partial class coordinatorlogin : Form
    {
        public coordinatorlogin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime cday = new DateTime(2018, 10, 02, 11, 0, 0);
            TimeSpan s = cday.Subtract(now);
            rem.Text = s.Days.ToString() + " Days " + s.Hours.ToString() + " Hours " + s.Minutes.ToString() + " Minutes " + s.Seconds.ToString() + " Seconds remaining.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerManagement f = new RunnerManagement();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
