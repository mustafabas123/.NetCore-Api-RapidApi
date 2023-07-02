using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.EntityLayer.Concerete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using HotelProject.WebUI.ValidationRules.AboutValidation;
using HotelProject.WebUI.ValidationRules.GuestValidation;
using HotelProject.WebUI.ValidationRules.RoomValidation;
using HotelProject.WebUI.ValidationRules.StaffValidation;
using HotelProject.WebUI.ValidationRules.TestimonialValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();

builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidation>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidation>();

builder.Services.AddTransient<IValidator<UpdateAboutDto>, UpdateAboutValidation>();

builder.Services.AddTransient<IValidator<UpdateRoomDto>, UpdateRoomValidation>();
builder.Services.AddTransient<IValidator<CreateRoomDto>, CreateRoomValidation>();

builder.Services.AddTransient<IValidator<UpdateStaffViewModel>, UpdateStaffValidation>();
builder.Services.AddTransient<IValidator<AddStaffViewModel>, CreateStaffValidation>();

builder.Services.AddTransient<IValidator<UpdateTestimonialViewModel>, UpdateTestimonialValidation>();
builder.Services.AddTransient<IValidator<AddTestimonialViewModel>, CreateTestimonialValidation>();


builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
	options.LoginPath = "/Login/Index/";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
