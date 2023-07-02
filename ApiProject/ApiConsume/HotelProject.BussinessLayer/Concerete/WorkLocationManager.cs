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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDAL _workLocationDAL;
        public WorkLocationManager(IWorkLocationDAL workLocationDAL)
        {
            _workLocationDAL = workLocationDAL;
        }

        public void Tdelete(WorkLocation t)
        {
            _workLocationDAL.delete(t);
        }

        public List<WorkLocation> TGetAll()
        {
            return _workLocationDAL.getAll();
        }

        public WorkLocation TGetById(int id)
        {
            return _workLocationDAL.GetById(id);
        }

        public void Tinsert(WorkLocation t)
        {
            _workLocationDAL.insert(t);
        }

        public void Tupdate(WorkLocation t)
        {
            _workLocationDAL.update(t);
        }
    }
}
