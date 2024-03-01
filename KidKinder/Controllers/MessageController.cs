using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class MessageController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult MessageList()
        {
            var values = c.Contacts.ToList();
            return View(values);
        }

       
        public ActionResult DeleteMessage(int id)
        {
            var values = c.Contacts.Find(id);
            values.IsRead = true;
            c.SaveChanges();
            return RedirectToAction("MessageList");


        }

    }
}