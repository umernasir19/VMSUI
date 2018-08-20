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
    public partial class _FrmCustomersDatewiseReport : Telerik.WinControls.UI.RadForm
    {
        public _FrmCustomersDatewiseReport()
        {
            InitializeComponent();
        }

        private void _FrmCustomersDatewiseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehilceSystem.GettheCustomersfromdate' table. You can move, or remove it, as needed.
        

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string from = dtfrom.Value.ToString("yyyy-MM-dd");
            string to = dtto.Value.ToString("yyyy-MM-dd");
            //this.getCostumersFromDateTableAdapter.Fill(this.vehilceSystem.getCostumersFromDate, dtfrom.Value.ToString(), dtto.Value.ToString());
            this.gettheCustomersfromdateTableAdapter.Fill(this.vehilceSystem.GettheCustomersfromdate, from, to);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            
        }
    }
}
