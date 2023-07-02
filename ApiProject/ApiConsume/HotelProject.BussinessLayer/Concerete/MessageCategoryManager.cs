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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDAL _messageCategoryDAL;
        public MessageCategoryManager(IMessageCategoryDAL messageCategoryDAL)
        {
            _messageCategoryDAL = messageCategoryDAL;
        }
        public void Tdelete(MessageCategory t)
        {
            _messageCategoryDAL.delete(t);
        }

        public List<MessageCategory> TGetAll()
        {
            return _messageCategoryDAL.getAll();
        }

        public MessageCategory TGetById(int id)
        {
            return _messageCategoryDAL.GetById(id);
        }

        public void Tinsert(MessageCategory t)
        {
            _messageCategoryDAL.insert(t);
        }

        public void Tupdate(MessageCategory t)
        {
            _messageCategoryDAL.update(t);
        }
    }
}
