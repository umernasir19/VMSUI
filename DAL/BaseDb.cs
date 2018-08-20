using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDb
    {
        protected SqlConnection con;

        public BaseDb()
        {
            con = DBClass.getSqlCon();
        }

    }
}
