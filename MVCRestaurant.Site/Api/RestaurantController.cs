using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCRestaurant.Data.Services;

namespace MVCRestaurant.Site.Api
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantData _db;
        public RestaurantController()
        {
            _db = new InMemoryRestaurantData();
        }
        [HttpGet]
        public IEnumerable<MVCRestaurant.Data.Models.Restaurant> Get()
        {
            return _db.GetAll();
        }
    }
}
