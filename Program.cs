using PatientRiskAnalytics.Data;
using PatientRiskAnalytics.Interfaces;
using PatientRiskAnalytics.Services;
using Microsoft.EntityFrameworkCore;

namespace PatientRiskAnalytics
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddDbContext<PatientContext>(options =>
                options.UseInMemoryDatabase("PatientDb"));
            builder.Services.AddScoped<IRiskAssessmentService, RiskAssessmentService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Use Swagger in all environments for now
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PatientRiskAnalytics v1"));

            // Configure the HTTP request pipeline.
            // app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Add a default route
            app.MapGet("/", () => "Welcome to Patient Risk Analytics API. Please use /swagger to view the API documentation.");

            app.Run();
        }
    }
}
