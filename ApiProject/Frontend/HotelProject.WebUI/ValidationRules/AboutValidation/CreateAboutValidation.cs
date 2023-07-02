using FluentValidation;
using HotelProject.WebUI.Dtos.AboutDto;

namespace HotelProject.WebUI.ValidationRules.AboutValidation
{
    public class CreateAboutValidation:AbstractValidator<CreateAboutDto>
    {
        public CreateAboutValidation()
        {
        }
    }
}
