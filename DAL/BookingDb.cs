using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class BookingDb:BaseDb
    {
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

        public DataTable GetAllVehicles()
        {
           
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    DataTable Dt = new DataTable();
                    SqlDataAdapter da;
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spGetAllVehicles";
                    da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    return Dt;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return new DataTable();
                }

            
        }

        public DataTable getRateCards()
        {
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da;
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetRateCards";
                // cmd.Parameters.AddWithValue("@vehicleMakerId", model.vehicle_maker_id);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return dt;
            }
        }

        public bool AddBookings(Booking booking)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spAddBookings";
                command.Parameters.AddWithValue("@customerId", booking.customerId);
                command.Parameters.AddWithValue("@vehicleId", booking.vehicleId);
                command.Parameters.AddWithValue("@ratecardid", booking.rateCardId);
                command.Parameters.AddWithValue("@startdate", booking.startDate);
                command.Parameters.AddWithValue("@enddate", booking.endDate);
                command.Parameters.AddWithValue("@totalamount", booking.totalamount);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public DataTable GetAllBookings()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetBookings";
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
