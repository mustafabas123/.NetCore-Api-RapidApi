using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concerete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFrameWork
{
    public class EFAppUserDAL : GenericRepository<AppUser>, IAppUserDAL
    {
        public EFAppUserDAL(Context context) : base(context)
        {
        }

        public int UserCount()
        {
            var context = new Context();
            return context.Users.Count();
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var contex = new Context();
            return contex.Users.Include(x=>x.WorkLocation).ToList();
        }
    }
}
