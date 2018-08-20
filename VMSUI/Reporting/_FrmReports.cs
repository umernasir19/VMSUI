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
    public partial class _FrmReports : Telerik.WinControls.UI.RadForm
    {
        public _FrmReports()
        {
            InitializeComponent();
        }

        private void btnVehicleReports_Click(object sender, EventArgs e)
        {
            _FrmVehiclesReport vehiclesReport = new _FrmVehiclesReport();
            vehiclesReport.Show();
        }

        private void btncustomersreport_Click(object sender, EventArgs e)
        {
            _FrmCostumersReport costumersReport = new _FrmCostumersReport();
            costumersReport.Show();
        }
    }
}
