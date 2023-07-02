using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void Tinsert(T t);
		void Tupdate(T t);
		void Tdelete(T t);
		T TGetById(int id);
		List<T> TGetAll();
	}
}
