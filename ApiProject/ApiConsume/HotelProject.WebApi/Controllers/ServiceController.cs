using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;
		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}
		[HttpGet]
		public IActionResult GetService()
		{
			var values=_serviceService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.Tinsert(service); 
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.Tupdate(service);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteService(int id)
		{
			var valeus=_serviceService.TGetById(id);
			_serviceService.Tdelete(valeus);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var values = _serviceService.TGetById(id);
			return Ok(values);
		}
	}
}
