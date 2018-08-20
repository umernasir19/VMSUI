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
    public class RateCardDb:BaseDb

    {
        public DataTable getMakerFromCategory(VehicleMaker vehicleMaker)
        {
            DataTable dt = new DataTable();
            try
            {
                
                SqlDataAdapter da;
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetVehicleMakerFromCategory";
                cmd.Parameters.AddWithValue("@VehicleCategoryId", vehicleMaker.VehicleCategoryId);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return dt;
            }
        }
        public DataTable getModelFromMaker(VehicleModel model)
        {
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da;
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetModelFromMaker";
                cmd.Parameters.AddWithValue("@vehicleMakerId", model.vehicle_maker_id);
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
        public bool addRateCard(RateCard rateCard)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddRateCard";
                cmd.Parameters.AddWithValue("@rateCardName", rateCard.RateCardName);
                cmd.Parameters.AddWithValue("@VehicleCategoryId", rateCard.VehicleCategoryId);
                cmd.Parameters.AddWithValue("@VehicleMakerId", rateCard.VehicleMakerID);
                cmd.Parameters.AddWithValue("@VehicleModelId", rateCard.VehicleModelId);
                cmd.Parameters.AddWithValue("@VehicleBaseRate", rateCard.BaseRate);
                cmd.Parameters.AddWithValue("@VehicleDailyRate", rateCard.DailyRate);
                cmd.Parameters.AddWithValue("@VehicleWeeklyRate", rateCard.WeeklyRate);
                cmd.Parameters.AddWithValue("@VehicleMonthlyRate", rateCard.MonthlyRate);
                cmd.Parameters.AddWithValue("@StartDate", rateCard.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", rateCard.EndDate);
                cmd.Parameters.AddWithValue("@IsActive", rateCard.IsActive);
                cmd.Parameters.AddWithValue("@Starttime", rateCard.starttime);
                cmd.Parameters.AddWithValue("@Endtime", rateCard.endtime);
                
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
        public void UpdateRateCardStatus()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateRateCardStatus";
                

                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
               
            }
        }
    }
}
