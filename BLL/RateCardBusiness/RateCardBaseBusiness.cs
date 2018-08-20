using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RateCardBusiness
{
    public class RateCardBaseBusiness
    {
        protected RateCardDb RateCardDB;
            public RateCardBaseBusiness()
        {
            RateCardDB = new RateCardDb();
        }
    }
}
