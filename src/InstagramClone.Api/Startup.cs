using InstagramClone.Api.Database;
using Microsoft.EntityFrameworkCore;

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
            
            builder.Services.AddDbContext<InstagramCloneDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));

               
            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddControllers();
           

        }

        private static void Configure(WebApplication app)
        {
            if(app.Environment.IsDevelopment())
            {
                //app.UseSwagger(); 
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            
            app.MapGet("/", () => "Hello World!");
            
            
        }
    }
}
