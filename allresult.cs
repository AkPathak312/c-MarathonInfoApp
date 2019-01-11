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
    public partial class allresult : Form
    {
        public allresult()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //SEARCH BUTTON CLICK
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String type = cmbEvent.SelectedItem.ToString();
                String marathon = cmbmarathon.SelectedItem.ToString();
                String age = cmbAge.SelectedItem.ToString();
                String gender = cmbGender.SelectedItem.ToString();
                String url = "server=localhost;Database=MarathonSkills2015;Integrated Security=true";
                SqlConnection con = new SqlConnection(url);
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter(@"select Dense_Rank() over (order by RaceTime) as Rank,[User].FirstName,[User].LastName,RaceTime,Runner.CountryCode from [User]
inner join allraceresult on allraceresult.Email=[User].Email
inner join [Runner] on [User].email=[Runner].Email
and MarathonName='" + marathon + "' and EventTypeName='" + type + "'" + "and Years " + age/*+"' and Gender='"+gender+"' and Years "+age*/, con);

                cmd.TableMappings.Add("Table", "Test");

                DataSet dtset = new DataSet();
                cmd.Fill(dtset);
                dtset.Tables[0].Columns.Add(new DataColumn(" Race Completion Timing", typeof(string)));
                dtset.Tables[0].Columns[3].ToString();

                for (int i = 0; i < dtset.Tables[0].Rows.Count; i++)
                {
                    int time = Convert.ToInt32(dtset.Tables[0].Rows[i][3]);
                    int hr = time / 3600;
                    int min = (time % 3600) / 60;
                    int sec = (time % 60);
                   
                    dtset.Tables[0].Rows[i][5] = hr + " hr " + min + " min " + sec + " sec";
                }
                dataGridView1.DataSource = dtset.Tables[0];
                dataGridView1.Columns[3].Visible = false;
               // DataRow[] row = dtset.Tables[0].Select("FirstName");
               // int count = row.Length;
                int count=dtset.Tables[0].Rows.Count;
                label10.Text = "" + count;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbmarathon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findoutmore f = new findoutmore();
            f.Show();
            this.Hide();
        }

        private void allresult_Load(object sender, EventArgs e)
        {

        }
    }
}
 