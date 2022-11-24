using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProSales.Domain.Identity;
using ProSales.Repository.Contexts;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ProSales.API.Security;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

//var connetionString = builder.Configuration.GetConnectionString("MariaDBContext");

builder.Services.AddConfigContexts(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddMyDependencyGroup();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddConfigIdentity();

builder.Services.AddAuth();


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
