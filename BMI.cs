using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarathonProject
{
    public partial class BMI : MarathonProject.BaseForm
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void BMI_Load(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Double height = Convert.ToDouble(txtHeight.Text);
                Double weight = Convert.ToDouble(txtWeight.Text);
                height /= 100;
                height = height * height;
                Double bmi = weight / height;
               // MessageBox.Show(height.ToString());
                lblBmi.Text = bmi.ToString();
                if (bmi < 15)
                    trBmi.Value = 15;
                else if (bmi > 35)
                    trBmi.Value = 35;
                else
                    trBmi.Value = Convert.ToInt32(bmi);
            }
            catch(Exception ex)
            {
              //  MessageBox.Show(ex.Message);
                MessageBox.Show("Input is not in Valid format.", "Input Error");
            }
        }

        private void label11_Click(object sender, EventArgs e)
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
