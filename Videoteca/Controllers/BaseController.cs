using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteca.Models;

namespace Videoteca.Controllers
{
    public class BaseController : Controller
    {
        public BaseController():this(new DataContext())
        {
        }
        public BaseController (IDataContext dataContext)
	    {
            this.DataContext = dataContext;
	    }

        public IDataContext DataContext { get; set; }
    }
}
