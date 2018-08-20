using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class VehicleBaseBusiness
    {
        protected VehicleDb vehicleDb;
        protected VehicleMakerDb vehicleMakerDb;
        protected VehicleModelDb vehicleModelDb;

        public VehicleBaseBusiness()
      {
            vehicleDb = new VehicleDb();
            vehicleMakerDb = new VehicleMakerDb();
            vehicleModelDb = new VehicleModelDb();
        }

    }
}
