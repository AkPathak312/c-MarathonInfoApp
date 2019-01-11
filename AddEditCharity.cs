using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Resources;

namespace MarathonProject
{
    public partial class AddEditCharity : MarathonProject.BaseForm
    {
        public AddEditCharity()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            txtLogo.Text = f.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String str = txtLogo.Text;
            String[] split=str.Split('\\');
            int i = split.Length;
          //  MessageBox.Show(split[i-1]);
            String url = "server=localhost;Database=MarathonSkills2015;Integrated Security=true";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Charity values(@Name,@Description,@Logo)", con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Description", txtDes.Text);
            cmd.Parameters.AddWithValue("@Logo", split[i-1]);
            cmd.ExecuteNonQuery();
            Image img = Image.FromFile(txtLogo.Text);
            ResourceWriter res = new ResourceWriter(txtLogo.Text);

        }
    }
}
