using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;
namespace KidKinder.Controllers
{
    public class AdminTestimonialController : Controller
    {
        KidKinderContext contex = new KidKinderContext();
        public ActionResult Index()
        {
            var value = contex.Testimonials.ToList();
            return View(value);
        }
        [HttpGet] 
        public ActionResult CreateTestimonial()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial p)
        {
            contex.Testimonials.Add(p);
            contex.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = contex.Testimonials.Find(id);
            contex.Testimonials.Remove(values);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = contex.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial p)
        {
            var values = contex.Testimonials.Find(p.TestimonialId);
            values.NameSurname = p.NameSurname;
            values.Title = p.Title;
            values.Comment = p.Comment;
            values.ImageUrl = p.ImageUrl;
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}