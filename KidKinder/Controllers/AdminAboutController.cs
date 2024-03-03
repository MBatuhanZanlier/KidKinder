using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminAboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateAbout(About p)
        {
            context.Abouts.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteAbout(int id)
        {
            var values = context.Abouts.Find(id);
            context.Abouts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult UpdateAboutList(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateAboutList(About p)
        {
            var values = context.Abouts.Find(p.AboutId);
            values.Title = p.Title; 
            values.Header = p.Header; 
            values.AboutBigImageUrl = p.AboutBigImageUrl;
            values.SmallImageUrl = p.SmallImageUrl;
            values.Description = p.Description;
            context.SaveChanges();
            return View(values);

        }
    }
}