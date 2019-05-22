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
    public class WorkHoursController : Controller
    {
        private AsianRestEntities db = new AsianRestEntities();

        // GET: admin/WorkHours
        public ActionResult Index()
        {
            return View(db.WorkHours.ToList());
        }

        // GET: admin/WorkHours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkHour workHour = db.WorkHours.Find(id);
            if (workHour == null)
            {
                return HttpNotFound();
            }
            return View(workHour);
        }


        // GET: admin/WorkHours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkHour workHour = db.WorkHours.Find(id);
            if (workHour == null)
            {
                return HttpNotFound();
            }
            return View(workHour);
        }

        // POST: admin/WorkHours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,WorkHour1")] WorkHour workHour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workHour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workHour);
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
