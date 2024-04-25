using Microsoft.EntityFrameworkCore;
using Movie.API;
using Movie.API.Services;
using System;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection string
var connString = "Data Source=Naniii\\SQLEXPRESS;Initial Catalog=MovieDb;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True";
builder.Services
    .AddDbContext<AppDbContext>(o => o.UseSqlServer(connString));

builder.Services.AddScoped<IMovieService, MoviesService>();


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