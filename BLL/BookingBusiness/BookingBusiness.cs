using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BookingBusiness
{
    public class BookingBusiness:BookingBaseBusiness
    {
        public DataTable GetAllCustomers()
        {
            return booking.GetAllCustomers();
        }

        public DataTable GetAllVehicles()
        {
            return booking.GetAllVehicles();
        }

        public DataTable GetAllRates()
        {
            return booking.getRateCards();
        }

        public bool AddBookings(Booking booking)
        {
            return base.booking.AddBookings(booking);
        }
        
        public DataTable GetAllBookings()
        {
            return base.booking.GetAllBookings();
        }
    }
}
