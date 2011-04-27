using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteca.Models;

namespace Videoteca.Controllers
{
    public class MoviesController : BaseController
    {
        public ActionResult Edit(int id)
        {
            var movie = this.DataContext.Movies.FindById(id);
            return View(movie);
        }

        public ActionResult Update(Movie m, int? genre_id)
        {
            if (genre_id.HasValue)
            {
                m.Genre = this.DataContext.Genres.FindById(genre_id.Value);
            }
            
            this.DataContext.Movies.Save(m);
            return RedirectToAction("index", "home");
        }

        public ActionResult Rate(int id, int rating)
        {
            var movie = this.DataContext.Movies.FindById(id);
            movie.Rating = rating;
            this.DataContext.Movies.Save(movie);

            return RedirectToAction("index", "home");
        }
    }
}
