using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coffeeshop.Dal;
using coffeeshop.Models;
using coffeeshop.ModelView;

namespace coffeeshop.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            rdaDal dal = new rdaDal();
            List<Item> objItems = dal.Items.ToList<Item>();
            List<Vip> objVips = dal.Vips.ToList<Vip>();
            MenuViewModel mvm = new MenuViewModel();
            mvm.item = new Item();
            mvm.items = objItems;
            mvm.vip = new Vip();
            mvm.vips = objVips;
            return View(mvm);
        }

        public ActionResult GetItemsByJson() 
        {
            rdaDal dal = new rdaDal();
            List<Item> objItems = dal.Items.ToList<Item>();
            return Json(objItems,JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetVipsByJson()
        {
            rdaDal dal = new rdaDal();
            List<Vip> objVips = dal.Vips.ToList<Vip>();
            return Json(objVips, JsonRequestBehavior.AllowGet);
        }
    }
}