using FluentValidation;
using HotelProject.WebUI.Dtos.RoomDto;

namespace HotelProject.WebUI.ValidationRules.RoomValidation
{
    public class CreateRoomValidation:AbstractValidator<CreateRoomDto>
    {
        public CreateRoomValidation()
        {
            RuleFor(x => x.RoomNumber).NotEmpty().WithMessage(" Oda numarası boş geçilemez ");
            RuleFor(x => x.RoomCoverImage).NotEmpty().WithMessage(" Görsel yolu kısmı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat kısmı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.BedCount).NotEmpty().WithMessage("Yatak sayısı kısmı boş geçilemez");
            RuleFor(x => x.BathCount).NotEmpty().WithMessage("Banyo sayısı boş geçilemez");
            RuleFor(x => x.Wifi).NotEmpty().WithMessage("Wifi kısmı boş geçilemez");
            RuleFor(x => x.Desctiption).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
        }
    }
}
