using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ContactController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult ContactAddressPartial()
        {
            ViewBag.description = c.Communications.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = c.Communications.Select(x => x.Phone).FirstOrDefault();
            ViewBag.address = c.Communications.Select(x => x.Address).FirstOrDefault();
            ViewBag.email = c.Communications.Select(x => x.Email).FirstOrDefault();
            return PartialView();
        }
    }
}