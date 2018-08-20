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
    public class VehicleMakerDb : BaseDb
    {
        public bool AddVehicleMaker(VehicleMaker vehicleMaker)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddVehicleMaker";
                cmd.Parameters.AddWithValue("@VehicleMakerName", vehicleMaker.Name);
                cmd.Parameters.AddWithValue("@vehicleCategoryId", vehicleMaker.VehicleCategoryId);
               
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

        public bool UpdateVehicleMaker(VehicleMaker vehicleMaker)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateVehicleMaker";
                cmd.Parameters.AddWithValue("@VehicleMakerId", vehicleMaker.VehicleMakerID);
                cmd.Parameters.AddWithValue("@VehicleMakerName", vehicleMaker.Name);
                cmd.Parameters.AddWithValue("@vehicle_category_id", vehicleMaker.VehicleCategoryId);
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

        public bool DeleteVehicleMaker(VehicleMaker vehicleMaker)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteVehicleMaker";
                cmd.Parameters.AddWithValue("@VehicleMakerId", vehicleMaker.VehicleMakerID);
                
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
