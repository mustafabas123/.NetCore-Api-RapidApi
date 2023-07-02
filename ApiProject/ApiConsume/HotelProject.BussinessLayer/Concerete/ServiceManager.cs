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
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDAL _serviceDAL;
		public ServiceManager(IServiceDAL serviceDAL)
		{
			_serviceDAL = serviceDAL;
		}
		public void Tdelete(Service t)
		{
			_serviceDAL.delete(t);
		}

		public List<Service> TGetAll()
		{
			return _serviceDAL.getAll();
		}

		public Service TGetById(int id)
		{
			return _serviceDAL.GetById(id);
		}

		public void Tinsert(Service t)
		{
			_serviceDAL.insert(t);
		}

		public void Tupdate(Service t)
		{
			_serviceDAL.update(t);
		}
	}
}
