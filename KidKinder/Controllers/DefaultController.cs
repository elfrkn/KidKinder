using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {

        KidKinderContext c = new KidKinderContext();
        
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = c.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = c.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
           
           var degerler = c.Abouts.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values = c.ClassRooms.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookASeat()
        {
            return PartialView();
        }
        public PartialViewResult PartialTeacher()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialAboutList()
        {

            var degerler = c.AboutLists.ToList();
            return PartialView(degerler);
        }

        
    }
}