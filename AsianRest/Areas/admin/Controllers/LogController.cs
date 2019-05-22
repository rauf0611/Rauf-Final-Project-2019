using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsianRest.Models;

namespace AsianRest.Areas.admin.Controllers
{
    public class LogController : Controller
    {
        AsianRestEntities db = new AsianRestEntities();
        // GET: admin/Log
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name, string password)
        {
            var admin = db.AdminLogs.Find(1);
            if (name == admin.name && System.Web.Helpers.Crypto.VerifyHashedPassword(admin.password, password))
            {
                Session["adminLogged"] = true;
                return new RedirectResult("/admin");
            }
            else
            {
                TempData["adminLogError"] = true;
            }
            return new RedirectResult("/admin/log");
        }
        public ActionResult LogOut()
        {
            Session["adminLogged"] = null;
            return new RedirectResult("/admin/log");
        }
    }
}