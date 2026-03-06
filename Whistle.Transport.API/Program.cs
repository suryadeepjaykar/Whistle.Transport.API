using Microsoft.EntityFrameworkCore;
using Whistle.Transport.API.Data;
using Whistle.Transport.API.Repositories;
using Whistle.Transport.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<RideRepository>();
builder.Services.AddScoped<RideService>();

builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<EmployeeService>();

builder.Services.AddScoped<VehicleRepository>();
builder.Services.AddScoped<VehicleService>();

builder.Services.AddScoped<DriverRepository>();
builder.Services.AddScoped<DriverService>();

builder.Services.AddScoped<RideStatusService>();
builder.Services.AddScoped<RideAssignmentService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
