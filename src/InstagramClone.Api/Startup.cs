﻿using InstagramClone.Api.Authentication;
using InstagramClone.Api.Configuration;
using InstagramClone.Api.Database;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace InstagramClone.Api
{
    public static class Startup
    {

        public static WebApplication InitialIzeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureService(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

        private static void ConfigureService(WebApplicationBuilder builder)
        {
            // registers the application controllers with the dependency injection container
            // see https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.mvcservicecollectionextensions.addcontrollers?view=aspnetcore-6.0

            builder.Services.AddAuthentication();


            // CORS means Cross origin Resource sharing, It allows a server to make cross domain call from 
            // the spcified domain while rejecting others by default due to browser security
            // see https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0
            builder.Services.AddCors();

            // registers the application dbContext with the depency injection container
            builder.Services.AddDbContext<InstagramCloneDbContext>(options =>
            {
                // configures the dbContext to use sql Server and this connection string 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));


            });

            builder.Services.AddScoped<AuthenticationManager>();
            builder.Services.ConfigureIdentity();
            builder.Services.AddControllers();
            builder.Services.JwtConfiguration(builder.Configuration);
        }

        private static void Configure(WebApplication app)
        {
            // The .UseHttpsRedirection() will issue HTTP response codes redirecting from http to https 
            app.UseHttpsRedirection();


            // matches request to an endpoint
            app.UseRouting();

            app.MapControllers();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapGet("/", () => "Hello World!");

        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, ApplicationRole>(optoins =>
            {
                optoins.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<InstagramCloneDbContext>();

        }
    }
}
