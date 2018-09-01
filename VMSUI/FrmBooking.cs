using BLL.BookingBusiness;
using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace VMSUI
{
    public partial class FrmBooking : Telerik.WinControls.UI.RadForm
    {
        #region variables
        private double baserate, dailyrate, weeklyrate, monthlyrate;
        #endregion


        #region objects

        Booking booking = new Booking();
        #endregion
        #region Constructors
        public FrmBooking()
        {
            InitializeComponent();
            InitializeGridviews();
            SettingAndHiddingColumns();
        }
        
        #endregion


        #region Methods
        public void InitializeGridviews()
        {
            dgvbookingcustomers.DataSource = new BookingBusiness().GetAllCustomers();
            dgvbookingvehicle.DataSource = new BookingBusiness().GetAllVehicles();
            dgvbookingratecard.DataSource = new BookingBusiness().GetAllRates();
            dgvBookings.DataSource = new BookingBusiness().GetAllBookings();
        }


        public void SettingAndHiddingColumns()
        {
            dgvbookingcustomers.Columns["Costumer Type"].IsVisible = false;
            dgvbookingcustomers.Columns["CustomerId"].IsVisible = false;
            dgvbookingcustomers.Columns["Name"].IsVisible = false;
            dgvbookingcustomers.Columns["CustomerTypeID"].IsVisible = false;
            dgvbookingcustomers.Columns["Gender"].IsVisible = false;
            dgvbookingcustomers.Columns["DoB"].IsVisible = false;
            dgvbookingcustomers.Columns["IsCar"].IsVisible = false;
            dgvbookingcustomers.Columns["IsBike"].IsVisible = false;
            dgvbookingcustomers.Columns["PrimarycontactNumber"].IsVisible = false;
            dgvbookingcustomers.Columns["SecondaryContactNumber"].IsVisible = false;
            dgvbookingcustomers.Columns["EmailAddress"].IsVisible = false;
            dgvbookingcustomers.Columns["Remarks"].IsVisible = false;
            dgvbookingcustomers.Columns["RefrenceId"].IsVisible = false;
            dgvbookingcustomers.Columns["createdon"].IsVisible = false;

            dgvbookingvehicle.Columns["Category"].IsVisible = false;
            dgvbookingvehicle.Columns["MakeID"].IsVisible = false;
            dgvbookingvehicle.Columns["ModelId"].IsVisible = false;
            dgvbookingvehicle.Columns["VehiclCategoryId"].IsVisible = false;
            dgvbookingvehicle.Columns["Mileage"].IsVisible = false;
            dgvbookingvehicle.Columns["Vehicle_ID"].IsVisible = false;
            dgvbookingvehicle.Columns["enginenumber"].IsVisible = false;
            dgvbookingvehicle.Columns["chessisnumber"].IsVisible = false;
            dgvbookingvehicle.Columns["cc"].IsVisible = false;
            dgvbookingvehicle.Columns["colour"].IsVisible = false;
            dgvbookingvehicle.Columns["registrationyear"].IsVisible = false;
            dgvbookingvehicle.Columns["createdon"].IsVisible = false;
            // dgvbookingvehicle.Columns[].IsVisible = false;
            // dgvbookingvehicle.Columns[].IsVisible = false;


            dgvbookingratecard.Columns["rate_card_name"].IsVisible = false;
            dgvbookingratecard.Columns["starttime"].IsVisible = false;
            dgvbookingratecard.Columns["endtime"].IsVisible = false;
            dgvbookingratecard.Columns["IsAcctive"].IsVisible = false;
            dgvbookingratecard.Columns["RateCardID"].IsVisible = false;
            dgvbookingratecard.Columns["VehicleCategoryID"].IsVisible = false;
            dgvbookingratecard.Columns["vehicleMakerID"].IsVisible = false;
            dgvbookingratecard.Columns["vehicleModelId"].IsVisible = false;
            dgvbookingratecard.Columns["Category"].IsVisible = false;
            dgvbookingratecard.Columns["Maker"].IsVisible = false;
            dgvbookingratecard.Columns["Model"].IsVisible = false;


            dgvBookings.Columns["Booking_Id"].IsVisible = false;
            dgvBookings.Columns["Customer_Id"].IsVisible = false;
            dgvBookings.Columns["Vehicle_Id"].IsVisible = false;
            dgvBookings.Columns["Rate_Card_Id"].IsVisible = false;
            dgvBookings.Columns["RateCardID"].IsVisible = false;
            dgvBookings.Columns["VehicleCategoryID"].IsVisible = false;
            dgvBookings.Columns["Pre_booking_inspection"].IsVisible = false;
            dgvBookings.Columns["Post_Booking_inspection"].IsVisible = false;
            dgvBookings.Columns["BaseRate"].IsVisible = false;
            dgvBookings.Columns["DailyRate"].IsVisible = false;
            dgvBookings.Columns["WeeklyRate"].IsVisible = false;
            dgvBookings.Columns["Monthly"].IsVisible = false;
            dgvBookings.Columns["StartDate"].IsVisible = false;
            dgvBookings.Columns["EndDate"].IsVisible = false;
            dgvBookings.Columns["IsAcctive"].IsVisible = false;
            dgvBookings.Columns["vehicleMakerID"].IsVisible = false;
            dgvBookings.Columns["vehicleModelId"].IsVisible = false;
            dgvBookings.Columns["starttime"].IsVisible = false;
            dgvBookings.Columns["endtime"].IsVisible = false;

            dgvBookings.Columns["rate_card_name"].HeaderText = "Applied Rate Card";


            
           GridViewCommandColumn bcol = new GridViewCommandColumn();
            bcol.HeaderText = "Report";
            bcol.UseDefaultText = true;
            bcol.DefaultText = "Get Report";
            bcol.Name = "report";
            dgvBookings.MasterTemplate.Columns.Add(bcol);
        }
        #endregion

        #region formEvents


        private void dgvbookingcustomers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                txtboxcustomername.Text = dgvbookingcustomers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtboxcnic.Text = dgvbookingcustomers.Rows[e.RowIndex].Cells["CNICNumber"].Value.ToString();
                booking.customerId=Convert.ToInt32(dgvbookingcustomers.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
            }
            catch(Exception exception)
            {

            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (txtboxcustomername.Text.ToString()==""||
                txtboxcnic.Text.ToString() == ""||
                txtboxselectedvehicle.Text.ToString() == "" ||
                txtboxSelectedratecard.Text.ToString() == "" ||
                txtboxbaserate.Text.ToString() == "" ||
                txtboxtotalrate.Text.ToString() == "" ||
                cmboboxduration.SelectedItem.ToString() == "")
            {
                RadMessageBox.Show("Please Select All Fields", "Error");
                return;
            }

            try
            {
                booking.startDate = dtstrtdate.Value.ToShortDateString();
                booking.endDate = dtenddate.Value.ToShortDateString();
                booking.totalamount =Convert.ToDecimal(txtboxtotalrate.Text.ToString());

                if (new BookingBusiness().AddBookings(booking))
                {

                    RadMessageBox.Show("Booked");
                    InitializeGridviews();
                    txtboxcustomername.Clear();
                    txtboxcnic.Clear();
                    txtboxselectedvehicle.Clear();
                    txtboxSelectedratecard.Clear();
                    txtboxbaserate.Clear();
                    txtboxtotalrate.Clear();
                    

                }
                else
                {
                    RadMessageBox.Show("Failed");
                    return;
                }
               
            }
            

            catch(Exception exception)
            {

            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookings_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            int value = (int)cell.RowInfo.Cells["Booking_Id"].Value;
            MessageBox.Show(value.ToString());
        }

        private void dgvbookingvehicle_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                txtboxselectedvehicle.Text = dgvbookingvehicle.Rows[e.RowIndex].Cells["Maker"].Value.ToString() + " " +
                    dgvbookingvehicle.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                booking.vehicleId = Convert.ToInt32(dgvbookingvehicle.Rows[e.RowIndex].Cells["Vehicle_Id"].Value.ToString());
            }
            catch (Exception exception)
            {

            }

        }

        private void dgvbookingratecard_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                baserate = Convert.ToDouble(dgvbookingratecard.Rows[e.RowIndex].Cells["BaseRate"].Value.ToString());
                dailyrate = Convert.ToDouble(dgvbookingratecard.Rows[e.RowIndex].Cells["DailyRate"].Value.ToString());
                weeklyrate = Convert.ToDouble(dgvbookingratecard.Rows[e.RowIndex].Cells["WeeklyRate"].Value.ToString());
                monthlyrate = Convert.ToDouble(dgvbookingratecard.Rows[e.RowIndex].Cells["Monthly"].Value.ToString());

                txtboxSelectedratecard.Text = dgvbookingratecard.Rows[e.RowIndex].Cells["rate_card_name"].Value.ToString();
                txtboxbaserate.Text = dgvbookingratecard.Rows[e.RowIndex].Cells["BaseRate"].Value.ToString();

                booking.rateCardId=Convert.ToInt32(dgvbookingratecard.Rows[e.RowIndex].Cells["RateCardID"].Value.ToString());
            }
            catch(Exception exception)
            {

            }

        }

        private void cmboboxduration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxduration.SelectedItem.ToString() == "Daily")
            {
                txtboxtotalrate.Text = Convert.ToString(baserate + dailyrate);
            }
            else if (cmboboxduration.SelectedItem.ToString() == "Weekly")
            {
                txtboxtotalrate.Text = Convert.ToString(baserate + weeklyrate);
            }
            if (cmboboxduration.SelectedItem.ToString() == "Monthly")
            {
                txtboxtotalrate.Text = Convert.ToString(baserate + monthlyrate);
            }
        }
        #endregion
    }
}
