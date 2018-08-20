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
using BLL.CustomerBusiness;
using Telerik.WinControls;

namespace VMSUI
{
    public partial class FrmCustomers : Telerik.WinControls.UI.RadForm
    {
        #region Objects
       
        
        #endregion
        #region Constructors
        public FrmCustomers()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeGridviews();
            hiddingandsettingcolumn();
        }

        #endregion
        #region Methods
        public void InitializeComboBox()
        {
            comboBoxcutomertype.DataSource = new CustomerTypeBusiness().getCustomerType();
            comboBoxcutomertype.DisplayMember = "Type";
            comboBoxcutomertype.ValueMember = "CustomerTypeId";



            cmbboxupdatecustomertype.DataSource = new CustomerTypeBusiness().getCustomerType();
            cmbboxupdatecustomertype.DisplayMember = "Type";
            cmbboxupdatecustomertype.ValueMember = "CustomerTypeId";
        }

        public void InitializeGridviews()
        {
            dgvAddCustomrs.DataSource = new CustomerBusiness().GetAllCustomers();
            dgvmanagepage.DataSource = new CustomerBusiness().GetAllCustomers();
            //dgvmanagecostumers.DataSource = new CustomerBusiness().GetAllCustomers();
            dgvmangectypes.DataSource = new CustomerTypeBusiness().getCustomerType();
        }


