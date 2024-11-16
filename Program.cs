
using Microsoft.EntityFrameworkCore;
using Student_Exam.Data;

namespace Student_Exam
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


            builder.Services.AddDbContext<ApplicationDBContext>(Options =>
            Options.UseSqlServer(builder.Configuration.GetConnectionString("DbName")));
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp",
                builder => builder
                .WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

            var app = builder.Build();
            app.UseCors("AllowReactApp");


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
