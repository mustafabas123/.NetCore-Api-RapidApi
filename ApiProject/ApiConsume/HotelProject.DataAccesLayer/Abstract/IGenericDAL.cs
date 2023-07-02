using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Abstract
{
	public interface IGenericDAL<T> where T : class
	{
		void insert(T t);
		void delete(T t);
		void update(T t);
		List<T> getAll();
		T GetById(int id);
	}
}
