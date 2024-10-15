using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerHub.Entity;
using System.Configuration;

namespace CareerHub.BusinessLayer
{
    public static class DBUtil
    {
        public static SqlConnection GetConnnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}
