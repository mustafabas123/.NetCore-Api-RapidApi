using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void IBookingStatusChangeApproved(Booking booking);
        void IBookingStatusChangeApproved2(int id);
        int TBookingCount();
        List<Booking> TGetLastSixBooking();
    }
}
