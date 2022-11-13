using HotelBooking.API.Repositories;
using HotelBooking.API.Repositories.Interfaces;
using HotelBooking.API.Services;
using HotelBooking.API.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HotelBookingDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IHotelInformationService,HotelInformationService>();
builder.Services.AddTransient<IBookingService,BookingService>();



builder.Services.AddTransient<IHotelBookingRepository,HotelBookingRepository>();
builder.Services.AddTransient<IHotelInformationRepository,HotelInformationRepository>();

//builder.Services.ad

var app = builder.Build();


//app.Services.GetRequiredService<HotelBookingDBContext>().Database.EnsureCreated();
//HotelBookingDBContext dbcontext = app.Services.GetRequiredService<HotelBookingDBContext>();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
