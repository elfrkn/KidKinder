using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult ClassList()
        {
            var values = c.ClassRooms.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditClass(int id)
        {
            var values = c.ClassRooms.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditClass(ClassRoom p)
        {
            var value = c.ClassRooms.Find(p.ClassRoomId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.AgeofKids = p.AgeofKids;
            value.TotalSeats = p.TotalSeats;
            value.ClassTime = p.ClassTime;
            value.Price = p.Price;
            value.ImageUrl = p.ImageUrl;
            c.SaveChanges();
            return RedirectToAction("ClassList");
        }


    }
}