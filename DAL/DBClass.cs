using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAL
{
    public class DBClass
    {
        public static string connection()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["vhclecs"].ConnectionString;
        }
        public static SqlConnection getSqlCon()
        {
            SqlConnection con = new SqlConnection(connection());
            return con;
        }
    }
}
