using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CustomerBusiness
{
    public class CustomerBaseBusiness
    {
        protected CustomerDb customerDb;
        protected CustomerTypeDb customerTypeDb;

        public CustomerBaseBusiness()
        {
            customerDb = new CustomerDb();
            customerTypeDb = new CustomerTypeDb();
        }
    }
}
