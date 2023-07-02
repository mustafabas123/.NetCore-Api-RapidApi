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
	public class StaffManager : IStaffService
	{
		private readonly IStaffDAL _staffDAL;
		public StaffManager(IStaffDAL staffDAL)
		{
			_staffDAL = staffDAL;
		}

        public List<Staff> TGetLastFourStaff()
        {
            return _staffDAL.GetLastFourStaff();
        }

        public int StaffCount()
        {
            return _staffDAL.StaffCount();
        }

        public void Tdelete(Staff t)
		{
			_staffDAL.delete(t);
		}

		public List<Staff> TGetAll()
		{
			return _staffDAL.getAll();
		}

		public Staff TGetById(int id)
		{
			return _staffDAL.GetById(id);
		}

		public void Tinsert(Staff t)
		{
			_staffDAL.insert(t);
		}

		public void Tupdate(Staff t)
		{
			_staffDAL.update(t);
		}
	}
}
