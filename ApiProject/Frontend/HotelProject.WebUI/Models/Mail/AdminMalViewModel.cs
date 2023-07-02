namespace HotelProject.WebUI.Models.Mail
{
    public class AdminMalViewModel
    {
        public int Name { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
