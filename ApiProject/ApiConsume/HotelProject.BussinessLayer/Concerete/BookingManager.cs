using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concerete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _bookingDAL;
        public BookingManager(IBookingDAL bookingDAL)
        {
            _bookingDAL = bookingDAL;
        }

        public void IBookingStatusChangeApproved(Booking booking)
        {
            _bookingDAL.BookingStatusChangeApproved(booking);
        }

        public void IBookingStatusChangeApproved2(int id)
        {
            _bookingDAL.BookingStatusChangeApproved2(id);
        }

        public int TBookingCount()
        {
            var values = _bookingDAL.BookingCount();
            return values;
        }

        public void Tdelete(Booking t)
        {
            _bookingDAL.delete(t);
        }

        public List<Booking> TGetAll()
        {
            return _bookingDAL.getAll();
        }

        public Booking TGetById(int id)
        {
            return _bookingDAL.GetById(id);
        }

        public List<Booking> TGetLastSixBooking()
        {
            return _bookingDAL.GetLastSixBooking();
        }

        public void Tinsert(Booking t)
        {
            _bookingDAL.insert(t);
        }

        public void Tupdate(Booking t)
        {
           _bookingDAL.update(t);
        }
    }
}
