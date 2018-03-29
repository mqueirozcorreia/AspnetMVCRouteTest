using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteTest.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit(int promoId)
        {
            return Content("FromUri OK");
        }

        public ActionResult EditFromMapRoute(int? promoId)
        {
            return Content("EditFromMapRoute OK");
        }
    }
}