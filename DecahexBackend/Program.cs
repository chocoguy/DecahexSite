using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DecahexBackend;
using DecahexBackend.Models;
using DecahexBackend.Services;

//namespace DecahexBackend
//{ 
//    public class Program
//    {
//        //public static void Main(string[] args)
//        //{
//        //    CreateHostBuilder(args).Build().Run();
//        //}

//        //public static IHostBuilder CreateHostBuilder(string[] args) =>
//        //    Host.CreateDefaultBuilder(args)
//        //    .ConfigureWebHostDefaults(webBuilder =>
//        //    {
//        //        webBuilder.UseStartup<Startup>();
//        //    });
//    }

//}


var AllowOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowOrigins, policy => { policy.WithOrigins("http://localhost:5500", "http://decahex.net", "https://decahex.net"); });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
//{
//    options.Authority = domain;
//    options.Audience = "undefined";

//    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
//    {
//        NameClaimType = ClaimTypes.NameIdentifier
//    };

//});

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("read:messages", policy => policy.Requirements.Add(new DecahexBackend.ScopeRequirement("read:messages", domain)));
//});

//AddSingleton<IAuthorizationHandler, DecahexBackend.ScopeHandler>
builder.Services.AddSingleton<IAuthorizationHandler, ScopeHandler>();

builder.Services.Configure<UserStoreDatabaseSettings>(
    builder.Configuration.GetSection("UserStoreDatabse")
);


//builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<DbService>();




var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions { 
    ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}



app.UseCors(AllowOrigins);

//app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();

