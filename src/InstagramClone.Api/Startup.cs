using InstagramClone.Api.Database;
using InstagramClone.Api.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
            builder.Services.AddControllers();
            builder.Services.AddAuthentication();
            builder.Services.ConfigureIdentity();

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
            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<InstagramCloneDbContext>();
            var builder = services.AddIdentityCore<User>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = true;
                o.Password.RequireUppercase = true;
                o.Password.RequireNonAlphanumeric = true;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;
            });
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<InstagramCloneDbContext>().AddDefaultTokenProviders();
        }
    }
}
