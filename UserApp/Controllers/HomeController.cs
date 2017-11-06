using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["name"] == null)
            {
                return View(false);
            }
            return View(true);
        }

        public ActionResult Login()
        {
            if (Session["name"] == null)
            {
                return View(false);
            }
            return View(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserApp.Models.User user)
        {
            if (Session["name"] == null)
            {
                return View(false);
            }
            return View(true);
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
    }
}