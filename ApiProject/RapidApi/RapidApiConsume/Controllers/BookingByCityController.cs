﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string? cityId)
        {
            if(!string.IsNullOrWhiteSpace(cityId))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?dest_type=city&room_number=1&units=metric&checkout_date=2023-09-28&locale=en-gb&dest_id={cityId}&filter_by_currency=AED&checkin_date=2023-09-27&adults_number=2&order_by=popularity&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&page_number=0&children_number=2&include_adjacency=true"),
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
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?dest_type=city&room_number=1&units=metric&checkout_date=2023-09-28&locale=en-gb&dest_id=-1456928&filter_by_currency=AED&checkin_date=2023-09-27&adults_number=2&order_by=popularity&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&page_number=0&children_number=2&include_adjacency=true"),
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
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
        }
    }
}
