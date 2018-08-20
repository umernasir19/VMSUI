using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Vehicles
    {
        public int Vehicle_ID { get; set; }
        public int VehiclCategoryId { get; set; }
        public int MakeID { get; set; }
        public int ModelId { get; set; }
        public decimal Mileage { get; set; }
        public string enginenumber { get; set; }
        public string chessisnumber { get; set; }
        public int registrationyear { get; set; }
        public string cc { get; set; }
        public string colour { get; set; }
        public string modelyear { get; set; }
        public string numberplate { get; set; }
    }
}
