
using DomainLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer;
using PersistenceLayer.Data;
using PersistenceLayer.Repositories;
using ServiceAbstractionLayer;
using ServiceLayer;
using Shared.ErrorModels;
using System.Threading.Tasks;
using Talabat.CustomMiddleWares;
using Talabat.Extentions;
using Talabat.Factories;

namespace Talabat
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Add services to the container
            builder.Services.AddControllers();

            //Calling Swagger Service
            builder.Services.AddSwaggerService();

            #region Register User-Defined Services
            // Calling Service Layer
            builder.Services.AddApplicationServices();

            // Calling Persistence Layer
            builder.Services.AddInfrastructureServices(builder.Configuration);


            //calling Web Application Services
            builder.Services.AddWebApplicationService();
            #endregion

            #endregion

            var app = builder.Build();


            // Calling Seed Database
            await app.SeedDatabaseAsync();

            // Configure the HTTP request pipeline.


            //Calling Custom Exception Middleware
             app.UseCustomExceptionMiddleware();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
