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
    public class SwapItemController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /SwapItem/

        public ActionResult Index()
        {
            var swapitem = db.SwapItem.Include(s => s.Account).Include(s => s.Book);
            return View(swapitem.ToList());
        }

        //
        // GET: /SwapItem/Details/5

        public ActionResult Details(int id = 0)
        {
            SwapItem swapitem = db.SwapItem.Find(id);
            if (swapitem == null)
            {
                return HttpNotFound();
            }
            return View(swapitem);
        }

        //
        // GET: /SwapItem/Create

        public ActionResult Create()
        {
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email");
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title");
            return View();
        }

        //
        // POST: /SwapItem/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SwapItem swapitem)
        {
            if (ModelState.IsValid)
            {
                db.SwapItem.Add(swapitem);
                db.SaveChanges();
                return RedirectToAction("Details/" + swapitem.BookID, "Book");
            }

            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", swapitem.AccID);
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title", swapitem.BookID);
            return View(swapitem);
        }

        //
        // GET: /SwapItem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SwapItem swapitem = db.SwapItem.Find(id);
            if (swapitem == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", swapitem.AccID);
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title", swapitem.BookID);
            return View(swapitem);
        }

        //
        // POST: /SwapItem/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SwapItem swapitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(swapitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", swapitem.AccID);
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title", swapitem.BookID);
            return View(swapitem);
        }

        //
        // GET: /SwapItem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SwapItem swapitem = db.SwapItem.Find(id);
            if (swapitem == null)
            {
                return HttpNotFound();
            }
            return View(swapitem);
        }

        //
        // POST: /SwapItem/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SwapItem swapitem = db.SwapItem.Find(id);
            db.SwapItem.Remove(swapitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}