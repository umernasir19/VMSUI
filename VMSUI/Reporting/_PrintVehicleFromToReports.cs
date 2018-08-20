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
    public partial class _PrintVehicleFromToReports : Telerik.WinControls.UI.RadForm
    {
        public _PrintVehicleFromToReports()
        {
            InitializeComponent();
        }

        private void _PrintReports_Load(object sender, EventArgs e)
        {
            
        }

        private void btnloadReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnloadReport_Click_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehilceSystem.spGetVehiclesFromDate' table. You can move, or remove it, as needed.
            this.spGetVehiclesFromDateTableAdapter.Fill(this.vehilceSystem.spGetVehiclesFromDate, dtfrom.Value, dtto.Value);

            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
