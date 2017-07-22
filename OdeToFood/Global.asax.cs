using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OdeToFood
{
    //this inheritance allows us to hook into application events
    public class MvcApplication : System.Web.HttpApplication
    {
        //ASP.NET invokes this method before the first http request is processed
        //necassary app configuration goes in here: eg: "RouteConfig"
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
