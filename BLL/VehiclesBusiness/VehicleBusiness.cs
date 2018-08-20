using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;
using System.Data;

namespace BLL
{
    public class VehicleBusiness : VehicleBaseBusiness
    {

        public  bool addVehicle(Vehicles vehicle)
        {
            return vehicleDb.AddVehicle(vehicle);
            
        }

        public bool updateVehicle(Vehicles vehicle)
        {
            return new VehicleDb().UpdateVehicle(vehicle);
        }

        public bool deleteVehicle(Vehicles vehicle)
        {
            return new VehicleDb().DeleteVehicle(vehicle);
        }
        public DataTable Searchvehicle(Vehicles vehicle)
        {
            return new VehicleDb().SearchVehicle(vehicle);
        }
    }
}
