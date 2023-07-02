using HotelProject.EntityLayer.Concerete;
using HotelProject.WebUI.Dtos.RegisterAppUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateAppUserDto createAppUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createAppUserDto.Name,
                Surname = createAppUserDto.Surname,
                UserName=createAppUserDto.Username,
                Email=createAppUserDto.Mail,
                WorkLocationId = 1
            };
            var result=await _userManager.CreateAsync(appUser,createAppUserDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }

            return View();
        }
    }
}
