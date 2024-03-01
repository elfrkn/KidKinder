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
            ViewBag.description = c.Addresses.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = c.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.address = c.Addresses.Select(x => x.AddressDetail).FirstOrDefault();
            ViewBag.email = c.Addresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.hours = c.Addresses.Select(x => x.OpeningHours).FirstOrDefault();
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult ContactMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactMessage(Contact p)
        {
            var value = c.Contacts.Add(p);
            value.SendDate = DateTime.Now;
            value.IsRead = false;
            c.SaveChanges();
            return RedirectToAction("Index","Default");
        }
    }
}