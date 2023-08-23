using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coffeeshop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are the best coffee shop in Israel!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please help us help you :).";

            return View();
        }
    }
}