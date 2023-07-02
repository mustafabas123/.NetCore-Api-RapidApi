﻿using HotelProject.EntityLayer.Concerete;
using HotelProject.WebUI.Dtos.LoginAppUserDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginAppUserDto loginAppUserDto)
        {
            if(ModelState.IsValid)
            {
                var result=await _signInManager.PasswordSignInAsync(loginAppUserDto.UserName,loginAppUserDto.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Staff");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
