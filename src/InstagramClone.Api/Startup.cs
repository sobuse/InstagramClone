using InstagramClone.Api.Database;
using Microsoft.AspNetCore.Builder;
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
            
            builder.Services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters();

             builder.Services.AddControllers();
            builder.Services.AddCors();

            builder.Services.AddDbContext<InstagramCloneDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));


            });

        }

        private static void Configure(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

           

            app.MapGet("/", () => "Hello World!");
            


        }
    }
}
