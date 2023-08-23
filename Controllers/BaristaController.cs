using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coffeeshop.Controllers
{
    [Authorize]
    public class BaristaController : Controller
    {
        // GET: Barista
        public ActionResult Index()
        {
            return View("Barista");
        }
    }
}