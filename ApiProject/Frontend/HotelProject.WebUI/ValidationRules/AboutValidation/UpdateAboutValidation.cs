using FluentValidation;
using HotelProject.WebUI.Dtos.AboutDto;

namespace HotelProject.WebUI.ValidationRules.AboutValidation
{
    public class UpdateAboutValidation:AbstractValidator<UpdateAboutDto>
    {
        public UpdateAboutValidation()
        {
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik kısmı boş gecilemez");
            RuleFor(x => x.RoomCount).NotEmpty().WithMessage("Oda sayısı kısmı boş geçilemez");
            RuleFor(x => x.StaffCount).NotEmpty().WithMessage("Personel Sayısı kısmı boş geçilemez");
            RuleFor(x => x.CustomerCount).NotEmpty().WithMessage("Müşteri sayısı kısmı boş geçilemez");
        }
    }
}
