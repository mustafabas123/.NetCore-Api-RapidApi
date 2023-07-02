using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetContact()
        {
            var values = _contactService.TGetAll();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.Tdelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.Tupdate(contact);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date= Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.Tinsert(contact);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            var value = _contactService.TGetContactCount();
            return Ok(value);
        }
    }
}
