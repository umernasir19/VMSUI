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
    public class VehicleModelDb:BaseDb
    {
        public bool AddVehicleModel(VehicleModel vehicleModel)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddVehicleModel";
                cmd.Parameters.AddWithValue("@ModelName", vehicleModel.Name);
                cmd.Parameters.AddWithValue("@vehicle_maker_id", vehicleModel.vehicle_maker_id);
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
        public bool UpdateVehicleModel(VehicleModel vehicleModel)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateVehicleModel";
                cmd.Parameters.AddWithValue("@VehicleModelName", vehicleModel.Name);
                cmd.Parameters.AddWithValue("@VehicleModelId", vehicleModel.VehicelModelId);
                cmd.Parameters.AddWithValue("@vehicle_maker_id", vehicleModel.vehicle_maker_id);
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
        public bool DeleteModel(VehicleModel vehiclemodel)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteVehicleModel";
                cmd.Parameters.AddWithValue("@ModelId", vehiclemodel.VehicelModelId);
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
