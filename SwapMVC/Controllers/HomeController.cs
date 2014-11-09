using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwapMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Portal()
        {
            ViewBag.Message = "Portal.";

            return View();
        }
        public ActionResult Home()
        {
            ViewBag.Message = "Home.";

            return View();
        }

        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
