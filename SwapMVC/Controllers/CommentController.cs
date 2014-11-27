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
    public class CommentController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /Comment/

        public ActionResult Index()
        {
            var comment = db.Comment.Include(c => c.Account).Include(c => c.SwapItem);
            return View(comment.ToList());
        }

        //
        // GET: /Comment/Details/5

        public ActionResult Details(int id = 0)
        {
            Comment comment = db.Comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // GET: /Comment/Create

        public ActionResult Create()
        {
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email");
            ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType");
            return PartialView();
        }

        //
        // POST: /Comment/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                Notify noti = new Notify();
                SwapItem swapItem = db.SwapItem.Find(comment.SwapItemID);
                noti.SubAcc = swapItem.AccID;
                noti.BookID = swapItem.BookID;
                noti.Date = DateTime.Now;

                Book book = db.Book.Find(noti.BookID);
                noti.AccID = book.AccID;
                noti.Status = "Comment";
                db.Notify.Add(noti);
                db.Comment.Add(comment);
                db.SaveChanges();
                ViewBag.AccID = new SelectList(db.Account, "ID", "Email", comment.AccID);
                ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType", comment.SwapItemID);
                return Json("true");
            }
            else
            {
                return Json("false");
            }
        }

        //
        // GET: /Comment/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Comment comment = db.Comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", comment.AccID);
            ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType", comment.SwapItemID);
            return View(comment);
        }

        //
        // POST: /Comment/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", comment.AccID);
            ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType", comment.SwapItemID);
            return View(comment);
        }

        //
        // GET: /Comment/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Comment comment = db.Comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Comment/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comment.Find(id);
            db.Comment.Remove(comment);
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