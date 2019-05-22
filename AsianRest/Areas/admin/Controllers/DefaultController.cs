using AsianRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsianRest.Areas.admin.Controllers
{
    [AuthorizationFilter]
    public class DefaultController : Controller
    {
        // GET: admin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}