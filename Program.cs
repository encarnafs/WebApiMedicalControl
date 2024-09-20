using Microsoft.EntityFrameworkCore;
using WebApiMedicalControl.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Cadena conexión BD
var connectionString = builder.Configuration.GetConnectionString("Connection");
//Registra servicio para la conexión a BD
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

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
