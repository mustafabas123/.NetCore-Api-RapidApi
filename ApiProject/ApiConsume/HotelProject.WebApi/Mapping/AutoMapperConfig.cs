using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concerete;
using HotelProject.WebUI.Dtos.BookingDto;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<AddRoomDto, Room>();

            CreateMap<Room,AddRoomDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            //CreateMap<CreateBookingDto,Booking>().ReverseMap();
        }
    }
}
