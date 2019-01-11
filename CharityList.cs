using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MarathonProject.Properties;

namespace MarathonProject
{
    public partial class CharityList : MarathonProject.BaseForm
    {
        DbConnect db = new DbConnect();
        public CharityList()
        {
            InitializeComponent();
            db.OpenConnection();
            SqlDataReader dr = db.Data_Reader("Select * from Charity");
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["CharityName"]);
            }
            db.CloseConnection();
        }

        private void CharityList_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.OpenConnection();
            SqlDataReader dr = db.Data_Reader("Select * from Charity");
            while (dr.Read())
            {
                if (comboBox1.SelectedItem.ToString() == dr["CharityName"].ToString())
                {
                    String str = dr["CharityLogo"].ToString();
                    String[] img= str.Split('.');
                    img[0] = img[0].Replace('-', '_');
                    object o=Resources.ResourceManager.GetObject(img[0]);
                    pictureBox1.Image = o as Image;
                    label4.Text = dr["CharityDescription"].ToString();
                }
            }
            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findoutmore f = new findoutmore();
            f.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
