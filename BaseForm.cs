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
    public partial class BaseForm : Form
    {
        public BaseForm()
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
    }
}
