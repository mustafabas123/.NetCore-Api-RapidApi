using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminMailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(AdminMalViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","mustafabas9012@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mustafabas9012@gmail.com", "mkedmovaouiwrfgr");
            client.Send(mimeMessage);
            client.Disconnect(true);

            CreateSendMessage createSendMessage = new CreateSendMessage();
            createSendMessage.SenderEmail = "mustafabas9012@gmail.com";
            createSendMessage.SenderName = "admin";
            createSendMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            createSendMessage.ReceiverName = "User";
            createSendMessage.ReceiverEmail = model.ReceiverMail;
            createSendMessage.Title = model.Subject;
            createSendMessage.Content = model.Body;
            var clientt = _httpClientFactory.CreateClient();
            var JsonData = JsonConvert.SerializeObject(createSendMessage);
            StringContent content = new StringContent(JsonData, Encoding.UTF8, "application/json");
            var responseMessage = await clientt.PostAsync("http://localhost:5026/api/SendMessage", content);

            return View();
        }
    }
}
