using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRestaurant.Site.Controllers
{
    public class HomeController : Controller
    {
        //Estímulo externo
        [HttpGet]
        public ActionResult Index()
        {
            // build
            var model = "MVCRestaurant.Data.Models.Restaurant";

            ViewBag.Message = model;

            // render
            return View();
        }

        
    }
}