using Microsoft.EntityFrameworkCore;
using Lms.Course.Infrastructure.Persistence;
using Lms.Course.Application.Interfaces;
using Lms.Course.Infrastructure.Repositories;
using Lms.Course.Application.Services;

namespace Lms.Course.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<CourseDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<ICourseRepository, CourseRepository>();
        builder.Services.AddScoped<ICourseService, CourseService>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowNextJs", policy =>
            {
                policy.WithOrigins("http://localhost:3000", "https://lms-shiko.vercel.app")
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI();


        app.UseHttpsRedirection();

        app.UseCors("AllowNextJs");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
