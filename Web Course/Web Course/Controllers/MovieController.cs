using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Web_Course.Models;
using Web_Course.ViewModels;

namespace Web_Course.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "John Wick" },
                new Movie { Id = 2, Name = "Oppenheimer" }
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "John Wick" };

            var customers = new List<Customer>()
            {
                new Customer { Name = "Cover Basha" },
                new Customer { Name = "Ziad Zaza" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }

    }
}