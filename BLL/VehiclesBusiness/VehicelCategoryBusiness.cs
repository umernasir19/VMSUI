using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL.VehiclesBusiness
{
    public class VehicelCategoryBusiness : VehicleBaseBusiness
    {

        public static DataTable getVehicleCatmakmodel(string flag)
        {
            return new VehicleCategoryDb().getVehicleCatmakmodel(flag);
        }
        public bool AddVehicleCategory(VehicleCategory vehicleCategory)
        {
            return new VehicleCategoryDb().AddVehicleCategory(vehicleCategory);
        }
        public bool UpdateVehicleCategory(VehicleCategory vehicleCategory)
        {
            return new VehicleCategoryDb().UpdateVehicleCategory(vehicleCategory);
        }
        public bool DeleteVehicleCategory(VehicleCategory vehicleCategory)
        {
            return new VehicleCategoryDb().DeleteVehicleCategory(vehicleCategory);
        }
    }
}
