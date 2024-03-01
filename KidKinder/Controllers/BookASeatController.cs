using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class BookASeatController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult BookaSeatList() 
        {
            var values = c.BookASeats.ToList();
            return View(values);
        }
    }
}