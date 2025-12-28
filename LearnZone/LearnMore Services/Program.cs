using Microsoft.EntityFrameworkCore;
using LearnZoneDAL;
using LearnZoneDAL.Models;

namespace LearnMore_Services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ CORS CONFIG
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAngular",
                    policy =>
                    {
                        policy
                            .WithOrigins(
                                "http://localhost:4200",
                                "https://localhost:4200"
                            )
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            // DB Context
            builder.Services.AddDbContext<LearnZoneContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("YourConnectionStringName")));

            builder.Services.AddScoped<LearnMoreRepositary>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // ✅ IMPORTANT ORDER
            app.UseRouting();
            app.UseCors("AllowAngular");

            app.UseAuthorization();

            app.MapControllers();
            app.Run();
        }
    }
}
