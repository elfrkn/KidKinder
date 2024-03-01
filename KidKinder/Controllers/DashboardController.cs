using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KidKinder.Controllers
{
  
    public class DashboardController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        
        public ActionResult Index()
        {
            //Bransi ingilizce olan ogretmen sayisi
            ViewBag.ingilizce = c.Teachers.Where(x => x.BranchId == c.Branches.Where(z => z.BranchName == "İngilizce").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.AvgPrice = c.ClassRooms.Average(x => x.Price).ToString("0.00");
            ViewBag.Comment = c.Testimonials.Count().ToString();
            ViewBag.picture = c.Galleries.Count().ToString();
            ViewBag.branch = c.Branches.Count().ToString();
            ViewBag.service = c.Services.Count().ToString();
            ViewBag.message = c.Contacts.Count().ToString();
            ViewBag.student = c.Students.Count().ToString();
            ViewBag.subscribes = c.MailSubscribes.Count().ToString();
            ViewBag.teacher = c.Teachers.Count().ToString();
            ViewBag.char1 = c.BookASeats.Where(x => x.ClassRoomId == 1).Count().ToString();
            ViewBag.char2 = c.BookASeats.Where(x => x.ClassRoomId == 2).Count().ToString();
            ViewBag.char3 = c.BookASeats.Where(x => x.ClassRoomId == 3).Count().ToString();
            ViewBag.char4 = c.BookASeats.Where(x => x.ClassRoomId == 4).Count().ToString();

            var values = c.Testimonials.Take(4).ToList();
            return View(values); ;
        }
    }
} 