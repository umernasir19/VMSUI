using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.VehiclesBusiness
{
    public class VehicleMakerBusiness:VehicleBaseBusiness
    {

        //public static DataTable getVehicleCatmakmodel(string flag)
        //{
        //    return new VehicleCategoryDb().getVehicleCatmakmodel(flag);
        //}
        public bool AddVehicleMaker(VehicleMaker vehicleMaker)
        {
            return vehicleMakerDb.AddVehicleMaker(vehicleMaker);
        }
        public bool UpdateVehicleMaker(VehicleMaker vehicleMaker)
        {
            return vehicleMakerDb.UpdateVehicleMaker(vehicleMaker);
        }
        public bool DeleteVehicleMaker(VehicleMaker vehicleMaker)
        {
            return vehicleMakerDb.DeleteVehicleMaker(vehicleMaker);
        }
    }
}
