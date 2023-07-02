using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Repositories
{
	public class GenericRepository<T> : IGenericDAL<T> where T : class
	{
		private readonly Context _context;
		public GenericRepository(Context context)
		{
			_context = context;
		}
		public void delete(T t)
		{
			_context.Remove(t);
			_context.SaveChanges();
		}

		public List<T> getAll()
		{
			return _context.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public void insert(T t)
		{
			_context.Add(t);
			_context.SaveChanges();
		}

		public void update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();
		}
	}
}
