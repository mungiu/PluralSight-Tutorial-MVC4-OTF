using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        //instantiating the database
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index(string searchTerm = null)
        {
            ////Retrieveing restaurants from SQL server and putting them into a list
            var model =
                 _db.Restaurants
                 .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                 .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                 .Take(10)
                 .Select(r => new RestaurantListViewModel
                         {
                             Id = r.Id,
                             Name = r.Name,
                             City = r.City,
                             Country = r.Country,
                             CountOfReviews = r.Reviews.Count()
                         }
                 );

            return View(model);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Location = "Denmark, Horsens";
            var model = new AboutModel();
            model.Name = "Andrei";
            model.Location = "Denmark, Horsens";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Disposing of the Db to free up resource
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}