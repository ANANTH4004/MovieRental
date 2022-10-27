using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Formatting;

namespace MovieRental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public  ActionResult Index()
        {
            List<Movie> movies = new List<Movie>(); 
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44338/api/");
                var response = client.GetAsync("movie");
                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var ans = result.Content.ReadAsAsync<Movie[]>();
                    ans.Wait();
                    var moviedata = ans.Result;
                    foreach (var item in moviedata)
                    {
                        movies.Add(new Movie() { Availability = item.Availability , Genre = item.Genre , Language = item.Language , MovieID = item.MovieID , Name = item.Name , Rating = item.Rating});
                    }
                    
                }
            }
            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
