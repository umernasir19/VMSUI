using BLL.RateCardBusiness;
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
    public partial class frmhome : Telerik.WinControls.UI.RadForm
    {
        public frmhome()
        {
            InitializeComponent();
            new RateCardBusiness().UpdateRateCardStatus();

        }
        //public void UpdateRateCardStatus()
        //{
        //    new RateCardBusiness().UpdateRateCardStatus();
        //}
        private void btncustumer_Click(object sender, EventArgs e)
        {
            FrmCustomers customer = new FrmCustomers();
            customer.Show();
        }

        private void btnvehicle_Click(object sender, EventArgs e)
        {
            FrmVehicles vehicle = new FrmVehicles();
            vehicle.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            _FrmReports reports = new _FrmReports();
            reports.Show();
        }

        private void btnRatecard_Click(object sender, EventArgs e)
        {
            FrmRateCard rateCard = new FrmRateCard();
            rateCard.Show();
        }
    }
}
