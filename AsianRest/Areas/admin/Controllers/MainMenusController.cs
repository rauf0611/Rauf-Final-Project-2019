using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsianRest.Models;

namespace AsianRest.Areas.admin.Controllers
{
    [AuthorizationFilter]
    public class MainMenusController : Controller
    {
        private AsianRestEntities db = new AsianRestEntities();

        // GET: admin/MainMenus
        public ActionResult Index()
        {
            return View(db.MainMenus.ToList());
        }

        // GET: admin/MainMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainMenu mainMenu = db.MainMenus.Find(id);
            if (mainMenu == null)
            {
                return HttpNotFound();
            }
            return View(mainMenu);
        }

        // GET: admin/MainMenus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/MainMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MealName,Price,Info")] MainMenu mainMenu)
        {
            if (ModelState.IsValid)
            {
                db.MainMenus.Add(mainMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainMenu);
        }

        // GET: admin/MainMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainMenu mainMenu = db.MainMenus.Find(id);
            if (mainMenu == null)
            {
                return HttpNotFound();
            }
            return View(mainMenu);
        }

        // POST: admin/MainMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MealName,Price,Info")] MainMenu mainMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mainMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainMenu);
        }

        // GET: admin/MainMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainMenu mainMenu = db.MainMenus.Find(id);
            if (mainMenu == null)
            {
                return HttpNotFound();
            }
            return View(mainMenu);
        }

        // POST: admin/MainMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MainMenu mainMenu = db.MainMenus.Find(id);
            db.MainMenus.Remove(mainMenu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
