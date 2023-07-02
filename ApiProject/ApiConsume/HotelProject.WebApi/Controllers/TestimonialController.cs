using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;
		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		[HttpGet]
		public IActionResult GetTestimonial()
		{
			var values=_testimonialService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.Tinsert(testimonial);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteTestimonial(int id)
		{
			var values=_testimonialService.TGetById(id);
			_testimonialService.Tdelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.Tupdate(testimonial);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetTestimonialById(int id)
		{
			var values = _testimonialService.TGetById(id);
			return Ok(values);
		}
	}
}
