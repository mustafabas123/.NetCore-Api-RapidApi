using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }


        [HttpGet]
        public IActionResult GetWorkLocation()
        {
            var values = _workLocationService.TGetAll();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            _workLocationService.Tdelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Tupdate(workLocation);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Tinsert(workLocation);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _workLocationService.TGetById(id);
            return Ok(values);
        }
    }
}
