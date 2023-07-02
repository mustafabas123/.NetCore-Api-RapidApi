using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidation
{
    public class UpdateGuestValidation:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad kısmı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir kısmı boş geçilemez");
        }
    }
}
