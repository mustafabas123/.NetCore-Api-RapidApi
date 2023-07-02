using AutoMapper;
using HotelProject.EntityLayer.Concerete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginAppUserDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using HotelProject.WebUI.Dtos.RegisterAppUser;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.WorkLocationDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto,Service>().ReverseMap();

            CreateMap<UpdateServiceDto,Service>().ReverseMap();

            CreateMap<CreateServiceDto,Service>().ReverseMap();

            CreateMap<CreateAppUserDto,AppUser>().ReverseMap();

            CreateMap<LoginAppUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto,About>().ReverseMap();

            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<CreateAboutDto,About>().ReverseMap();

            CreateMap<ResultStaffDto,Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto,Booking>().ReverseMap();

            CreateMap<ResultBookingDto,Booking>().ReverseMap();

            CreateMap<ApprovedReservationDto,Booking>().ReverseMap();

            CreateMap<CreateContactDto,Contact>().ReverseMap();

            CreateMap<CreateGuestDto,Guest>().ReverseMap();

            CreateMap<ResultGuestDto, Guest>().ReverseMap();

            CreateMap<UpdateGuestDto,Guest>().ReverseMap();

            CreateMap<ContactInboxDto, Contact>().ReverseMap();

            CreateMap<CreateSendMessage, SendMessage>().ReverseMap();

            CreateMap<ResultMessageCategoryDto,MessageCategory>().ReverseMap();

            CreateMap<GetMessageByIdDto,SendMessage>().ReverseMap();

            CreateMap<CreateWorkLocationDto,WorkLocation>().ReverseMap();

            CreateMap<ResultWorkLocationDto,WorkLocation>().ReverseMap();

            CreateMap<UpdateWorkLocationDto,WorkLocation>().ReverseMap();

            CreateMap<ResultAppUserDto,AppUser>().ReverseMap();
        }
    }
}
