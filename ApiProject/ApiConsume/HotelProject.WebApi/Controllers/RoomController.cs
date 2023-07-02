using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;
		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}
		[HttpGet]
		public IActionResult GetRoom()
		{
			var values = _roomService.TGetAll();
			return Ok(values);
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteRoom(int id)
		{
			var values=_roomService.TGetById(id);
			_roomService.Tdelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.Tupdate(room);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.Tinsert(room);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetByIdWithRoom(int id)
		{
			var values = _roomService.TGetById(id);
			return Ok(values);
		}
	}
}
