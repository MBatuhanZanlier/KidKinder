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
    public class AdminComunicationController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
          var values=context.Communications.ToList(); 
            return View(values);
        }
        [HttpGet] 
        public ActionResult CreateComunication() 
        { 
           return View();
        }
        [HttpPost]
        public ActionResult CreateComunication(Communication p)
        {   
            context.Communications.Add(p); 
            context.SaveChanges();
            return RedirectToAction("Index");
        } 
        public ActionResult DeleteComunication(int id=1)  
        {
            var values = context.Communications.Find(id); 
            context.Communications.Remove(values); 
            context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        [HttpGet] 
        public ActionResult UpdateComunication(int id=1) 
        { 
            var values=context.Communications.Find(id); 
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateComunication(Communication p)
        {
            var values = context.Communications.Find(p.CommunicationId);
            values.Description = p.Description; 
            values.Address = p.Address; 
            values.Email = p.Email; 
            values.Phone = p.Phone;
            context.SaveChanges(); 
            return RedirectToAction("Index");   
        }
    }
}