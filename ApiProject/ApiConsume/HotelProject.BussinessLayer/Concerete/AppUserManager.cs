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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDAL _appUserDAL;
        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }

        public void Tdelete(AppUser t)
        {
            _appUserDAL.delete(t);
        }

        public List<AppUser> TGetAll()
        {
            return _appUserDAL.getAll();
        }

        public AppUser TGetById(int id)
        {
            return _appUserDAL.GetById(id);
        }

        public void Tinsert(AppUser t)
        {
            _appUserDAL.insert(t);
        }

        public void Tupdate(AppUser t)
        {
            _appUserDAL.update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserDAL.UserListWithWorkLocation();
        }

        public int UserCount()
        {
            return _appUserDAL.UserCount();
        }
    }
}
