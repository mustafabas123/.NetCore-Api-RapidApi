using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationController : Controller
    {
        public async Task<IActionResult> Index(string? cityName)
        {
            if(!string.IsNullOrEmpty(cityName))
            {
                List<BookingApiLocationSearchViewModel> apiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={cityName}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "e8e6aa9efbmsh7b3e61ba7e531ecp147474jsn479f60cb37ea" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    apiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(apiLocationSearchViewModels);
                }
            }
            else
            {
                List<BookingApiLocationSearchViewModel> apiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name=Berlin"),
                    Headers =
    {
        { "X-RapidAPI-Key", "e8e6aa9efbmsh7b3e61ba7e531ecp147474jsn479f60cb37ea" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    apiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(apiLocationSearchViewModels);
                }
            }

        }
    }
}
