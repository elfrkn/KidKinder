using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TestimonialController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult TestimonialList()
        {
            var values = c.Testimonials.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            c.Testimonials.Remove(c.Testimonials.Find(id));
            c.SaveChanges();
            return RedirectToAction("TestimonialList");

        }

        [HttpGet]
        public ActionResult EditTestimonial(int id)
        {
            var values = c.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditTestimonial(Testimonial p)
        {
            var value = c.Testimonials.Find(p.TestimonialId);
            value.Title = p.Title;
            value.ImageUrl = p.ImageUrl;
            value.NameSurname = p.NameSurname;
            value.Title = p.Title;
            value.Comment = p.Comment;
            c.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


    }
}