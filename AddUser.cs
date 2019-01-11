using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MarathonProject
{
    public partial class AddUser : MarathonProject.BaseForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            char role='R';
            if (cmbRole.SelectedIndex == 0)
                role = 'R';
            if (cmbRole.SelectedIndex == 1)
                role = 'C';
            if (cmbRole.SelectedIndex == 2)
                role = 'A';
            Regex email = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z]{1,15}.(com|org)$");
            Regex password = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{6,25}$");
            if (!(email.IsMatch(txtEmail.Text)))
            {
                errorProvider1.SetError(txtEmail, "Email Adress is not valid !");
            }
            else if (!(password.IsMatch(txtPassword.Text)))
            {
                errorProvider1.SetError(txtPassword, "Password must be of 6 word length with atleast one of uppercase,Lower case and a symbol.");
            }
            if (cmbRole.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRole, "Select a Role");
            }
            else if (!(txtPassword.Text == txtPasswordagain.Text))
            {
                errorProvider1.SetError(txtPassword, "Password do not match.");
            }
            else
            {
                String url = "server=localhost;Database=MarathonSkills2015;Integrated Security=true";
                SqlConnection con = new SqlConnection(url);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into [User] values(@Email,@Password,@Fname,@Lname,@Role)", con);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                
                cmd.Parameters.AddWithValue("@Role", role);
                
                cmd.ExecuteNonQuery();

                    }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
