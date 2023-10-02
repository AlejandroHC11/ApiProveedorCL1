using ApiProveedorCL1.Models;
using ApiProveedorCL1.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DBContext
var connectionString = builder.Configuration.GetConnectionString("cibertec2023");
builder.Services.AddDbContext<cibertec2023Context>(options => options.UseSqlServer(connectionString));

//Inyeccion de dependencia
builder.Services.AddScoped<IProveedorRepository, ProveedorRepository>();

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
