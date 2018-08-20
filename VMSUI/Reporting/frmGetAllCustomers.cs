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

namespace VMSUI
{
    public partial class frmGetAllCustomers : Form
    {
        public frmGetAllCustomers()
        {
            InitializeComponent();
        }

        private void frmGetAllCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehilceSystem.GetAllCostumers' table. You can move, or remove it, as needed.
            this.getAllCostumersTableAdapter.Fill(this.vehilceSystem.GetAllCostumers);
            //// TODO: This line of code loads data into the 'vehilceSystem.GetAllCostumers' table. You can move, or remove it, as needed.
            //this.getAllCostumersTableAdapter.Fill(this.vehilceSystem.GetAllCostumers);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
