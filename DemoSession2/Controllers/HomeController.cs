using Microsoft.AspNetCore.Mvc;

namespace DemoSession2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
        //    //return View();        //Return View With The Same Name Of Action [Index]
        //    //return View("Index"); //Return View With Specific Name Of Action [Index]
        //    //return View("Index",new Movie());          //Return View With Specific Name Action [Index] and Model
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
