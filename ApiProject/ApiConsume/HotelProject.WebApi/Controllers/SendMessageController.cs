using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }


        [HttpGet]
        public IActionResult GetSendMessage()
        {
            var values = _sendMessageService.TGetAll();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.TGetById(id);
            _sendMessageService.Tdelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Tupdate(sendMessage);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Tinsert(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _sendMessageService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            var value = _sendMessageService.GetSendMessageCount();
            return Ok(value);
        }
    }
}
