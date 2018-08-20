using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VehiclesBusiness
{
    public class VehicleModelBusiness:VehicleBaseBusiness
    {
        public bool AddVehicleModel(VehicleModel vehicleModel)
        {
            return vehicleModelDb.AddVehicleModel(vehicleModel);
        }
        public bool UpdateVehicleModel(VehicleModel vehicleModel)
        {
            return vehicleModelDb.UpdateVehicleModel(vehicleModel);
        }
        public bool DeleteVehicleModel(VehicleModel vehicleModel)
        {
            return vehicleModelDb.DeleteModel(vehicleModel);
        }
    }
}
