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
	public class EFRoomDAL:GenericRepository<Room>,IRoomDAL
	{
		public EFRoomDAL(Context context):base(context)
		{

		}

        public int RoomCount()
        {
            var context = new Context();
            var values = context.Rooms.Count();
            return values;
        }
    }
}
