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
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDAL _testimonialDAL;
		public TestimonialManager(ITestimonialDAL testimonialDAL)
		{
			_testimonialDAL = testimonialDAL;
		}
		public void Tdelete(Testimonial t)
		{
			_testimonialDAL.delete(t);
		}

		public List<Testimonial> TGetAll()
		{
			return _testimonialDAL.getAll();
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDAL.GetById(id);
		}

		public void Tinsert(Testimonial t)
		{
			_testimonialDAL.insert(t);
		}

		public void Tupdate(Testimonial t)
		{
			_testimonialDAL.update(t);
		}
	}
}
