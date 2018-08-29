using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Booking
    {
        public int bookingid { get; set; }
        public int customerId { get; set; }
        public int vehicleId { get; set; }
        public int rateCardId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string postInspection { get; set; }
        public string  preInspection { get; set; }
        public decimal totalamount { get; set; }
    }
}
