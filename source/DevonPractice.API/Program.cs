
using DevonPracticeInfrastructure.Dependencies;
using Microsoft.OpenApi;
using System.Reflection;
using DevonPracticeInfrastructure;

namespace DevonPractice.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.RegisterApplication(builder.Configuration);
            builder.Services.AddSwaggerGen(options =>

            {

                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                options.IncludeXmlComments(xmlPath);

            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
          
                app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI
            ();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
