using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CustomerBusiness
{
    public class CustomerTypeBusiness:CustomerBaseBusiness
    {
        public DataTable getCustomerType()
        {
            return customerTypeDb.getCustomerTypes();
        }
        public bool addCostumerType(CustomerType customerType)
        {
            return customerTypeDb.addCostumerType(customerType);
        }
        public bool UpdateCustomerType(CustomerType customerType)
        {
            return customerTypeDb.UpdateCustomerType(customerType);
        }
        public bool DeleteCostumerType(CustomerType customerType)
        {
            return customerTypeDb.DeleteCostumerType(customerType);
        }
    }
}
