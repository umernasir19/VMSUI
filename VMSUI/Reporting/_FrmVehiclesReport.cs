using BLL;
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
using VMSUI.Reporting;

namespace VMSUI
{
    public partial class _FrmVehiclesReport : Telerik.WinControls.UI.RadForm
    {
        public _FrmVehiclesReport()
        {
            InitializeComponent();
            comboboxdataInitialize();
            hiddingandsettingcolumns();
        }
        public void hiddingandsettingcolumns()
        {
            dgvvhclereports.Columns["MakeId"].IsVisible = false;
            dgvvhclereports.Columns["ModelId"].IsVisible = false;
            dgvvhclereports.Columns["VehiclCategoryId"].IsVisible = false;
            dgvvhclereports.Columns["Vehicle_Id"].IsVisible = false;

        }
        public void comboboxdataInitialize()
        {
            //combobox vehicle category data initialization start

            //comboboxvehiclecategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            //comboboxvehiclecategory.DisplayMember = "Name";
            //comboboxvehiclecategory.ValueMember = "VehicleCategoryId";

            //// combobox vehicle category data initialization end

            //comboboxvehicleModel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");
            //comboboxvehicleModel.DisplayMember = "Name";
            //comboboxvehicleModel.ValueMember = "VehicleModelID";


            //comboboxvehiclecMaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            //comboboxvehiclecMaker.DisplayMember = "Name";
            //comboboxvehiclecMaker.ValueMember = "VehicleMakerID";


           dgvvhclereports.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");






            ////manage page initializzation
            //cmboboxupdateCategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            //cmboboxupdateCategory.DisplayMember = "Name";
            //cmboboxupdateCategory.ValueMember = "VehicleCategoryId";


            //comboboxupdatemodel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");
            //comboboxupdatemodel.DisplayMember = "Name";
            //comboboxupdatemodel.ValueMember = "VehicleModelID";


            //cmboboxupdatemaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            //cmboboxupdatemaker.DisplayMember = "Name";
            //cmboboxupdatemaker.ValueMember = "VehicleMakerID";

            //// updatedltgridviewvehicles.DataSource = vehicle.getVehicleCatmakmodel("allVehicles");
            //dgvmanagepage.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");


            ////add details page initialization
            //dgvvehiclecategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            //dgvvehiclemaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            //dgvvehiclemodel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtboxsearch.Text.ToString() == " " || txtboxsearch.Text.ToString() == null || txtboxsearch.Text.ToString() == "")
            {
                comboboxdataInitialize();
            }
            else
            {
                Vehicles vehiclesearch = new Vehicles()
                {
                    enginenumber =(txtboxsearch.Text.ToString())
                };
                dgvvhclereports.DataSource = new VehicleBusiness().Searchvehicle(vehiclesearch);
            }
        }

        Bitmap bmp;


        private void dgvvhclereports_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //bmp = null;
            //int height = dgvvhclereports.Height;
            //dgvvhclereports.Height = dgvvhclereports.Height * dgvvhclereports.Height * 2;
            //bmp = new Bitmap(dgvvhclereports.Width, dgvvhclereports.Height);
            //dgvvhclereports.DrawToBitmap(bmp, new Rectangle(0, 0, dgvvhclereports.Width, dgvvhclereports.Height));
            //dgvvhclereports.Height = height;
            //printPreviewDialog1.Show();
            try
            {
                int id = Convert.ToInt32(dgvvhclereports.Rows[e.RowIndex].Cells["Vehicle_ID"].Value.ToString());
                Vehicles vehicles = new Vehicles()
                {
                    Vehicle_ID = id
                };

                FrmGetVehicleByName getVehicleByName = new FrmGetVehicleByName(vehicles);
                getVehicleByName.Show();
            }
            catch(Exception exception)
            {

            }
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvvhclereports_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratereport_Click(object sender, EventArgs e)
        {
            _PrintVehicleFromToReports printReports = new _PrintVehicleFromToReports();
            printReports.Show();
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void _FrmVehiclesReport_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btngetallvehiclereport_Click(object sender, EventArgs e)
        {
            FrmVehicleAllReport vehicleAllReport = new FrmVehicleAllReport();
            vehicleAllReport.Show();
        }
    }
}
