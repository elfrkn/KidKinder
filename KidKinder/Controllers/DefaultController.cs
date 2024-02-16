﻿using System;
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
        [HttpGet]

        public PartialViewResult PartialBookASeat()
        {
            //List<SelectListItem> values = (from x in c.ClassRooms.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = x.Title,
            //                                   Value = x.ClassRoomId.ToString()
            //                               }).ToList();


            //ViewBag.v = values;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialBookASeat(BookASeat p)
        {
            c.BookASeats.Add(p);
            c.SaveChanges();
            return PartialView();

           
        }

        public PartialViewResult PartialTeacher()
        {
            var degerler = c.Teachers.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialTestimonial()
        {
            var degerler = c.Testimonials.ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialFooter(MailSubscribe p)
        {
            c.MailSubscribes.Add(p);
            c.SaveChanges();
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