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
    public class TransactionController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /Transaction/

        public ActionResult Index()
        {
            var swaptransaction = db.SwapTransaction.Include(s => s.Book).Include(s => s.SwapItem);
            return View(swaptransaction.ToList());
        }

        //
        // GET: /Transaction/Details/5

        public ActionResult Details(int id = 0)
        {
            SwapTransaction swaptransaction = db.SwapTransaction.Find(id);
            if (swaptransaction == null)
            {
                return HttpNotFound();
            }
            return View(swaptransaction);
        }

        //
        // GET: /Transaction/Create

        public ActionResult Create()
        {
            return Redirect("~/Home/Home");
        }

        //
        // POST: /Transaction/Create

        [HttpGet]
        public ActionResult Create(string itemID, string bookID)
        {
            try
            {
                SwapTransaction trans = new SwapTransaction();
                trans.BookID = int.Parse(bookID);
                trans.SwapItemID = int.Parse(itemID);
                trans.SwapDate = DateTime.Now;

                db.SwapTransaction.Add(trans);

                var swapItem = db.SwapItem.Find(int.Parse(itemID));
                swapItem.ItemStatus = "Đã xác nhận đổi";
                swapItem.Book.BookStatus = "Đã xác nhận đổi";
                foreach (var item in swapItem.Book.SwapItem.Where(i => i.ID!=swapItem.ID).ToList())
                {
                    item.ItemStatus = "Đã từ chối";
                }

                db.SaveChanges();
                
            }
            catch (Exception e)
            {
                return Redirect("~/Book/Details/" + bookID);
            }


            return Redirect("~/Book/Details/" + bookID);
        }

        //
        // GET: /Transaction/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SwapTransaction swaptransaction = db.SwapTransaction.Find(id);
            if (swaptransaction == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title", swaptransaction.BookID);
            ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType", swaptransaction.SwapItemID);
            return View(swaptransaction);
        }

        //
        // POST: /Transaction/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SwapTransaction swaptransaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(swaptransaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookID = new SelectList(db.Book, "ID", "Title", swaptransaction.BookID);
            ViewBag.SwapItemID = new SelectList(db.SwapItem, "ID", "ItemType", swaptransaction.SwapItemID);
            return View(swaptransaction);
        }

        //
        // GET: /Transaction/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SwapTransaction swaptransaction = db.SwapTransaction.Find(id);
            if (swaptransaction == null)
            {
                return HttpNotFound();
            }
            return View(swaptransaction);
        }

        //
        // POST: /Transaction/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SwapTransaction swaptransaction = db.SwapTransaction.Find(id);
            db.SwapTransaction.Remove(swaptransaction);
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