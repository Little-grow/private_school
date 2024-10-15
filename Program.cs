
using Microsoft.EntityFrameworkCore;
using Private_School.Data;
using System.Configuration;

namespace Private_School
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //void ConfigureServices(IServiceCollection services)
            //{
            //    services.AddDbContext<ApplicationDbContext>(options =>
            //    {
            //        options.UseSqlServer("Server=.; Database=Private_School; Integrated Security=True;");
            //    });
            //}

            var connection = "Data Source=.;Database=Private_School;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;";
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
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
        }
    }
}
