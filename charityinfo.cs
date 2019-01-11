using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MarathonProject
{
    public partial class charityinfo : Form
    {
        String str="";
        public charityinfo()
        {
            InitializeComponent();
            try
            {
                label1.Text = Variables.charity;
                String url = "server=localhost;Database=MarathonSkills2015;Integrated Security=true";
                SqlConnection con = new SqlConnection(url);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Charity",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if (Variables.charity==(dr["CharityName"].ToString()))
                    {
                        str = dr["CharityLogo"].ToString();
                        label2.Text = dr["CharityDescription"].ToString();
                        break;
                    }
                 }
                //Image img = Image.FromFile("C:\\Users\\hp\\Desktop\\Logos\\" +str);
                String[] split = str.Split('.');
                split[0] = split[0].Replace("-", "_");
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(split[0]);
               // MessageBox.Show(split[0]);
                  dr.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void charityinfo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
