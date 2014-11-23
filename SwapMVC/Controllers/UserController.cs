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
    public class UserController : Controller
    {
        private SwapDBEntities db = new SwapDBEntities();

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(db.Account.ToList());
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Account u)
        {

         
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {

                var v = db.Account.Where(a => a.Email.Equals(u.Email) && a.Passwd.Equals(u.Passwd)).FirstOrDefault();
                    if (v != null)
                    {
                      
                        Session["LogedUserID"] = v.ID.ToString();
                        Session["LogedUserFullname"] = v.Fullname.ToString();
                        return Redirect("~/Home/Home");
                    }
                    else
                    {
                        return Redirect("~/Home/");
                    }
                }

            return Redirect("~/Home/");
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

      
        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            if (Session["LogedUserFullname"] == null)
            {
                return Redirect("~/Home");
            }
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Account account, HttpPostedFileBase file)
        {
            if (file != null)
            {
                file.SaveAs(HttpContext.Server.MapPath("~/UserImg/User/") + file.FileName);

                account.Avatar = "~/UserImg/User/"  + file.FileName;

            }
            if (ModelState.IsValid)
            {
                db.Account.Add(account);
                db.SaveChanges();

                return Login(account);
            }

            return View(account);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Account account)
        {
            if (Session["LogedUserFullname"] == null)
            {
                return Redirect("~/Home");
            }
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            if (Session["LogedUserFullname"] == null)
            {
                return Redirect("~/Home");
            }
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account account = db.Account.Find(id);
            db.Account.Remove(account);
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