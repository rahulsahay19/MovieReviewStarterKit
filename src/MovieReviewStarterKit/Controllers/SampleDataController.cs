using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieReviewStarterKit.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] MoviesList = new[]
      {
            "Die Another Day",
            "Jurassic World",
            "Grease",
            "Top Gun",
            "Independence Day",
            "Day After Tomorrow",
            "Girl Next Door",
            "Rocky",
            "Twister",
            "Titanic"
        };

        // GET: api/values
     
        [HttpGet("[action]")]
        public IEnumerable<Movie> GetMovies()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Movie
            {
               MovieName = MoviesList[rng.Next(MoviesList.Length)]
            });
        }

        public class Movie
        {
            public string MovieName { get; set; }
            
        }

    }
}
