using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFrameWork
{
    public class EfBookingDAl: GenericRepository<Booking>, IBookingDAL
    {
        public EfBookingDAl(Context context) : base(context)
        {
        }

        public int BookingCount()
        {
            var context = new Context();
            var values = context.Bookings.Count();
            return values;
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context=new Context();
            var values =context.Bookings.Where(x=>x.BookingId ==booking.BookingId).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public List<Booking> GetLastSixBooking()
        {
            using(var context=new Context())
            {
                var values =context.Bookings.OrderByDescending(x=>x.BookingId).Take(6).ToList();
                return values;
            }
        }
    }
}
