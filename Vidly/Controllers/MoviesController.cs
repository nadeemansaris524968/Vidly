using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!"},
                new Movie { Id = 2, Name = "Wall-E"}
            };

            return View(movies);
        }
    }
}