        public void hiddingandsettingcolumn()
        {
            dgvAddCustomrs.Columns["CustomerId"].IsVisible = false;
            dgvAddCustomrs.Columns["CustomerTypeID"].IsVisible = false;
            dgvAddCustomrs.Columns["Name"].IsVisible = false;
            dgvAddCustomrs.Columns["Gender"].IsVisible = false;
            dgvAddCustomrs.Columns["DoB"].IsVisible = false;
            dgvAddCustomrs.Columns["Remarks"].IsVisible = false;
            dgvAddCustomrs.Columns["RefrenceId"].IsVisible = false;
            dgvAddCustomrs.Columns["EmailAddress"].IsVisible = false;
            dgvAddCustomrs.Columns["Createdon"].IsVisible = false;

            dgvAddCustomrs.Columns["DoB"].HeaderText = "Date OF Birth";
            dgvAddCustomrs.Columns["IsCar"].HeaderText = "Car";
            dgvAddCustomrs.Columns["IsBike"].HeaderText = "Bike";



            dgvmanagepage.Columns["DoB"].HeaderText = "Date OF Birth";
            dgvmanagepage.Columns["IsCar"].HeaderText = "Car";
            dgvmanagepage.Columns["IsBike"].HeaderText = "Bike";
            dgvmanagepage.Columns["CustomerId"].IsVisible = false;
            dgvmanagepage.Columns["CustomerTypeID"].IsVisible = false;
            dgvmanagepage.Columns["Name"].IsVisible = false;
            dgvmanagepage.Columns["Gender"].IsVisible = false;
            dgvmanagepage.Columns["DoB"].IsVisible = false;
            dgvmanagepage.Columns["Remarks"].IsVisible = false;
            dgvmanagepage.Columns["RefrenceId"].IsVisible = false;
            dgvmanagepage.Columns["EmailAddress"].IsVisible = false;
            dgvmanagepage.Columns["Createdon"].IsVisible = false;


            dgvmangectypes.Columns["CustomerTypeID"].IsVisible = false;
        }
        #endregion
        #region events

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            if (txtboxcustomername.Text == "" || txtboxprimarycontactnumber.Text == ""  ||txtboxcnic.Text==""||txtboxlicensenumber.Text==""||!radRadioButtonFemale.IsChecked&&!radRadioButtonMale.IsChecked
               )
            {
                RadMessageBox.Show("Enetr All Fields");
            }
            else
            {
                string gender;
                bool car = false;
                bool bike = false;
                if (radRadioButtonMale.IsChecked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                if (radRadioButtonCar.IsChecked)
                {
                    car = true;
                }
                else if (radRadioButtonbike.IsChecked)
                {
                    bike = true;
                }

                Customers customer = new Customers()
                {
                    Name = txtboxcustomername.Text.ToString().ToUpper(),
                    CustomersTypeId = Convert.ToInt32(comboBoxcutomertype.SelectedValue.ToString()),
                    Gender = gender,
                    Dob = datetimepicker.Value,
                    Cnic = txtboxcnic.Text.ToString().ToUpper(),
                    LicenseNumber = txtboxlicensenumber.Text.ToString().ToUpper(),
                    Car = car,
                    Bike = bike,
                    Primarycontactnumber = txtboxprimarycontactnumber.Text.ToString().ToUpper(),
                    Secondarycontactnumber = txtboxsecondarycontactnumber.Text.ToString().ToUpper(),
                    Email = txtboxemail.Text.ToString(),
                    Remarks = txtboxremarks.Text.ToString().ToUpper(),
                    RefrenceId = txtboxrefrence.Text.ToString()
                };
                if (new CustomerBusiness().addCustomer(customer))
                {
                    RadMessageBox.Show("ADDED");
                    InitializeGridviews();

                }
                else
                {
                    RadMessageBox.Show("Failed", "ERROR");
                }
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtboxupdatename.Text.ToString()==""||
                 txtboxupdatecnic.Text.ToString() == "" ||
                txtboxupdateemail.Text.ToString() == "" ||
            txtboxupdatelicencenumber.Text.ToString() == "" ||
            txtboxupdateprimarycontactnumber.Text.ToString() == "" ||
            txtboxupdatesecondarycontactnumber.Text.ToString() == "" ||
            txtboxupdaterefrence.Text.ToString() == "" ||
            txtboxupdateremarks.Text.ToString() == ""|| txtboxid.Text.ToString()==""
                )
            {
                RadMessageBox.Show("Please Enter the Fields");
                return;
            }
            string gender;
            bool car = false;
            bool bike = false;
            if (radiobuttonupdatemale.IsChecked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (radiobuttonupdatevehiclecar.IsChecked)
            {
                car = true;
            }
            else if (radiobuttonupdatevehiclebike.IsChecked)
            {
                bike = true;
            }
            Customers customer = new Customers()
            {
                CostumersId = Convert.ToInt32(txtboxid.Text.ToString()),
                Name = txtboxupdatename.Text.ToString().ToUpper(),
                CustomersTypeId = Convert.ToInt32(cmbboxupdatecustomertype.SelectedValue.ToString()),
                Dob = Convert.ToDateTime(datetimeupdatedob.Value.ToString()),
                Cnic = txtboxupdatecnic.Text.ToString().ToUpper(),
                LicenseNumber = txtboxupdatelicencenumber.Text.ToString().ToUpper(),
                Gender=gender.ToUpper(),
                Car=car,
                Bike=bike,
                Primarycontactnumber = txtboxupdateprimarycontactnumber.Text.ToString(),
                Secondarycontactnumber = txtboxupdatesecondarycontactnumber.Text.ToString(),
                Email = txtboxupdateemail.Text.ToString(),
                Remarks = txtboxupdateremarks.Text.ToString().ToUpper(),
                RefrenceId = txtboxupdaterefrence.Text.ToString()
            };

            if(new CustomerBusiness().Updatecostumer(customer))
            {
                RadMessageBox.Show("Updated","Suucessful");
                txtboxupdatename.Clear();
                txtboxupdatecnic.Clear();
                txtboxupdateemail.Clear();
                txtboxupdatelicencenumber.Clear();
                txtboxupdateprimarycontactnumber.Clear();
                txtboxupdatesecondarycontactnumber.Clear();
                txtboxupdaterefrence.Clear();
                txtboxupdateremarks.Clear();
                btnUpdate.Enabled = false;
                btndelete.Enabled = false;
                InitializeGridviews();
            }
            else
            {
                MessageBox.Show("Failed", "Suucessful");
            }
        }

        private void dgvmanagepage_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btndelete.Enabled = true;
            try
            {
                txtboxid.Text = dgvmanagepage.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
                txtboxupdatename.Text = dgvmanagepage.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                cmbboxupdatecustomertype.SelectedValue = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["CustomerTypeID"].Value.ToString());
                //.Text = dgvmanagepage.Rows[e.RowIndex].Cells["chessisnumber"].Value.ToString();
                datetimeupdatedob.Value = Convert.ToDateTime(dgvmanagepage.Rows[e.RowIndex].Cells["DoB"].Value.ToString());
                txtboxupdatecnic.Text = dgvmanagepage.Rows[e.RowIndex].Cells["CNICNumber"].Value.ToString();
                txtboxupdatelicencenumber.Text = dgvmanagepage.Rows[e.RowIndex].Cells["LicenseNumber"].Value.ToString();
                // txtboxupdatecolor.Text = dgvmanagepage.Rows[e.RowIndex].Cells["colour"].Value.ToString();
                txtboxupdateprimarycontactnumber.Text = dgvmanagepage.Rows[e.RowIndex].Cells["PrimarycontactNumber"].Value.ToString();
                txtboxupdatesecondarycontactnumber.Text = dgvmanagepage.Rows[e.RowIndex].Cells["SecondaryContactNumber"].Value.ToString();
                txtboxupdateemail.Text = dgvmanagepage.Rows[e.RowIndex].Cells["EmailAddress"].Value.ToString();
                txtboxupdateremarks.Text = dgvmanagepage.Rows[e.RowIndex].Cells["Remarks"].Value.ToString();
                txtboxupdaterefrence.Text = dgvmanagepage.Rows[e.RowIndex].Cells["RefrenceId"].Value.ToString();

                if (dgvmanagepage.Rows[e.RowIndex].Cells["Gender"].Value.ToString() == "Male")
                {
                    radiobuttonupdatemale.IsChecked = true;
                }
                if (dgvmanagepage.Rows[e.RowIndex].Cells["Gender"].Value.ToString() == "Female")
                {
                    radiobuttonupdatefemale.IsChecked = true;
                }

                if (Convert.ToBoolean(dgvmanagepage.Rows[e.RowIndex].Cells["IsCar"].Value))
                {
                    radiobuttonupdatevehiclecar.IsChecked = true;
                }
                if (Convert.ToBoolean(dgvmanagepage.Rows[e.RowIndex].Cells["IsBike"].Value))
                {
                    radiobuttonupdatevehiclebike.IsChecked = true;
                }
            }
            catch(Exception exception)
            {
                Console.Write(exception.Message);
            }
            //Id = Convert.ToInt32(dgvmanagepage.Rows[e.RowIndex].Cells["Vehicle_ID"].Value.ToString());
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Customers customerid = new Customers()
            {
                CostumersId = Convert.ToInt32(txtboxid.Text.ToString())
            };
           var confirm= RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (new CustomerBusiness().DeleteCostumer(customerid))
                {
                    MessageBox.Show("Deleted");
                    btnUpdate.Enabled = false;
                    btndelete.Enabled = false;
                    InitializeGridviews();

                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else { }
        }

      

