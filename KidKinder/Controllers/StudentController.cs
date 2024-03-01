using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class StudentController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult StudentList()
        {
            var values = c.Students.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            List<SelectListItem> values = (from x in c.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ClassRoomId.ToString()

                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student p)
        {
            c.Students.Add(p);
            c.SaveChanges();
            return RedirectToAction("StudentList");
        }

        public ActionResult DeleteStudent(int id)
        {
            c.Students.Remove(c.Students.Find(id));
            c.SaveChanges();
            return RedirectToAction("StudentList");


        }

        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            List<SelectListItem> values = (from x in c.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ClassRoomId.ToString()

                                           }).ToList();
            ViewBag.v = values;
            var value = c.Students.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditStudent(Student p)
        {
            var value = c.Students.Find(p.StudentId);
            value.StudentId = p.StudentId;
            value.StudentNameSurname = p.StudentNameSurname;
            value.Age = p.Age;
            value.ClassRoomId = p.ClassRoomId;
            c.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}