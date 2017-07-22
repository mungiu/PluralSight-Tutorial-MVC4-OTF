using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace OdeToFood.Models
{
    //This class is used to persist and retrieve data
    public class OdeToFoodDb : DbContext
    {
        
        public OdeToFoodDb() : base("name=DefaultConnection") {}
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}