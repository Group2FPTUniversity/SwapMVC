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
    public class NotifyController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /Notify/

        public ActionResult Index()
        {
            return View(db.Notify.ToList());
        }

        //
        // GET: /Notify/Details/5

        public ActionResult Details(int id = 0)
        {
            Notify notify = db.Notify.Find(id);
            if (notify == null)
            {
                return HttpNotFound();
            }
            return View(notify);
        }

        public ActionResult Notify()
        {
            if (Session["LogedUserID"]!=null)
            {
                String accID = Session["LogedUserID"].ToString();
                var list = db.Notify.Where(noti => noti.AccID == int.Parse(accID)).ToList();
                return View(list);
            }
            return View();
           
        }

        //
        // GET: /Notify/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Notify/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Notify notify)
        {
            if (ModelState.IsValid)
            {
                db.Notify.Add(notify);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notify);
        }

        //
        // GET: /Notify/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Notify notify = db.Notify.Find(id);
            if (notify == null)
            {
                return HttpNotFound();
            }
            return View(notify);
        }

        //
        // POST: /Notify/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Notify notify)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notify).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notify);
        }

        //
        // GET: /Notify/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Notify notify = db.Notify.Find(id);
            if (notify == null)
            {
                return HttpNotFound();
            }
            return View(notify);
        }

        //
        // POST: /Notify/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notify notify = db.Notify.Find(id);
            db.Notify.Remove(notify);
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