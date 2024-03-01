using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller

    {
        KidKinderContext c = new KidKinderContext();
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
      
      public ActionResult AdminLogin(Admin admin)
        {
            var result = c.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.Username, true);
                Session["username"] = result.Username;
                return RedirectToAction("TeacherList", "Teacher");
            }
            return View();
        }

        public ActionResult AdminLogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("AdminLogin");
        }

    }
}