using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidation
{
    public class CreateGuestValidation:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad kısmı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir kısmı boş geçilemez");
        }
    }
}
