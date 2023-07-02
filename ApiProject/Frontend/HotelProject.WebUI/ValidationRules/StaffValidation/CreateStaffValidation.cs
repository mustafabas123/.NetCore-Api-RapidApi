using FluentValidation;
using HotelProject.WebUI.Models.Staff;

namespace HotelProject.WebUI.ValidationRules.StaffValidation
{
    public class CreateStaffValidation:AbstractValidator<AddStaffViewModel>
    {
        public CreateStaffValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage(" Başlık kısmı boş geçilemez ");
            RuleFor(x => x.SocialMedia1).NotEmpty().WithMessage("Sosyal medya kısmı boş geçilemez");
            RuleFor(x => x.SocialMedia2).NotEmpty().WithMessage("Sosyal medya kısmı boş geçilemez");
            RuleFor(x => x.SocialMedia3).NotEmpty().WithMessage("Sosyal medya kısmı boş geçilemez");

        }
    }
}
