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
	public class SubsribeManager : ISubscribeService
	{
		private readonly ISubscribeDAL _subscribeDAL;
		public SubsribeManager(ISubscribeDAL subscribeDAL)
		{
			_subscribeDAL = subscribeDAL;
		}
		public void Tdelete(Subscribe t)
		{
			_subscribeDAL.delete(t);
		}

		public List<Subscribe> TGetAll()
		{
			return _subscribeDAL.getAll();
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDAL.GetById(id);
		}

		public void Tinsert(Subscribe t)
		{
			_subscribeDAL.insert(t);
		}

		public void Tupdate(Subscribe t)
		{
			_subscribeDAL.update(t);
		}
	}
}
