using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class DashboardLastSixBooking:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DashboardLastSixBooking(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5026/api/DashboardWidget/GetLastSixBooking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSixLastBooking>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
