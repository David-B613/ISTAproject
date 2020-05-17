using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Sofia.Models;



namespace Sofia.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (DBC db = new DBC())
            {
                return View(db.userAccount.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (DBC db = new DBC())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered. You can now loggin with your User Name and Password.";
               
            }
            return View();
        }
        //Login 
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (DBC db = new DBC())
            {
                var usr = db.userAccount.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
           if(Session["UserId"] != null)
            {
                return View();
            }
           else
            {
                return RedirectToAction("login");
            }
        }
    }
}