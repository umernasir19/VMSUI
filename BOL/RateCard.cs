using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class RateCard
    {
        public int RateCardID { get; set; }
        public int  VehicleCategoryId { get; set; }
        public int VehicleModelId { get; set; }
        public int VehicleMakerID { get; set; }
        public decimal BaseRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string RateCardName { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
    }
}
