using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;
namespace KidKinder.Controllers
{
    public class AdminBookASeatController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.BookASeats.ToList(); 
            return View(values);
        }  
        public ActionResult DeleteBookASeat(int id) 
        {
            var values = context.BookASeats.Find(id);
            context.BookASeats.Remove(values); 
            return RedirectToAction("Index");
        
        }
    }
}