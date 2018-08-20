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
    public class CustomerDb : BaseDb
    {
        public CustomerDb()
        {

        }

        public bool addCustomers(Customers customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddCustomer";
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@CustomerTypeId", customer.CustomersTypeId);
                cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                cmd.Parameters.AddWithValue("@Dob", customer.Dob);
                cmd.Parameters.AddWithValue("@Cnic", customer.Cnic);
                cmd.Parameters.AddWithValue("@LicenseNumber", customer.LicenseNumber);
                cmd.Parameters.AddWithValue("@IsCar", customer.Car);
                cmd.Parameters.AddWithValue("@IsBike", customer.Bike);
                cmd.Parameters.AddWithValue("@PrimaryContactNumber", customer.Primarycontactnumber);
                cmd.Parameters.AddWithValue("@SecondaryContactNumber", customer.Secondarycontactnumber);
                cmd.Parameters.AddWithValue("@EmailAddress", customer.Email);
                cmd.Parameters.AddWithValue("@Remarks", customer.Remarks);
                cmd.Parameters.AddWithValue("@RefrenceId", customer.RefrenceId);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }


        }
        public DataTable GetAllCustomers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetAllCustomers";
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public bool UpdateCostumer(Customers customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateCustomer";
                cmd.Parameters.AddWithValue("@CustomerId", customer.CostumersId);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@CustomerTypeId", customer.CustomersTypeId);
                cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                cmd.Parameters.AddWithValue("@Dob", customer.Dob);
                cmd.Parameters.AddWithValue("@Cnic", customer.Cnic);
                cmd.Parameters.AddWithValue("@LicenseNumber", customer.LicenseNumber);
                cmd.Parameters.AddWithValue("@IsCar", customer.Car);
                cmd.Parameters.AddWithValue("@IsBike", customer.Bike);
                cmd.Parameters.AddWithValue("@PrimaryContactNumber", customer.Primarycontactnumber);
                cmd.Parameters.AddWithValue("@SecondaryContactNumber", customer.Secondarycontactnumber);
                cmd.Parameters.AddWithValue("@EmailAddress", customer.Email);
                cmd.Parameters.AddWithValue("@Remarks", customer.Remarks);
                cmd.Parameters.AddWithValue("@RefrenceId", customer.RefrenceId);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool DeleteCostumer(Customers customerid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteCustomer";
                cmd.Parameters.AddWithValue("@CustomerId", customerid.CostumersId);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public DataTable SearchCustomer(Customers search)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spSearchCostumers";
                cmd.Parameters.AddWithValue("@customername", search.Name);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }
    }
}
