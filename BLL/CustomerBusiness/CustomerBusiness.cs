using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;
using System.Data;

namespace BLL.CustomerBusiness
{
    public class CustomerBusiness:CustomerBaseBusiness
    {
     public bool addCustomer(Customers customer)
        {
            return customerDb.addCustomers(customer);
        }
        public DataTable GetAllCustomers()
        {
            return customerDb.GetAllCustomers();
        }
        public bool Updatecostumer(Customers customer)
        {
            return customerDb.UpdateCostumer(customer);
        }
        public bool DeleteCostumer(Customers customerid)
        {
            return customerDb.DeleteCostumer(customerid);
        }
        public DataTable SearchCustomer(Customers search)
        {
            return customerDb.SearchCustomer(search);
        }
    }

}
