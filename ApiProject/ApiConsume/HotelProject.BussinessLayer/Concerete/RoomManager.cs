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
	public class RoomManager : IRoomService
	{
		private readonly IRoomDAL _roomDAL;
		public RoomManager(IRoomDAL roomDAL)
		{
			_roomDAL = roomDAL;
		}
		public void Tdelete(Room t)
		{
			_roomDAL.delete(t);
		}

		public List<Room> TGetAll()
		{
			return _roomDAL.getAll();
		}

		public Room TGetById(int id)
		{
			return _roomDAL.GetById(id);
		}

		public void Tinsert(Room t)
		{
			_roomDAL.insert(t);
		}

        public int TRoomCount()
        {
            return _roomDAL.RoomCount();
        }

        public void Tupdate(Room t)
		{
			_roomDAL.update(t);
		}
	}
}
