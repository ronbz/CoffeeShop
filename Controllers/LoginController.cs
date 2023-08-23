using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coffeeshop.Models;
using coffeeshop.Dal;
using System.Web.Security;

namespace coffeeshop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Authenticate(User usr)
        {
            rdaDal dal = new rdaDal();
            if (ModelState.IsValid)
            {
                List<User> userValidated = (from u in dal.Users
                                            where (u.UserName == usr.UserName) && (u.Password == usr.Password)
                                            select u).ToList<User>();
                if (userValidated.Count == 1 && usr.UserName == "admin")
                {
                    FormsAuthentication.SetAuthCookie("cookie", true);
                    return RedirectToRoute(new { Controller = "Admin", action = "Index" });
                }
                else if (userValidated.Count == 1 && usr.UserName == "barista")
                {
                    FormsAuthentication.SetAuthCookie("cookie", true);
                    return RedirectToRoute(new { Controller = "Barista", action = "Index" });
                }
                else
                {
                    
                    return View("Login", usr);
                }
            }
            else
            {
                return View("Login", usr);
            }
        }
    }
}