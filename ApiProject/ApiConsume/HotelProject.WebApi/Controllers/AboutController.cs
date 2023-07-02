using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }


        [HttpGet]
        public IActionResult GetAbout()
        {
            var values=_aboutService.TGetAll();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values=_aboutService.TGetById(id);
            _aboutService.Tdelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.Tupdate(about);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.Tinsert(about);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values=_aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
