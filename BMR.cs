using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarathonProject
{
    
    public partial class BMR : MarathonProject.BaseForm
    {
        int gender=0;
        public BMR()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gender = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gender = 2;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gender == 1)
                {
                    Double height = Convert.ToDouble(txtHeight.Text);
                    Double weight = Convert.ToDouble(txtWeight.Text);
                    Double age = Convert.ToDouble(txtAge.Text);
                    Double bmr = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
                    lblbmr.Text = bmr.ToString();
                    lblsedentry.Text = (bmr * 1.2).ToString();
                    lbllight.Text = (bmr * 1.375).ToString();
                    lblmoderate.Text = (bmr * 1.55).ToString();
                    lblactive.Text = (bmr * 1.725).ToString();
                    lblextremely.Text = (bmr * 1.9).ToString();
                }
                else
                {
                    Double height = Convert.ToDouble(txtHeight.Text);
                    Double weight = Convert.ToDouble(txtWeight.Text);
                    Double age = Convert.ToDouble(txtAge.Text);
                    Double bmr = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
                    lblbmr.Text = bmr.ToString();
                    lblsedentry.Text = (bmr * 1.2).ToString();
                    lbllight.Text = (bmr * 1.375).ToString();
                    lblmoderate.Text = (bmr * 1.55).ToString();
                    lblactive.Text = (bmr * 1.725).ToString();
                    lblextremely.Text = (bmr * 1.9).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input !!");
            }
        }

        private void lblbmr_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findoutmore f = new findoutmore();
            f.Show();
            this.Hide();
        }
    }
}
