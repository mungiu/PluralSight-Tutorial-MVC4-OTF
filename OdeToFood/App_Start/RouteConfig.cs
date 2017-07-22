using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //makes sure the rout engine will not process requests to files on server
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // new RouteMap fo: eg:/Cuisine/french
            routes.MapRoute("Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search", name=UrlParameter.Optional });
            // RouteMap for eg:/Home/Index
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
