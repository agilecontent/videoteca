using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteca.Models;

namespace Videoteca.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var genres = this.DataContext.Genres.FindAll();
            var movies = this.DataContext.Movies.FindAll();
            ViewData["genres"] = genres;
            ViewData["movies"] = movies;
            return View();
        }
        public void Edit(int id)
        {
            var movie = this.DataContext.Movies.FindById(id);
            this.UpdateModel(movie);
            this.DataContext.Movies.Save(movie);
        }
    }
}
