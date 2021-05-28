using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Shreck", Id = 1},
                new Movie { Name = "Ice Age", Id = 2}
            };

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel);
            // return Content("Hello World!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        //movies
        public ActionResult Index()
        {


            return View(movies);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}