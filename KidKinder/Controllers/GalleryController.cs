using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GalleryController : Controller


    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult Index()
        {
            var values = c.Galleries.Where(x => x.Status == true).ToList();
            return View(values);
        }

        public ActionResult AdminGalleryList()
        {

            var values = c.Galleries.ToList();
            return View(values);
        }

        public ActionResult AdminGalleryDelete(int id)
        {
            var values = c.Galleries.Find(id);
            values.Status = false;
            c.SaveChanges();
            return RedirectToAction("AdminGalleryList");

        }
    }
}