        private void dgvmangectypes_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                btnupdatecustomertype.Enabled = true;
                btndeletecustomertype.Enabled = true;
                txtboxctid.Text = dgvmangectypes.Rows[e.RowIndex].Cells["CustomerTypeId"].Value.ToString();
                txtboxcostumertype.Text = dgvmangectypes.Rows[e.RowIndex].Cells["Type"].Value.ToString();
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void btnaddcustomertype_Click(object sender, EventArgs e)
        {
            if (txtboxcostumertype.Text.ToString() == "")
            {
                RadMessageBox.Show("Please Enter Text In Costumer Type", "Error Empty Field");
                return;
            }
            CustomerType customertype = new CustomerType()
            {
                Type = txtboxcostumertype.Text.ToString().ToUpper()
            
            };

            if(new CustomerTypeBusiness().addCostumerType(customertype))
            {
                RadMessageBox.Show("ADDED");
                txtboxcostumertype.Clear();
                InitializeGridviews();
            }
            else
            {
                RadMessageBox.Show("Failed");
            }
        }

        private void btnupdatecustomertype_Click(object sender, EventArgs e)
        {
            if (txtboxcostumertype.Text.ToString() == ""|| txtboxctid.Text.ToString()=="")
            {
                RadMessageBox.Show("Please Enter Text In Costumer Type", "Error Empty Field");
                return;
            }
            CustomerType customertype = new CustomerType()
            {
                CustomerTypeId = Convert.ToInt32(txtboxctid.Text.ToString()),
                Type = txtboxcostumertype.Text.ToString().ToUpper()
            };
            if(new CustomerTypeBusiness().UpdateCustomerType(customertype))
            {
                RadMessageBox.Show("Updated");
                txtboxcostumertype.Clear();
                btnupdatecustomertype.Enabled = false;
                btndeletecustomertype.Enabled = false;
                InitializeComboBox();
                InitializeGridviews();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btndeletecustomertype_Click(object sender, EventArgs e)
        {

            if (txtboxcostumertype.Text.ToString() == "")
            {
                RadMessageBox.Show("Please Enter Text In Costumer Type", "Error Empty Field");
                return;
            }
            CustomerType customertype = new CustomerType()
            {
                CustomerTypeId = Convert.ToInt32(txtboxctid.Text.ToString()),

            };
            var confirm = RadMessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (new CustomerTypeBusiness().DeleteCostumerType(customertype))
                {
                    RadMessageBox.Show("Deleted");
                    txtboxcostumertype.Clear();
                    btnupdatecustomertype.Enabled = false;
                    btndeletecustomertype.Enabled = false;
                    InitializeComboBox();
                    InitializeGridviews();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {

            }
        }

        private void txtboxcnic_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtboxprimarycontactnumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxsecondarycontactnumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxupdateprimarycontactnumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxupdatesecondarycontactnumber_KeyPress(object sender, KeyPressEventArgs e)
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


        #endregion
    }
}

