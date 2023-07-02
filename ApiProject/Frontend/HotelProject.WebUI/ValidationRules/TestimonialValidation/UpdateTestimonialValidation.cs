using FluentValidation;
using HotelProject.WebUI.Models.Testimonial;

namespace HotelProject.WebUI.ValidationRules.TestimonialValidation
{
    public class UpdateTestimonialValidation:AbstractValidator<UpdateTestimonialViewModel>
    {
        public UpdateTestimonialValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel yolu kısmı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
        }
    }
}
