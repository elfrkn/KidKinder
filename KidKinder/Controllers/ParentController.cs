using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ParentController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult ParentList()
        {
            var values = c.Parents.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddParent()
        {
            List<SelectListItem> values = (from x in c.Students.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.StudentNameSurname,
                                               Value = x.StudentId.ToString()

                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddParent(Parent p)
        {
            c.Parents.Add(p);
            c.SaveChanges();
            return RedirectToAction("ParentList");
        }

        public ActionResult DeleteParent(int id)
        {
            c.Parents.Remove(c.Parents.Find(id));
            c.SaveChanges();
            return RedirectToAction("ParentList");


        }

        [HttpGet]
        public ActionResult EditParent(int id)
        {
            List<SelectListItem> values = (from x in c.Students.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.StudentNameSurname,
                                               Value = x.StudentId.ToString()

                                           }).ToList();
            ViewBag.v = values;
            var value = c.Parents.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditParent(Parent p)
        {
            var value = c.Parents.Find(p.ParentId);
            value.ParentId = p.ParentId;
            value.ParentNameSurname = p.ParentNameSurname;
            value.Phone = p.Phone;
            value.StudentId = p.StudentId;
            c.SaveChanges();
            return RedirectToAction("ParentList");
        }
    }
}