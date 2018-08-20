using BLL.RateCardBusiness;
using BLL.VehiclesBusiness;
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
using VMSUI.Reporting;

namespace VMSUI
{
    public partial class FrmRateCard : Telerik.WinControls.UI.RadForm
    {

        #region Constructors
        private DateTimePicker timePicker;
        public FrmRateCard()
        { 

            InitializeComponent();


           


            ComboboxInitialize();
            dgvinitialize();
            hiddingandsettingcolumns();
        }


        #endregion


        #region Methods
        public void ComboboxInitialize()
        {
            comboBoxCategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "VehicleCategoryId";
        }
        #endregion
        public void dgvinitialize()
        {
            dgvratecard.DataSource = new RateCardBusiness().getRateCards();
            
        }
        public void hiddingandsettingcolumns()
        {
            dgvratecard.Columns["RateCardID"].IsVisible = false;
            dgvratecard.Columns["VehicleCategoryId"].IsVisible = false;
            dgvratecard.Columns["VehicleMakerID"].IsVisible = false;
            dgvratecard.Columns["VehicleModelID"].IsVisible = false;

            dgvratecard.Columns["rate_card_name"].HeaderText = "Rate Card Name";
            dgvratecard.Columns["IsAcctive"].HeaderText = "Status";
            // GridViewCommandColumn 
            GridViewCommandColumn bcol = new GridViewCommandColumn();
            bcol.HeaderText = "Report";
            bcol.UseDefaultText = true;
            bcol.DefaultText = "Get Report";
            bcol.Name = "report";

            dgvratecard.MasterTemplate.Columns.Add(bcol);
        }

        

        #region Events
        private void FrmRateCard_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VehicleModel model = new VehicleModel()
                {
                    vehicle_maker_id = Convert.ToInt32(comboBoxMaker.SelectedValue.ToString())
                };
                comboBoxModel.DataSource = new RateCardBusiness().getModelFromMaker(model);
                comboBoxModel.DisplayMember = "Model";
                comboBoxModel.ValueMember = "VehicleModelID";
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VehicleMaker maker = new VehicleMaker()
                {
                    VehicleCategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue.ToString())
                };
                comboBoxMaker.DataSource = new RateCardBusiness().getMakerFromCategory(maker);
                comboBoxMaker.DisplayMember = "Maker";
                comboBoxMaker.ValueMember = "VehicleMakerID";
            }
            catch(Exception ex)
            {

            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnaddratecard_Click(object sender, EventArgs e)
        {
            if(comboBoxMaker.SelectedValue==null||comboBoxModel.SelectedValue==null||txtboxbaserate.Text.ToString()==""||
                txtBoxDailyRate.Text.ToString() == "" || txtBoxWeeklyRate.Text.ToString() == "" || txtBoxMonthlyRate.Text.ToString() == "" ||
                txtboxratecardname.Text.ToString() == ""
                )
            {
                RadMessageBox.Show("Enter All The Fields");
                return;
            }
            bool active = false;
            if (radiobtnactive.Checked)
            {
                active = true;
            }
            if (dtendtime.Value.TimeOfDay < dtstarttime.Value.TimeOfDay)
            {
                RadMessageBox.Show("End Time Cannot be Before the Start time");
                dtendtime.Value = DateTime.Now;
                return;
            }
            RateCard ratecard = new RateCard()
            {
                RateCardName = txtboxratecardname.Text.ToString(),
                VehicleCategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue.ToString()),
                VehicleMakerID = Convert.ToInt32(comboBoxMaker.SelectedValue.ToString()),
                VehicleModelId = Convert.ToInt32(comboBoxModel.SelectedValue.ToString()),
                BaseRate = Convert.ToDecimal(txtboxbaserate.Text.ToString()),
                DailyRate = Convert.ToDecimal(txtBoxDailyRate.Text.ToString()),
                WeeklyRate = Convert.ToDecimal(txtBoxWeeklyRate.Text.ToString()),
                MonthlyRate = Convert.ToDecimal(txtBoxMonthlyRate.Text.ToString()),
                StartDate = dtstrtdate.Value,
                EndDate = dtenddate.Value,
                IsActive = active,
                starttime=dtstarttime.Value.ToShortTimeString().ToString(),
                endtime=dtendtime.Value.ToShortTimeString().ToString()
            };
            
            if (new RateCardBusiness().addRateCard(ratecard))
            {
                RadMessageBox.Show("Succesfully Added");
                lblstrt.Visible = false;
                lblend.Visible = false;
                dtstarttime.Visible = false;
                dtendtime.Visible = false;
              //  
                dgvinitialize();
            }
            else
            {
                RadMessageBox.Show("Failed");
            }

        }

        private void dtenddate_ValueChanged(object sender, EventArgs e)
        {
            dtenddate.Value = DateTime.Now;
            if (dtstrtdate.Value.Date > dtenddate.Value.Date)
            {
                MessageBox.Show("Start Date cannot be after end date");
                dtstrtdate.Value = DateTime.Now;
                dtenddate.Value = DateTime.Now;
            }

            else if (dtstrtdate.Value.Date == dtenddate.Value.Date)
            {
                lblstrt.Visible = true;
                lblend.Visible = true;
                dtstarttime.Visible = true;
                dtendtime.Visible = true;

            }
            else
            {
                lblstrt.Visible = false;
                lblend.Visible = false;
                dtstarttime.Visible = false;
                dtendtime.Visible = false;
            }
        }

        private void dtstrtdate_ValueChanged(object sender, EventArgs e)
        {

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            if (dtstrtdate.Value.Date < date)
            {
                MessageBox.Show("Start Date cannot be before today's Date");
                dtstrtdate.Value = DateTime.Now;
            }
            
        }

        private void dgvratecard_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            
            //MessageBox.Show(e.ToString());
        }

        

        private void dgvratecard_CommandCellClick_1(object sender, EventArgs e)
        {
            // MessageBox.Show(((sender as GridCommandCellElement)).Value.ToString());

            GridCommandCellElement cell = (GridCommandCellElement)sender;
            int value = (int)cell.RowInfo.Cells["RateCardID"].Value;
            FrmRateCardByID rateCardById = new FrmRateCardByID(value);
            rateCardById.Show();

        }

        private void lblstrt_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dtstarttime.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                RadMessageBox.Show("Start Time Cannot be less than the current time");
                dtstarttime.Value = DateTime.Now;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //if (dtendtime.Value.TimeOfDay < dtstarttime.Value.TimeOfDay)
            //{
            //    RadMessageBox.Show("End Time Cannot be Before the Start time");
            //    dtendtime.Value = DateTime.Now;
            //}
        }
    }
}
