using Demo.BLL.MappingProfiles;
using Demo.BLL.Services.Classes;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Data.Contexts;
using Demo.DAL.Repositories.Classes;
using Demo.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Pl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Configuration Services : Add services to the DI Container


            // Add services to the container.
            builder.Services.AddControllersWithViews(option =>
            {
                option.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            //Register Services And Give CLR The Permission To Inject This Service If Needed
            //builder.Services.AddScoped<ApplicationDbContext>(); 

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {

                //var conString = builder.Configuration["ConnectionStrings:DefaultConnection"];
                //var conString = builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];
                var conString = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(conString).UseLazyLoadingProxies();
            });

            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();


            //builder.Services.AddAutoMapper(typeof(MappingProfiles))
            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfiles()));



            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
