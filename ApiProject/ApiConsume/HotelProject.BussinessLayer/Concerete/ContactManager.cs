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
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public void Tdelete(Contact t)
        {
            _contactDAL.delete(t);
        }

        public List<Contact> TGetAll()
        {
            return _contactDAL.getAll();
        }

        public Contact TGetById(int id)
        {
            return _contactDAL.GetById(id);
        }

        public int TGetContactCount()
        {
            return _contactDAL.GetContactCount();
        }

        public void Tinsert(Contact t)
        {
            _contactDAL.insert(t);
        }

        public void Tupdate(Contact t)
        {
            _contactDAL.update(t);
        }
    }
}
