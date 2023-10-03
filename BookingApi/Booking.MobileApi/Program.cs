using Autofac.Core;
using AutoMapper;
using Booking.Business.Abstract;
using Booking.Business.Concrete;
using Booking.DataAccess.Abstract;
using Booking.DataAccess.Concrete;
using Booking.Entities.Concrete;
using Business.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<IHotelService, HotelManager>();
builder.Services.AddScoped<IHotelDAL, EFHotelDAL>();

builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
builder.Services.AddScoped<ICategoryService, CayegoryManager>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile<MappingProfile>();
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
