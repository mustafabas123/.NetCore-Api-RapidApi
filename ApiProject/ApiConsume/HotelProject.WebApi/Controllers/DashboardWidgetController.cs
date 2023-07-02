using HotelProject.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;
        public DashboardWidgetController(IStaffService staffService, IBookingService bookingService,IAppUserService appUserService,IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService  = roomService;
        }

        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount()
        {
            var values = _staffService.StaffCount();
            return Ok(values);
        }

        [HttpGet("GetBookingCount")]
        public IActionResult GetBookingCount()
        {
            var values = _bookingService.TBookingCount();
            return Ok(values);
        }

        [HttpGet("GetUserCount")]
        public IActionResult GetUserCount()
        {
            var values = _appUserService.UserCount();
            return Ok(values);
        }

        [HttpGet("GetRoomCount")]
        public IActionResult GetRoomCount()
        {
            var values = _roomService.TRoomCount();
            return Ok(values);
        }

        [HttpGet("GetLastSixBooking")]
        public IActionResult GetLastSixBooking()
        {
            var values = _bookingService.TGetLastSixBooking();
            return Ok(values);
        }
    }
}
