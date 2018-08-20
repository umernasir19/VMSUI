using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RateCardBusiness
{
    public class RateCardBusiness:RateCardBaseBusiness
    {
        public DataTable getMakerFromCategory(VehicleMaker vehicleMaker)
        {
            return RateCardDB.getMakerFromCategory(vehicleMaker);
        }

        public DataTable getModelFromMaker(VehicleModel model)
        {
            return RateCardDB.getModelFromMaker(model);
        }

        public bool  addRateCard(RateCard rateCard)
        {
            return RateCardDB.addRateCard(rateCard);
        }

        public DataTable getRateCards()
        {
            return RateCardDB.getRateCards();
        }
        public void UpdateRateCardStatus()
        {
            RateCardDB.UpdateRateCardStatus();
        }
    }
}
