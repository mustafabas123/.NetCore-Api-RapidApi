using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }


        [HttpGet]
        public IActionResult GetGuest()
        {
            var values = _guestService.TGetAll();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetById(id);
            _guestService.Tdelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.Tupdate(guest);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.Tinsert(guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _guestService.TGetById(id);
            return Ok(values);
        }
    }
}
