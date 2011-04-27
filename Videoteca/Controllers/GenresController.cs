using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Videoteca.Controllers
{
    public class GenresController : BaseController
    {
        public ActionResult Show(int id)
        {
            var genre = this.DataContext.Genres.FindById(id);
            return View(genre);
        }
    }
}