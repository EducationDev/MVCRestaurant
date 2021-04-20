using System.Web.Mvc;
using MVCRestaurant.Data.Models;
using MVCRestaurant.Data.Services;

namespace MVCRestaurant.Site.Controllers
{
    /// <summary>
    /// Estímulo externo
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IRestaurantData _db;
        public HomeController(IRestaurantData restaurantData)
        {
            _db = restaurantData;
        }

        [HttpGet]
        public ActionResult Index()
        {
            // build
            var model = _db.GetAll();
            
            // render
            return View(model); // => HTML
            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant model)
        {
            return View();
        }


    }
}