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
    public partial class FrmBookingReport : Form
    {
        public FrmBookingReport()
        {
            InitializeComponent();
        }

        private void FrmBookingReport_Load(object sender, EventArgs e)
        {

            this.bookingreport.RefreshReport();
        }
    }
}
