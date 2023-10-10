using Autofac.Core;
using AutoMapper;
using Booking.Business.Abstract;
using Booking.Business.Concrete;
using Booking.DataAccess.Abstract;
using Booking.DataAccess.Concrete;
using Booking.Entities.Concrete;
using Booking.MobileApi;
using Business.AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<IHotelService, HotelManager>();
builder.Services.AddScoped<IHotelDAL, EFHotelDAL>();

builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();


// ConfigureServices metodu
builder.Services.AddSignalR();
; // Kimlik yönetimini ekleyin

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile<MappingProfile>();
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();


// Configure metodu
app.UseHttpsRedirection();
app.UseAuthorization();

app.UseRouting(); // UseRouting'i buraya taşıdık

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chat");
});

app.Run();