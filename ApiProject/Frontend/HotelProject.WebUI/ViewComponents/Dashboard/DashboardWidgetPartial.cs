using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); // bir client oluştur
            var responseMessage = await client.GetAsync("http://localhost:5026/api/DashboardWidget/GetStaffCount");
            var JsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.StaffCount = JsonData;

            var client2 = _httpClientFactory.CreateClient(); // bir client oluştur
            var responseMessage2 = await client2.GetAsync("http://localhost:5026/api/DashboardWidget/GetBookingCount");
            var JsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.BookingCount = JsonData2;

            var client3 = _httpClientFactory.CreateClient(); // bir client oluştur
            var responseMessage3 = await client3.GetAsync("http://localhost:5026/api/DashboardWidget/GetUserCount");
            var JsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.UserCount = JsonData3;

            var client4 = _httpClientFactory.CreateClient(); // bir client oluştur
            var responseMessage4 = await client4.GetAsync("http://localhost:5026/api/DashboardWidget/GetRoomCount");
            var JsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.RoomCount = JsonData4;

            return View();
        }
    }
}
