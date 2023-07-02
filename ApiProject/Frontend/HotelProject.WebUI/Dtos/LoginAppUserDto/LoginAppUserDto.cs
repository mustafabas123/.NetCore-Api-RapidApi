using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginAppUserDto
{
    public class LoginAppUserDto
    {
        [Required(ErrorMessage ="Lütfen kullanıcı Adını giriniz")]
        public string UserName { get; set;}
        [Required(ErrorMessage ="Lütfen şifreyi giriniz")]
        public string Password { get; set;} 
    }
}
