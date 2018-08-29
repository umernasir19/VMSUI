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

namespace VMSUI.Reporting
{
    public partial class FrmCustomersByName : Telerik.WinControls.UI.RadForm
    {
        int id; 
        public FrmCustomersByName(Customers customers)
        {
            id = customers.CostumersId;
            InitializeComponent();
        }

        private void FrmCustomersByName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehilceSystem.GettheCostumersbyname' table. You can move, or remove it, as needed.
            //  this.gettheCostumersbynameTableAdapter.Fill(this.vehilceSystem.GettheCostumersbyname,id);
            // TODO: This line of code loads data into the 'vehilceSystem.GettheCostumersbyname' table. You can move, or remove it, as needed.
            try
            {
                this.gettheCostumersbynameTableAdapter.Fill(this.vehilceSystem.GettheCostumersbyname, id);

                this.reportViewer1.RefreshReport();
              
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
