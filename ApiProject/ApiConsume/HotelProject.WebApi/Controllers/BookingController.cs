using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _bookingService.TGetAll();
            return Ok(values);

        }
        [HttpDelete("{id}")]
        public IActionResult BookingDelete(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.Tdelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Tupdate(booking);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Tinsert(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("ChangeBookingStatus")]
        public IActionResult ChangeBookingStatus(Booking booking)
        {
            _bookingService.IBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("ChangeBookingStatusGet")]
        public IActionResult ChangeBookingStatusGet(int id)
        {
            _bookingService.IBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
