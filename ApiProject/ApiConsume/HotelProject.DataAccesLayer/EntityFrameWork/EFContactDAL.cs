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
    public class EFContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public EFContactDAL(Context context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }
    }
}
