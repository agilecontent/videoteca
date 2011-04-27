using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Videoteca
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("edit_movie_path", "movies/edit/{id}", new { controller = "Movies", action = "Edit" });
            routes.MapRoute("update_movie_path", "movies/update/{id}", new { controller = "Movies", action = "Update" });
            routes.MapRoute("rate_movie_path", "movies/rate/{id}", new { controller = "Movies", action = "Rate" });

            routes.MapRoute("genre_path", "genre/{id}", new { controller = "Genres", action = "show" });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}