using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SwapMVC.Models;

namespace SwapMVC.Controllers
{
    public class HomeController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();
        public ActionResult Portal()
        {
            ViewBag.Message = "Portal.";

            return View();
        }
        public ActionResult Home()
        {
            return View();

        }
        public ActionResult RecentBook(int page)
        {
            ViewBag.Message = "Home.";
            int skippedPage = (page - 1) * 10;
            var book = db.Book.Include(b => b.Account).Include(b => b.Category);
            List<Book> list = book.ToList().OrderBy(o => o.PostDate).Skip(skippedPage).Take(10).ToList();
            return View(list);
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
