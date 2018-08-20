using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class CustomerTypeDb:BaseDb

    {
        public CustomerTypeDb() { }

        public DataTable getCustomerTypes()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable Dt = new DataTable();
            SqlDataAdapter da;
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spViewcustomerType";
            da = new SqlDataAdapter(cmd);
            da.Fill(Dt);
            return Dt;


        }

        public bool addCostumerType(CustomerType customerType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddCustomerType";
                cmd.Parameters.AddWithValue("@CostumerType", customerType.Type);
               
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UpdateCustomerType(CustomerType customerType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateCostumerType";
                cmd.Parameters.AddWithValue("@CostumerTypeId", customerType.CustomerTypeId);
                cmd.Parameters.AddWithValue("@CostumerType", customerType.Type);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteCostumerType(CustomerType customerType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteCostumerType";
                cmd.Parameters.AddWithValue("@CostumerTypeId", customerType.CustomerTypeId);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
