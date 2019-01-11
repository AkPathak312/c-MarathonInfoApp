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
    public partial class administratormenu : Form
    {
        public administratormenu()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void administratormenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement f = new UserManagement();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VolunteerManagement f = new VolunteerManagement();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCharities f = new ManageCharities();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
