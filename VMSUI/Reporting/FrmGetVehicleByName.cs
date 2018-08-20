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
    public partial class FrmGetVehicleByName : Form
    {
        int id;
        public FrmGetVehicleByName(Vehicles vehicles)
        {
            id = vehicles.Vehicle_ID;
            InitializeComponent();
        }

        private void FrmGetVehicleByName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehilceSystem.GetthevehiclebyIdName' table. You can move, or remove it, as needed.
            this.getthevehiclebyIdNameTableAdapter.Fill(this.vehilceSystem.GetthevehiclebyIdName,id);

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
