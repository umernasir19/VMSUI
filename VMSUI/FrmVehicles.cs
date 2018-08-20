using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using BLL.VehiclesBusiness;
using BLL;
using Telerik.WinControls;

namespace VMSUI
{
    public partial class FrmVehicles : Telerik.WinControls.UI.RadForm
    {
        #region objects
        VehicleBusiness vehicleBusiness = new VehicleBusiness();

        #endregion
        #region fields
        int Id;

        #endregion

        #region constructors

        public FrmVehicles()
        {
            InitializeComponent();
            comboboxdataInitialize();
            hiddingcolumns();
            hiddingandsettingcolumns();
            panelsetting();


        }
        #endregion

        #region panel hiding
        public void panelsetting()
        {
            panelAddvehicle.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
        }

        #endregion
        #region hiding columns


        #endregion
        #region form events 


        //add vehicle page add button starts
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if(txtboxMileage.Text.ToString()==""||
                txtboxEngineNumber.Text.ToString() == "" ||
                txtboxChessisNumber.Text.ToString() == "" ||
                txtboxcc.Text.ToString() == "" ||
                txtboxColour.Text.ToString() == "" ||
                txtboxyear.Text.ToString() == "" ||
                txtboxregistrationyear.Text.ToString() == "" ||
                txtboxnumberplate.Text.ToString() == "")
            {
                RadMessageBox.Show("Please Add All Fields");
                return;
            }
            Vehicles vehicle = new Vehicles
            {
                VehiclCategoryId = Convert.ToInt32(comboboxvehiclecategory.SelectedValue.ToString()),
                MakeID = Convert.ToInt32(comboboxvehiclecMaker.SelectedValue.ToString()),
                ModelId = Convert.ToInt32(comboboxvehicleModel.SelectedValue.ToString()),
                Mileage = Convert.ToDecimal(txtboxMileage.Text.ToString()), // 
                enginenumber =txtboxEngineNumber.Text.ToString(), // nvarchar
                chessisnumber = txtboxChessisNumber.Text.ToString(), // nvarchar
                cc = txtboxcc.Text.ToString(), //nvarchar
                colour = txtboxColour.Text.ToString(),
                modelyear =txtboxyear.Text.ToString(), // nvarchar
                registrationyear = Convert.ToInt32(txtboxregistrationyear.Text.ToString()),
                numberplate=txtboxnumberplate.Text.ToString()

            };
            if (vehicleBusiness.addVehicle(vehicle))
            {
                RadMessageBox.Show("Added");
                txtboxMileage.Clear();
                txtboxEngineNumber.Clear();
                txtboxChessisNumber.Clear();
                txtboxcc.Clear();
                txtboxColour.Clear();
                txtboxyear.Clear();
                txtboxregistrationyear.Clear();
                txtboxnumberplate.Clear();
                comboboxdataInitialize();
               // dgvAddVehicle.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");
            }
            else
            {
                RadMessageBox.Show("Failed");
            }

        }

        //add vehicle page add button ends



