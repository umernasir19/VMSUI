using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BookingBusiness
{
    public class BookingBaseBusiness
    {
        protected BookingDb booking;
        
        public BookingBaseBusiness()
        {
            booking = new BookingDb();
        }
    }
}
