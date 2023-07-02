using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;
		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}
		[HttpGet]
		public IActionResult GetStaf()
		{
			var values = _staffService.TGetAll();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteStaff(int id)
		{
			var values=_staffService.TGetById(id);
			_staffService.Tdelete(values);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.Tinsert(staff);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.Tupdate(staff);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetStaffWithId(int id)
		{
			var values= _staffService.TGetById(id);
			return Ok(values);
		}


		[HttpGet("GetLastFourStaff")]
		public IActionResult GetLastFourStaff()
		{
			var values = _staffService.TGetLastFourStaff();
			return Ok(values);
		}



    }
}
