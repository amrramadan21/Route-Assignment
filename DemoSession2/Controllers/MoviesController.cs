using DemoSession2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession2.Controllers
{
    public class MoviesController : Controller
    {

        public string Index()
        {
            return $"Hello From Index";
        }


        #region Example 01

        //Get BaseURL/Movies//GetMovie?id&name=filmname


        //[HttpGet]
        //public ContentResult GetMovie(int? id, string name)
        //{

        //    //ContentResult result = new ContentResult();
        //    //result.Content =$"Moive :: {id} </br> {name}";
        //    //result.ContentType = "text/html";
        //    //result.StatusCode = 700;
        //    //return result ;

        //    return Content($"Moive :: {id} </br> {name}", "text/html");
        //} 
        #endregion

        [HttpGet]

        public IActionResult GetMovie(int? id, string name)
        {
            //If id = 0 -> Bad Request
            //id < 10 -> NotFound
            //id >= 10 -> ReturnDate

            if (id == 0) return BadRequest();
            else if (id < 10) return NotFound();
            else return Content($"Movies With Name :{name} ,, Id : {id}");
        }

        [HttpGet]
        public IActionResult TestRedirectionToAction(int id)
        {

            return RedirectToAction("Default", new { Controller = "Movies", Action = "GetMovie" });
            //return RedirectToAction("GetMovies"); // Use it When The Action In The Same Cnotroller use the name of the action
            //return RedirectToAction(nameof(GetMovie), "Movies",new {id=15,name="test" }); // Use it When The Action In The Different Cnotroller use the name of the action and the controller
            //return Redirect("https://www.amazon.com");

        }

        [HttpPost]
        public IActionResult TestModelBindeing([FromRoute] int id, [FromQuery] string name)
        {
            return Content($"Hello {name} Your Id is {id}");
        }

        // Simple
        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {

            return Content($"Hello {movie.Title} Your Id Is {movie.Id}");

        }


        //Complex
        [HttpPost]
        public IActionResult AddMovie([FromHeader] int Id, [FromHeader] string Title)
        {

            return Content($"Hello {Title} Your Id Is {Id}");

        }

        //Mix
        public IActionResult AddMovie([FromHeader] int Id, Movie movie, [FromHeader] string Title)
        {

            return Content($"Hello {Title} Your Id Is {Id}");

        }

        //Collection
        public IActionResult AddMovie(int[] arr)
        {

            return Content($"Hello {arr[0]} Your Id Is {arr[1]}");

        }

    }
}
