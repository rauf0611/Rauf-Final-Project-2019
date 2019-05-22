using AsianRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace AsianRest.Controllers
{
    public class HomeController : Controller
    {
        AsianRestEntities db = new AsianRestEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult OurChefs()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }

        public ActionResult Reservation()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult ShopNow()
        {
            return View();
        }

        //Qalib
        public ActionResult ShopSingle(int? id)
        {
            if(id != null)
            {
               var menu= db.MainMenus.FirstOrDefault(x=>x.ID==id);
                if (menu != null)
                {
                    return View(menu);
                }
            }
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult addToCard(int? id)
        {
            if (id != null)
            {
                var menu = db.MainMenus.FirstOrDefault(x => x.ID == id);
                if (menu != null)
                {
                    if (Session["order"] == null)
                    {
                        List<MainMenu> Orders = new List<MainMenu>();
                        Orders.Add(menu);
                        Session["order"] = Orders;
                    }
                    else
                    {
                        List<MainMenu> Orders= Session["order"] as List<MainMenu>;
                        Orders.Add(menu);
                    }
                    return new RedirectResult("/home/shopsingle/" + id);
                }
            }
            return new RedirectResult("/home/shopsingle/" +id);
        }
        
         public ActionResult removeCard(int? id)
        {
            List<MainMenu> Orders = Session["order"] as List<MainMenu>;
            var removeItem = Orders.FirstOrDefault(x => x.ID == id);
            Orders.Remove(removeItem);
            return new RedirectResult("/home/Basket");
        }
        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (System.Web.Helpers.Crypto.VerifyHashedPassword(user.UserPassword, password))
                {
                    Session["UserLog"] = user;
                    TempData["logSuccess"] = true;
                    return new RedirectResult("/");
                }
                else
                {
                    TempData["logError"] = "Email or Password is not Valid";
                }
            }
            else
            {
                TempData["logError"] = "Email or Password is not Valid";
            }
            return new RedirectResult("/home/login");
        }

        //Qalib
        public ActionResult Logout()
        {
            Session["UserLog"] = null;
            return new RedirectResult("/");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User Newuser ,string conUserPassword)
        {
            Regex re = new Regex(@"\w.\w@{1,1}\w[.\w]?.\w");
            if (Newuser.FullName.Length>2 && Newuser.FullName.Length<30 && re.IsMatch(Newuser.Email)==true && Newuser.UserPassword.Length >3)
            {
                var CheckEmail = db.Users.FirstOrDefault(x => x.Email == Newuser.Email);
                if (CheckEmail == null)
                {
                    if (Newuser.UserPassword == conUserPassword)
                    {
                        Newuser.Email = Newuser.Email.ToLower();
                        Newuser.UserPassword = System.Web.Helpers.Crypto.HashPassword(Newuser.UserPassword);
                        db.Users.Add(Newuser);
                        db.SaveChanges();
                        TempData["success"] = true;
                        return new RedirectResult("/home/login");
                    }
                    else
                    {
                        TempData["validationError"] = "Password and Confirm Pasword does not match";
                    }
                }
                else
                {
                    TempData["validationError"] = "Dublicate Email. Please Try another Email Adress";
                }
            }
            else
            {
                TempData["validationError"] = "Please make sure u fill all columns perfectly!";
            }
            return new RedirectResult("/home/register");
        }

        //Qalib
        public ActionResult Basket()
        {
            return View();
        }
    }
}