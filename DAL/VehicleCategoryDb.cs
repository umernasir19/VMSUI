using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Windows.Forms;
using BOL;

namespace DAL
{
    public class VehicleCategoryDb : BaseDb
    {
         
        //////method to get vehicle model from database
        public DataTable getVehicleCatmakmodel(string flag)
        {
        
            try
            {
                string StoredprocName = "";
                switch (flag)
                {
                    case "VehicleCategory":
                        StoredprocName = "SpgetvehicleCategory";
                        break;
                    case "VehicleModel":
                        StoredprocName = "spGetVehicleModels";
                        break;
                    case "VehicleMaker":
                        StoredprocName = "SpGetVehicleMaker";
                        break;
                    case "allVehicles":
                        StoredprocName = "spGetAllVehicles";
                        break;

                }


                SqlCommand cmd = new SqlCommand();
                DataTable Dt = new DataTable();
                SqlDataAdapter da;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredprocName;
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
        public bool AddVehicleCategory(VehicleCategory vehicleCategory)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddVehicleCategory";
                cmd.Parameters.AddWithValue("@VehicleCategoryName", vehicleCategory.Name);
               
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

        public bool UpdateVehicleCategory(VehicleCategory vehicleCategory)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateVehicleCategory";
                cmd.Parameters.AddWithValue("@VehicleCategoryId", vehicleCategory.VehicleCategoryId);
                cmd.Parameters.AddWithValue("@VehicleCategoryName", vehicleCategory.Name);
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
        public bool DeleteVehicleCategory(VehicleCategory vehicleCategory)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteVehicleCategory";
                cmd.Parameters.AddWithValue("@VehicleCategoryId", vehicleCategory.VehicleCategoryId);
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
