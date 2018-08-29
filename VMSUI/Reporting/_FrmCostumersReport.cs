using BLL.CustomerBusiness;
using BOL;
using Microsoft.Reporting.WinForms;
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
    public partial class _FrmCostumersReport :Telerik.WinControls.UI.RadForm
    {
        public _FrmCostumersReport()
        {
            InitializeComponent();
            InitializeGridviews();
           hiddingandsettingcolumns();
        }

        public void InitializeGridviews()
        {
            dgvcustomersearch.DataSource = new CustomerBusiness().GetAllCustomers();
           
        }


        public void hiddingandsettingcolumns()
        {
            dgvcustomersearch.Columns["CustomerId"].IsVisible = false;
            dgvcustomersearch.Columns["CustomerTypeId"].IsVisible = false;
            dgvcustomersearch.Columns["Costumer Name"].IsVisible = false;
            dgvcustomersearch.Columns["Gender"].IsVisible = false;
            dgvcustomersearch.Columns["DoB"].IsVisible = false;
            dgvcustomersearch.Columns["Remarks"].IsVisible = false;
            dgvcustomersearch.Columns["RefrenceId"].IsVisible = false;
            dgvcustomersearch.Columns["EmailAddress"].IsVisible = false;
            dgvcustomersearch.Columns["Createdon"].IsVisible = false;

            dgvcustomersearch.Columns["DoB"].HeaderText = "Date Of Birth";
            dgvcustomersearch.Columns["IsCar"].HeaderText = "Car";
            dgvcustomersearch.Columns["IsBike"].HeaderText = "Bike";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxsearch.Text.ToString() == " " || txtboxsearch.Text.ToString() == null || txtboxsearch.Text.ToString() == "")
            {
                InitializeGridviews();
            }
            else
            {
                Customers customer = new Customers()
                {
                    Name = (txtboxsearch.Text.ToString())
                };
                dgvcustomersearch.DataSource = new CustomerBusiness().SearchCustomer(customer);

                //this.spSearchCostumersTableAdapter.Fill(this.VehilceSystem.spSearchCostumers, txtboxsearch.Text.ToString());

                //this.reportViewer1.RefreshReport();
                //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
        }

        Bitmap bmp;
        private void dgvcustomersearch_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvcustomersearch.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                Customers customers = new Customers()
                {
                    CostumersId = id
                };
                FrmCustomersByName frmCustomersByName = new FrmCustomersByName(customers);
                frmCustomersByName.Show();
            }
            catch(Exception exception)
            {

            }
            //int height = dgvcustomersearch.Height;
            //dgvcustomersearch.Height = dgvcustomersearch.Height * dgvcustomersearch.Height * 2;
            //bmp = new Bitmap(dgvcustomersearch.Width, dgvcustomersearch.Height);
            //dgvcustomersearch.DrawToBitmap(bmp, new Rectangle(0, 0, dgvcustomersearch.Width, dgvcustomersearch.Height));
            //dgvcustomersearch.Height = height; 
            //printPreviewDialog1.Show();





        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGetAllCustomers allCustomers = new frmGetAllCustomers();
            allCustomers.Show();
        }

        private void btngetdatedreport_Click(object sender, EventArgs e)
        {
            _FrmCustomersDatewiseReport customersDatewiseReport = new _FrmCustomersDatewiseReport();
            customersDatewiseReport.Show();
        }

        private void _FrmCostumersReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VehilceSystem.spSearchCostumers' table. You can move, or remove it, as needed.
          
        }
    }
}
