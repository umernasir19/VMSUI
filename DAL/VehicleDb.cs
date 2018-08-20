using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using BOL;
using System.Windows.Forms;

namespace DAL
{
    public class VehicleDb : BaseDb
    {
        public VehicleDb()
        {
        }

        public bool AddVehicle(Vehicles vehicle)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Close();
                
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAdddVehicles";
                cmd.Parameters.AddWithValue("@VehiclCategoryId", vehicle.VehiclCategoryId);
                cmd.Parameters.AddWithValue("@MakeID", vehicle.MakeID);
                cmd.Parameters.AddWithValue("@ModelId", vehicle.ModelId);
                cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                cmd.Parameters.AddWithValue("@enginenumber", vehicle.enginenumber);
                cmd.Parameters.AddWithValue("@Chessisnumber", vehicle.chessisnumber);
                cmd.Parameters.AddWithValue("@registrationyear", vehicle.registrationyear);
                cmd.Parameters.AddWithValue("@cc", vehicle.cc);
                cmd.Parameters.AddWithValue("@colour", vehicle.colour);
                cmd.Parameters.AddWithValue("@modelyear", vehicle.modelyear);
                cmd.Parameters.AddWithValue("@numberplate", vehicle.numberplate);

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

        public bool UpdateVehicle(Vehicles vehicle)
        {

            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateVehicles";
                cmd.Parameters.AddWithValue("@vehicleId", vehicle.Vehicle_ID);
                cmd.Parameters.AddWithValue("@VehiclCategoryId", vehicle.VehiclCategoryId);
                cmd.Parameters.AddWithValue("@MakeID", vehicle.MakeID);
                cmd.Parameters.AddWithValue("@ModelId", vehicle.ModelId);
                cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                cmd.Parameters.AddWithValue("@enginenumber", vehicle.enginenumber);
                cmd.Parameters.AddWithValue("@chessisnumber", vehicle.chessisnumber);
                cmd.Parameters.AddWithValue("@registrationyear", vehicle.registrationyear);
                cmd.Parameters.AddWithValue("@cc", vehicle.cc);
                cmd.Parameters.AddWithValue("@colour", vehicle.colour);
                cmd.Parameters.AddWithValue("@modelyear", vehicle.modelyear);
                cmd.Parameters.AddWithValue("@numberplate", vehicle.numberplate);
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

        public bool DeleteVehicle(Vehicles vehicle)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteVehicles";
                cmd.Parameters.AddWithValue("@vehicleId", vehicle.Vehicle_ID);
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

        public DataTable SearchVehicle(Vehicles vehicle)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spSearchVehicle";
                cmd.Parameters.AddWithValue("enginenumber", vehicle.enginenumber);
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
