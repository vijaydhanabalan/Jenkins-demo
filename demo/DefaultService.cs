using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace demo
{
    public class DefaultService
    {
        public string GetNameFromDB()
        {
            string name = "";
            string CS = ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM test", con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr["name"].ToString();
                }
            }
            return name;
        }
        public string GetName()
        {
            
            
            return "demouser";
        }
    }
}