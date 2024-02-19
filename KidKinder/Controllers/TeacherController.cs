using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TeacherController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult TeacherList()
        {
            var values = c.Teachers.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTeacher(Teacher p)
        {
            c.Teachers.Add(p);
            c.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        public ActionResult DeleteTeacher(int id)
        {
            c.Teachers.Remove(c.Teachers.Find(id));
            c.SaveChanges();
            return RedirectToAction("TeacherList");


        }
        [HttpGet]
        public ActionResult EditTeacher(int id)
        {
            var values = c.Teachers.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditTeacher(Teacher p)
        {
            var value = c.Teachers.Find(p.TeacherId);
            value.Title = p.Title;
            value.NameSurname = p.NameSurname;
            value.ImageUrl = p.ImageUrl;
            c.SaveChanges();
            return RedirectToAction("TeacherList");
        }
    }
  
}