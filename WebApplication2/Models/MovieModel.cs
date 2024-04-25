using Microsoft.AspNetCore.Mvc;

namespace Movie.API.Models
{
    public class MovieModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Studio { get; set; }
        public double Duration { get; set; }
    }
    }
