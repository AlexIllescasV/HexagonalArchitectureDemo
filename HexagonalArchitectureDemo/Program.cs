
using HexaArchDemo.Application.Repository;
using HexaArchDemo.Domain.IRepository;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Adapters;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports;
using HexaArchDemo.Infrastructure.Drivers.Adapters;
using HexaArchDemo.Infrastructure.Drivers.Ports;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestConnection")));

builder.Services.AddScoped<IPersonaPort, PersonaAdapter>();

builder.Services.AddScoped<IPersonaDriverPort, PersonaDriverAdapter>();

builder.Services.AddScoped<IPersonaRepository, PersonaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
