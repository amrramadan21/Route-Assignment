namespace DemoSession2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region Register Services In DI Container

            builder.Services.AddControllersWithViews();

            #endregion


            var app = builder.Build();

            #region MapGet

            //app.MapGet("/", () => "Hello World!"); // Default
            //app.MapGet("/Amr", () => "Hello Amr!"); //Static

            //app.MapGet("/{name}", async (context) =>
            //{

            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {name}");

            //}); //Dynamic Segment 

            //app.MapGet("/Miss{name}", async (context) =>
            //{

            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello Miss {name}");

            //}); //Mixed Segment  
            #endregion

            app.UseStaticFiles();

            app.MapControllerRoute(
              name: "Default",
              pattern: "{Controller=Home}/{Action=Index}/{id?}"

              );

            app.Run();
        }
    }
}
