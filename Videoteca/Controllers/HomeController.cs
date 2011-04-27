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
            var movies = this.DataContext.Movies.FindAll();
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
