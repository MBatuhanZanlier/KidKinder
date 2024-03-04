using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminGalleriController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Galleries.ToList();
            return View(values);
        }
        [HttpGet] 
        public ActionResult CreateGalleri()  
        { 
            return View();
        
        } 
        [HttpPost]
        public ActionResult CreateGalleri(Gallery p)
        {
            p.Status = true; 
            context.Galleries.Add(p); 
            context.SaveChanges();
            return View();

        }  
        public ActionResult StatusAktif(int id)
        {
            var values = context.Galleries.Find(id); 
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index"); 
        }
        public ActionResult StatusPasif(int id)
        {
            var values = context.Galleries.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGalleri(int id)
        {
            var values = context.Galleries.Find(id);
            context.Galleries.Remove(values); 
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}