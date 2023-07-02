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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void Tdelete(About t)
        {
            _aboutDAL.delete(t);
        }

        public List<About> TGetAll()
        {
            return _aboutDAL.getAll();
        }

        public About TGetById(int id)
        {
            return _aboutDAL.GetById(id);
        }

        public void Tinsert(About t)
        {
            _aboutDAL.insert(t);
        }

        public void Tupdate(About t)
        {
            _aboutDAL.update(t);
        }
    }
}
