using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Abstract
{
    public interface IBookingDAL:IGenericDAL<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        int BookingCount();
        List<Booking> GetLastSixBooking();
    }
}