        //manage vehicle page starts
        private void dgvmanagepage_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                txtboxmileageupdate.Text = dgvmanagepage.Rows[e.RowIndex].Cells["Mileage"].Value.ToString();
                txtboxupdatecc.Text = dgvmanagepage.Rows[e.RowIndex].Cells["cc"].Value.ToString();
                txtboxupdatechessisnumber.Text = dgvmanagepage.Rows[e.RowIndex].Cells["chessisnumber"].Value.ToString();
                txtboxupdateenginenumber.Text = dgvmanagepage.Rows[e.RowIndex].Cells["enginenumber"].Value.ToString();
                txtboxupdatemodelyear.Text = dgvmanagepage.Rows[e.RowIndex].Cells["modelyear"].Value.ToString();
                txtboxupdateregistrationyear.Text = dgvmanagepage.Rows[e.RowIndex].Cells["registrationyear"].Value.ToString();
                txtboxupdatecolor.Text = dgvmanagepage.Rows[e.RowIndex].Cells["colour"].Value.ToString();
                comboboxupdatemodel.SelectedValue = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["ModelId"].Value.ToString());
                cmboboxupdateCategory.SelectedValue = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["VehiclCategoryId"].Value.ToString());
                cmboboxupdatemaker.SelectedValue = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["MakeId"].Value.ToString());
                txtboxupdatenumberplate.Text = dgvmanagepage.Rows[e.RowIndex].Cells["numberplate"].Value.ToString();

                Id = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["Vehicle_ID"].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            // MessageBox.Show(Id.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtboxupdateenginenumber.Text.ToString()==""||
                txtboxmileageupdate.Text.ToString()==""||
                txtboxupdatecc.Text.ToString() == "" ||
                txtboxupdatechessisnumber.Text.ToString()==""||
                txtboxupdatecolor.Text.ToString() == "" ||
                txtboxupdatemodelyear.Text.ToString() == "" ||
                txtboxupdateregistrationyear.Text.ToString() == "" ||
                txtboxupdatenumberplate.Text.ToString() == "")
            {
                RadMessageBox.Show("Enetr ALL Fields");
            }
            Vehicles vehicle = new Vehicles
            {
                Vehicle_ID = Id,
                VehiclCategoryId = Convert.ToInt32(cmboboxupdateCategory.SelectedValue.ToString()),
                MakeID = Convert.ToInt32(cmboboxupdatemaker.SelectedValue.ToString()),
                ModelId = Convert.ToInt32(comboboxupdatemodel.SelectedValue.ToString()),
                Mileage = Convert.ToDecimal(txtboxmileageupdate.Text.ToString()),
                enginenumber = (txtboxupdateenginenumber.Text.ToString()),
                chessisnumber = (txtboxupdatechessisnumber.Text.ToString()),
                cc = txtboxupdatecc.Text.ToString(),
                colour = txtboxupdatecolor.Text.ToString(),
                modelyear = txtboxupdatemodelyear.Text.ToString(),
                registrationyear = Convert.ToInt32(txtboxupdateregistrationyear.Text.ToString()),
                numberplate=txtboxupdatenumberplate.Text.ToString()
                
            };
            if (vehicleBusiness.updateVehicle(vehicle))
            {
                RadMessageBox.Show("Updated");
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;


                txtboxupdateenginenumber.Clear();
                txtboxmileageupdate.Clear();
                txtboxupdatecc.Clear();
                txtboxupdatechessisnumber.Clear();
                txtboxupdatecolor.Clear();
                txtboxupdatemodelyear.Clear();
                txtboxupdateregistrationyear.Clear();
                txtboxupdatenumberplate.Clear();

                dgvmanagepage.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");
            }
            else
            {
                RadMessageBox.Show("Failed");
                //}
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles { Vehicle_ID = Id };
            var confirm = RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                if (vehicleBusiness.deleteVehicle(vehicle))
                {
                    RadMessageBox.Show("Deleted");
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    dgvmanagepage.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");
                }
                else
                {
                    RadMessageBox.Show("Failed");
                    //}
                }
            }
            else
            {

            }
        }

        //manage vehicle page starts





        //manage vehicle detail page starts

            //category work
        private void btnaddcategoryname_Click(object sender, EventArgs e)
        {
            if (txtboxdetailcategory.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter Required Fields");
                return;
            }
            VehicleCategory vehicleCategory = new VehicleCategory()
            {
                Name = txtboxdetailcategory.Text.ToString()
            };
            if (new VehicelCategoryBusiness().AddVehicleCategory(vehicleCategory))
            {
                RadMessageBox.Show("Added");
                txtboxdetailcategory.Clear();
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btnupdatecategorydetails_Click(object sender, EventArgs e)
        {
            if (txtboxdetailcategory.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter Required Fields");
                return;
            }
            VehicleCategory vehicleCategory = new VehicleCategory()
            {
                VehicleCategoryId = Convert.ToInt32(txtboxcatid.Text.ToString()),
                Name = txtboxdetailcategory.Text.ToString()
            };
            if (new VehicelCategoryBusiness().UpdateVehicleCategory(vehicleCategory))
            {
                RadMessageBox.Show("updated");
                txtboxdetailcategory.Clear();
                btnupdatecategorydetails.Enabled = false;
                btndltcategorydetails.Enabled = false;
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btndltcategorydetails_Click(object sender, EventArgs e)
        {
            VehicleCategory vehicleCategory = new VehicleCategory()
            {
                VehicleCategoryId = Convert.ToInt32(txtboxcatid.Text.ToString()),

            };
            var confirm = RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                if (new VehicelCategoryBusiness().DeleteVehicleCategory(vehicleCategory))
                {
                    RadMessageBox.Show("Deleted");
                    btnupdatecategorydetails.Enabled = false;
                    btndltcategorydetails.Enabled = false;
                    comboboxdataInitialize();

                }
                else
                {
                    RadMessageBox.Show("Failed");
                }
            }
            else
            {

            }
        }

        private void dgvvehiclecategory_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnupdatecategorydetails.Enabled = true;
            btndltcategorydetails.Enabled = true;
            try
            {
                txtboxcatid.Text = dgvvehiclecategory.Rows[e.RowIndex].Cells["VehicleCategoryId"].Value.ToString();
                txtboxdetailcategory.Text = dgvvehiclecategory.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
            catch (Exception exception)
            {

            }
        }

        //category work end



            //maker working code
        private void btnaddMakerName_Click(object sender, EventArgs e)
        {
            if (txtboxdetailmaker.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter All Values");
                return;
            }
            VehicleMaker vehicleMaker = new VehicleMaker()
            {
                Name = txtboxdetailmaker.Text.ToString(),
                VehicleCategoryId=Convert.ToInt32(comboboxcategorydetail.SelectedValue.ToString())
            };
            if (new VehicleMakerBusiness().AddVehicleMaker(vehicleMaker))
            {
                RadMessageBox.Show("Added");
                txtboxdetailmaker.Clear();
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btnupdatemakerdetails_Click(object sender, EventArgs e)
        {
            if (txtboxdetailmaker.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter All Values");
                return;
            }
            VehicleMaker vehicleMaker = new VehicleMaker()
            {
                VehicleMakerID = Convert.ToInt32(txtboxcatid.Text.ToString()),
                Name = txtboxdetailmaker.Text.ToString(),
                VehicleCategoryId=Convert.ToInt32(comboboxcategorydetail.SelectedValue.ToString())
            };
            if (new VehicleMakerBusiness().UpdateVehicleMaker(vehicleMaker))
            {
                RadMessageBox.Show("updated");
                txtboxdetailmaker.Clear();
                btnupdatemakerdetails.Enabled = false;
                btndltmakerdetails.Enabled = false;
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btndltmakerdetails_Click(object sender, EventArgs e)
        {

            VehicleMaker vehicleMaker = new VehicleMaker()
            {
                VehicleMakerID = Convert.ToInt32(txtboxcatid.Text.ToString()),

            };
            var confirm = RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                if (new VehicleMakerBusiness().DeleteVehicleMaker(vehicleMaker))
                {
                    RadMessageBox.Show("updated");
                    btnupdatemakerdetails.Enabled = false;
                    btndltmakerdetails.Enabled = false;
                    comboboxdataInitialize();

                }
                else
                {
                    RadMessageBox.Show("Failed");
                }
            }
            else
            {

            }
        }

        private void dgvvehiclemaker_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnupdatemakerdetails.Enabled = true;
            btndltmakerdetails.Enabled = true;
            try
            {

                if (string.IsNullOrEmpty(dgvvehiclemaker.Rows[e.RowIndex].Cells["vehicle_category_id"].Value.ToString()))
                {
                    txtboxcatid.Text = dgvvehiclemaker.Rows[e.RowIndex].Cells["VehicleMakerID"].Value.ToString();
                    txtboxdetailmaker.Text = dgvvehiclemaker.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }
                else
                {
                    comboboxcategorydetail.SelectedValue = Convert.ToInt32(dgvvehiclemaker.Rows[e.RowIndex].Cells["vehicle_category_id"].Value.ToString());

                    txtboxcatid.Text = dgvvehiclemaker.Rows[e.RowIndex].Cells["VehicleMakerID"].Value.ToString();
                    txtboxdetailmaker.Text = dgvvehiclemaker.Rows[e.RowIndex].Cells["Maker"].Value.ToString();
                }
                
            }
            catch (Exception exception)
            {
                exception.Message.ToString();
            }
        }

        //maker working code end

        //model work code

        private void btnaddModelName_Click(object sender, EventArgs e)
        {
            if (txtboxdetailmodel.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter All Values");
                return;
            }
            VehicleModel vehicleModel = new VehicleModel()
            {
                Name = txtboxdetailmodel.Text.ToString(),
                vehicle_maker_id=Convert.ToInt32(comboboxdetailmaker.SelectedValue.ToString())
            };
            if (new VehicleModelBusiness().AddVehicleModel(vehicleModel))
            {
                RadMessageBox.Show("Added");
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btnupdatemodeldetails_Click(object sender, EventArgs e)
        {
            if (txtboxdetailmodel.Text.ToString() == "")
            {
                RadMessageBox.Show("Enter All Values");
                return;
            }
            VehicleModel vehicleModel = new VehicleModel()
            {
                VehicelModelId = Convert.ToInt32(txtboxcatid.Text.ToString()),
                Name = txtboxdetailmodel.Text.ToString(),
                vehicle_maker_id=Convert.ToInt32(comboboxdetailmaker.SelectedValue.ToString())
            };
            if (new VehicleModelBusiness().UpdateVehicleModel(vehicleModel))
            {
                RadMessageBox.Show("updated");
                txtboxdetailmodel.Clear();
                btnupdatemodeldetails.Enabled = false;
                btndltmodeldetails.Enabled = false;
                comboboxdataInitialize();

            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btndltmodeldetails_Click(object sender, EventArgs e)
        {
            VehicleModel vehicleModel = new VehicleModel()
            {
                VehicelModelId = Convert.ToInt32(txtboxcatid.Text.ToString())

            };
            var confirm = RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                if (new VehicleModelBusiness().DeleteVehicleModel(vehicleModel))
                {
                    RadMessageBox.Show("updated");
                    btnupdatemodeldetails.Enabled = false;
                    btndltmodeldetails.Enabled = false;
                    comboboxdataInitialize();

                }
                else
                {
                    RadMessageBox.Show("Failed");
                }
            }
            else
            {

            }
        }

        private void dgvvehiclemodel_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnupdatemodeldetails.Enabled = true;
            btndltmodeldetails.Enabled = true;
            try
            {
                if (string.IsNullOrEmpty(dgvvehiclemodel.Rows[e.RowIndex].Cells["vehicle_maker_id"].Value.ToString()))
                {
                    txtboxcatid.Text = dgvvehiclemodel.Rows[e.RowIndex].Cells["VehicleModelID"].Value.ToString();
                    txtboxdetailmodel.Text = dgvvehiclemodel.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }
                else
                {
                    comboboxdetailmaker.SelectedValue = dgvvehiclemodel.Rows[e.RowIndex].Cells["vehicle_maker_id"].Value.ToString();
                    txtboxcatid.Text = dgvvehiclemodel.Rows[e.RowIndex].Cells["VehicleModelID"].Value.ToString();
                    txtboxdetailmodel.Text = dgvvehiclemodel.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }
            }
            catch (Exception exception)
            {

            }
        }


        //model work code end

        //validation of text boxex
        private void comboboxupdatemodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxregistrationyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }


        private void txtboxupdateregistrationyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxupdatemodelyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxmileageupdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void txtboxupdatecc_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressnumbers(sender, e);
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }


        //validation of text box end

        #endregion

        #region methods



        public void comboboxdataInitialize()
        {
            //combobox vehicle category data initialization start

            comboboxvehiclecategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            comboboxvehiclecategory.DisplayMember = "Name";
            comboboxvehiclecategory.ValueMember = "VehicleCategoryId";

            // combobox vehicle category data initialization end

            comboboxvehicleModel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");
            comboboxvehicleModel.DisplayMember = "Name";
            comboboxvehicleModel.ValueMember = "VehicleModelID";


            comboboxvehiclecMaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            comboboxvehiclecMaker.DisplayMember = "Maker";
            comboboxvehiclecMaker.ValueMember = "VehicleMakerID";

            
            dgvAddVehicle.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");






            //manage page initializzation
            cmboboxupdateCategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            cmboboxupdateCategory.DisplayMember = "Name";
            cmboboxupdateCategory.ValueMember = "VehicleCategoryId";


            comboboxupdatemodel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");
            comboboxupdatemodel.DisplayMember = "Name";
            comboboxupdatemodel.ValueMember = "VehicleModelID";


            cmboboxupdatemaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            cmboboxupdatemaker.DisplayMember = "Maker";
            cmboboxupdatemaker.ValueMember = "VehicleMakerID";

            // updatedltgridviewvehicles.DataSource = vehicle.getVehicleCatmakmodel("allVehicles");
            dgvmanagepage.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("allVehicles");


            //add details page initialization

            //combobox vehiclecategory in maker initialize
           
            comboboxcategorydetail.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            comboboxcategorydetail.DisplayMember = "Name";
            comboboxcategorydetail.ValueMember = "VehicleCategoryId";






            //combbox vehiclemaker in vehicle model initialization


            comboboxdetailmaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            comboboxdetailmaker.DisplayMember = "Maker";
            comboboxdetailmaker.ValueMember = "VehicleMakerID";


            //combobox vehiclecategory in maker initialize end


            dgvvehiclecategory.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleCategory");
            dgvvehiclemaker.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleMaker");
            dgvvehiclemodel.DataSource = VehicelCategoryBusiness.getVehicleCatmakmodel("VehicleModel");





        }

        public void hiddingcolumns()
        {
            //add vehicle columns hiding and setting header text start 
            dgvAddVehicle.Columns["MakeID"].IsVisible = false;
            dgvAddVehicle.Columns["ModelId"].IsVisible = false;
            dgvAddVehicle.Columns["VehiclCategoryId"].IsVisible = false;
            dgvAddVehicle.Columns["Vehicle_ID"].IsVisible = false;
            dgvAddVehicle.Columns["enginenumber"].HeaderText = "Engine Number";
            dgvAddVehicle.Columns["chessisnumber"].HeaderText = "Chessis Number";
            dgvAddVehicle.Columns["registrationyear"].HeaderText = "Registration Year";
            dgvAddVehicle.Columns["modelyear"].HeaderText = "Model Year";
            dgvAddVehicle.Columns["numberplate"].HeaderText = "Number Plate";
            //add vehicle columns hiding and setting header text end


            //managevehicle columns hiding and setting header text start 

            dgvmanagepage.Columns["enginenumber"].HeaderText = "Engine Number";
            dgvmanagepage.Columns["chessisnumber"].HeaderText = "Chessis Number";
            dgvmanagepage.Columns["registrationyear"].HeaderText = "Registration Year";
            dgvmanagepage.Columns["modelyear"].HeaderText = "Model Year";
            dgvmanagepage.Columns["numberplate"].HeaderText = "Number Plate";
            dgvmanagepage.Columns["MakeID"].IsVisible = false;
            dgvmanagepage.Columns["ModelId"].IsVisible = false;
            dgvmanagepage.Columns["VehiclCategoryId"].IsVisible = false;
            dgvmanagepage.Columns["Vehicle_ID"].IsVisible = false;

            //manage vehicle columns hiding and setting header text end
        }

        public void hiddingandsettingcolumns()
        {
            dgvvehiclemodel.Columns["VehicleModelID"].IsVisible = false;
            dgvvehiclemodel.Columns["vehicle_maker_id"].IsVisible = false;


            dgvvehiclemaker.Columns["VehicleMakerID"].IsVisible = false;
            dgvvehiclemaker.Columns["vehicle_category_id"].IsVisible = false;

            dgvvehiclecategory.Columns["VehicleCategoryId"].IsVisible = false;
        }

        public void keypressnumbers(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception exception)
            {

            }
        }







        #endregion
      
    }
}

