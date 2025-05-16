using Backend.Data;
using System.Data.SqlClient;
using Backend.Models;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BackendDb");
Console.WriteLine($"Cadena de conexión: {connectionString}");

//registrar servicios
builder.Services.AddScoped<IBodegaRepository, BodegaEfRepository>();
builder.Services.AddScoped<IVinoRepository, VinoEfRepository>();

builder.Services.AddDbContext<BackendDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IBodegaServices, BodegaServices>();
builder.Services.AddScoped<IVinoServices, VinoServices>();


// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
