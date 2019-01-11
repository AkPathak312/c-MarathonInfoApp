using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace MarathonProject
{
    public class DbConnect
    {
        String connectionstring = "server=localhost;Database=MarathonSkills2015;Integrated Security=true";
        SqlConnection con;

        public void OpenConnection()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }

        public void Execute(String Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader Data_Reader(String Query_) //Example : SqlDataReader dr = ClassObject.DataReader("Select * From Student");  
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void ToCsv(string FilePath,DataTable dt)
        {
            StreamWriter sw = new StreamWriter(FilePath,false);
            
            for(int i=0;i<dt.Columns.Count;i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                    sw.Write(',');
            }
            sw.Write(sw.NewLine);
            foreach (DataRow row in dt.Rows)
            {
                for(int i=0;i<dt.Columns.Count;i++)
                {
                    if (!Convert.IsDBNull(row[i]))
                    {
                        string value = row[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(row[i].ToString());
                        }
                        if (i < dt.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }


        public object ShowDataInGridView(string Query_) // Example : dataGridView1.datasource = ClassObject.ShowDataInGridView("Select * From Student") 
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }


        public object WriteData(String Query_, String labelname)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        
        public object RunnerFilter(String Status,String Event,String sort)
        {
            SqlDataAdapter dr = new SqlDataAdapter("select FirstName ,LastName,Email,RegistrationStatus from RunnerManagement where RegistrationStatus='"+Status+"' and EventTypeName='"+Event+"' order by "+sort, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public object UserManagement(String sort,String filter,String search)
        {
            SqlDataAdapter dr = new SqlDataAdapter(@"select  [user].FirstName,[User].LastName,[User].Email,[Role].RoleName from [User]
inner join[Role] on[Role].RoleId =[User].RoleId where RoleName='"+filter+ "' and [user].FirstName like '%"+search+"%'"+" or [user].LastName like '%"+search+"%' or [user].Email like '%"+search+"' order by '" + sort+"'", con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public object UserManager(String sort, String filter)
        {
            SqlDataAdapter dr = new SqlDataAdapter(@"select  [user].FirstName,[User].LastName,[User].Email,[Role].RoleName from [User]
inner join[Role] on[Role].RoleId =[User].RoleId where RoleName='" + filter +"' order by '" + sort + "'", con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

    }
}
