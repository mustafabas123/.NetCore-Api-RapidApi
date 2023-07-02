using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Abstract
{
    public interface IAppUserDAL:IGenericDAL<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        int UserCount();
    }
}
