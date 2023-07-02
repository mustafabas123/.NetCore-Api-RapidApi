using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;
		public SubscribeController(ISubscribeService subscribeService)
		{
			_subscribeService = subscribeService;
		}
		[HttpGet]
		public IActionResult GetSubsribe()
		{
			var values = _subscribeService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddSubsribe(Subscribe subscribe)
		{
			_subscribeService.Tinsert(subscribe);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateSubsribe(Subscribe subscribe)
		{
			_subscribeService.Tupdate(subscribe);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteSubscribe(int id)
		{
			var values=_subscribeService.TGetById(id);
			_subscribeService.Tdelete(values);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetByIdSubsribe(int id)
		{
			var values = _subscribeService.TGetById(id);
			return Ok(values);
		}
	}
}
