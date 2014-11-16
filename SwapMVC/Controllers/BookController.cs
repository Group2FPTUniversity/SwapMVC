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
    public class BookController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /Book/
        public ActionResult MyBook(int id)
        {
            //var book = db.Book.Include(b => b.Account).Include(b => b.Category);
            //return View(book.ToList());
            var list = db.Book.Where(book => book.AccID== id).ToList();
            return View(list);
        }

        public ActionResult Index()
        {
            var book = db.Book.Include(b => b.Account).Include(b => b.Category);
            List<Book> list = book.ToList().OrderBy(o=>o.PostDate).Take(5).ToList();
            return View(list);
        }

        //
        // GET: /Book/Details/5

        public ActionResult Details(int id = 0)
        {
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // GET: /Book/Create

        public ActionResult Create()
        {
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email");
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name");
            return View();
        }

        //
        // POST: /Book/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book, HttpPostedFileBase file)
        {
            if (file != null)
            {
                file.SaveAs(HttpContext.Server.MapPath("~/UserImg/Book/") + file.FileName);

                book.BookImage = "~/UserImg/Book/" + file.FileName;

            }
            if (ModelState.IsValid)
            {
                db.Book.Add(book);
                db.SaveChanges();
                return RedirectToAction("MyBook/" + book.AccID.ToString());
            }

            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", book.AccID);
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name", book.CategoryID);
            return View(book);
        }

        //
        // GET: /Book/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", book.AccID);
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name", book.CategoryID);
            return View(book);
        }

        //
        // POST: /Book/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccID = new SelectList(db.Account, "ID", "Email", book.AccID);
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name", book.CategoryID);
            return View(book);
        }

        //
        // GET: /Book/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // POST: /Book/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Book.Find(id);
            db.Book.Remove(book);
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