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
    public partial class aboutmarathon : Form
    {
        public aboutmarathon()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void aboutmarathon_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime cday = new DateTime(2018, 10, 02, 11, 0, 0);
            TimeSpan s = cday.Subtract(now);
            rem.Text = s.Days.ToString() + " Days " + s.Hours.ToString() + " Hours " + s.Minutes.ToString() + " Minutes " + s.Seconds.ToString() + " Seconds remaining.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            interactivemap f = new interactivemap();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            findoutmore f = new findoutmore();
            f.Show();
            this.Hide();
        }
    }
}
