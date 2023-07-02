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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDAL _guestDAL;
        public GuestManager(IGuestDAL guestDAL)
        {
            _guestDAL = guestDAL;
        }

        public void Tdelete(Guest t)
        {
            _guestDAL.delete(t);
        }

        public List<Guest> TGetAll()
        {
            return _guestDAL.getAll();
        }

        public Guest TGetById(int id)
        {
           return _guestDAL.GetById(id);
        }

        public void Tinsert(Guest t)
        {
            _guestDAL.insert(t);
        }

        public void Tupdate(Guest t)
        {
            _guestDAL.update(t);
        }
    }
}
