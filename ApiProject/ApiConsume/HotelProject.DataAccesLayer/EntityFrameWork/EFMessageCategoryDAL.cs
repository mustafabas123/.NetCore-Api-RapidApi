using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFrameWork
{
    public class EFMessageCategoryDAL:GenericRepository<MessageCategory>,IMessageCategoryDAL
    {
        public EFMessageCategoryDAL(Context context) : base(context)
        {

        }
    }
}
