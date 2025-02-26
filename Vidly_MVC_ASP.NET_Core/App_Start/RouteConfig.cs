using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly_MVC_ASP.NET_Core
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Using new way of Creating Custom Routes using Attribute Routing
            //Enabling Attribute Routing
            routes.MapMvcAttributeRoutes();

            //Old way of creating custom routes
            #region
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"\d{4}",month = @"\d{2}" });
            //    new { year = @"2015|2016",month = @"\d{2}" });
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
