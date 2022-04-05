using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Restuarant_Managment_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View("Login");
        }
        public ActionResult Logout()
        {
            return View("Login");
        }

        [Authorize]

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult CheckUser()
        {
            if ((Request.Form["txtId"] == "38862") && (Request.Form["txtPassword"] == "2580"))
            {
                FormsAuthentication.SetAuthCookie(Request.Form["txtId"], true);
                return View("Index");
            }
            else
            {
                return View("Login");
            }

           
        }
    }
}