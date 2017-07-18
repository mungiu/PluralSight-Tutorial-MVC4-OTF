using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {

        // GET: Cuisine, Search() - is an "action" according to route
        //Authorize = user has to be logged in to do the below action
        public ActionResult Search(string name = "french")
        {

            throw new Exception("Something terrible has happened");
            //encoding vs script attack
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}