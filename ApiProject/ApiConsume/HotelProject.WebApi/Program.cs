using HotelProject.BussinessLayer.Abstract;
using HotelProject.BussinessLayer.Concerete;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concerete;
using HotelProject.DataAccesLayer.EntityFrameWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IStaffDAL,EFStaffDAL>();
builder.Services.AddScoped<IStaffService,StaffManager>();

builder.Services.AddScoped<ITestimonialDAL,EFTestimonialDAL>();
builder.Services.AddScoped<ITestimonialService,TestimonialManager>();

builder.Services.AddScoped<IRoomDAL,EFRoomDAL>();
builder.Services.AddScoped<IRoomService,RoomManager>();

builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
builder.Services.AddScoped<IServiceService,ServiceManager>();

builder.Services.AddScoped<ISubscribeDAL, EFSubscribeDAL>();
builder.Services.AddScoped<ISubscribeService,SubsribeManager>();

builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
builder.Services.AddScoped<IAboutService,AboutManager>();

builder.Services.AddScoped<IBookingDAL,EfBookingDAl>();
builder.Services.AddScoped<IBookingService,BookingManager>();

builder.Services.AddScoped<IContactDAL, EFContactDAL>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IGuestDAL, EFGuestDAL>();
builder.Services.AddScoped<IGuestService,GuestManager>();

builder.Services.AddScoped<ISendMessageDAL,EFSendMessageDAL>();
builder.Services.AddScoped<ISendMessageService,SendMessageManager>();

builder.Services.AddScoped<IMessageCategoryDAL, EFMessageCategoryDAL>();
builder.Services.AddScoped<IMessageCategoryService,MessageCategoryManager>();

builder.Services.AddScoped<IWorkLocationDAL, EFWorkLocationDAL>();
builder.Services.AddScoped<IWorkLocationService,WorkLocationManager>();

builder.Services.AddScoped<IAppUserDAL, EFAppUserDAL>();
builder.Services.AddScoped<IAppUserService,AppUserManager>();

builder.Services.AddControllers().AddNewtonsoftJson(options=>options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(opt =>
{
	opt.AddPolicy("ApiCors", opts =>
	{
		opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
	});
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("ApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
