using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ServiceController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult ServiceList()
        {
            var values = c.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(Service p)
        {
            c.Services.Add(p);
            c.SaveChanges();
            return RedirectToAction("ServiceList");
        }


        public ActionResult DeleteService(int id)
        {
            c.Services.Remove(c.Services.Find(id));
            c.SaveChanges();
            return RedirectToAction("ServiceList");

        }

        [HttpGet]
        public ActionResult EditService(int id)
        {
            var values = c.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditService(Service p)
        {
            var value = c.Services.Find(p.ServiceId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.IconUrl = p.IconUrl;
            c.SaveChanges();
            return RedirectToAction("ServiceList");
        }

    }
}