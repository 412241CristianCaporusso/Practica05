using Microsoft.EntityFrameworkCore;
using TurnosRepository.Models.Entities;
using TurnosRepository.Repositories.Contracts;
using TurnosRepository.Repositories.Implementations;
using TurnosRepository.Service.Contracts;
using TurnosRepository.Service.Implementations;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<turnosDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DefaultConnection")));

builder.Services.AddScoped<ITurnoRepository, TurnoRepository>();

builder.Services.AddScoped<ITurnosService, TurnosService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
