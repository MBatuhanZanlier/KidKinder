using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminFutureController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Features.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFuture()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFuture(Feature p)
        {
            context.Features.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFuture(int id)
        {
            var values = context.Features.Find(id);
            context.Features.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateFuture(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateFuture(Feature p)
        {
            var values = context.Features.Find(p.FeatureId);
            values.Title = p.Title;
            values.Description = p.Description;
            values.Header = p.Header;
            values.ImageUrl = p.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}