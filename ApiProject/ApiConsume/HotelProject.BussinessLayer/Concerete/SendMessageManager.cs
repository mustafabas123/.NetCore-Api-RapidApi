using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concerete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDAL _sendMessageDAL;
        public SendMessageManager(ISendMessageDAL sendMessageDAL)
        {
            _sendMessageDAL = sendMessageDAL;
        }

        public int GetSendMessageCount()
        {
            return _sendMessageDAL.GetSendMessageCount(); 
        }

        public void Tdelete(SendMessage t)
        {
            _sendMessageDAL.delete(t);
        }

        public List<SendMessage> TGetAll()
        {
            return _sendMessageDAL.getAll();
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDAL.GetById(id);
        }

        public void Tinsert(SendMessage t)
        {
            _sendMessageDAL.insert(t);
        }

        public void Tupdate(SendMessage t)
        {
            _sendMessageDAL.update(t);
        }
    }
}
