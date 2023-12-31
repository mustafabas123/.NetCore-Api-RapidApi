﻿namespace HotelProject.WebUI.Dtos.SendMessageDto
{
    public class CreateSendMessage
    {
        public string ReceiverName { get; set; }
        public string ReceiverEmail { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
