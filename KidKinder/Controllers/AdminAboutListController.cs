using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminAboutListController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.AboutLists.ToList();
            return View(values);
        }
        [HttpGet] 
        public ActionResult CreateAboutList() 
        {
            return View();
        
        }
        [HttpPost]
        public ActionResult CreateAboutList(AboutList p)
        {  
            context.AboutLists.Add(p); 
            context.SaveChanges();
            return RedirectToAction("Index");

        } 
        public ActionResult DeleteAboutList(int id) 
        { 
            var values=context.AboutLists.Find(id); 
            context.AboutLists.Remove(values); 
            context.SaveChanges(); 
            return RedirectToAction("Index");
        
        
        }
        [HttpGet] 
        public ActionResult UpdateAboutList(int id)
        {
            var values = context.AboutLists.Find(id);    
            return View(values); 
        
        }
        [HttpPost]
        public ActionResult UpdateAboutList(AboutList p)
        {
            var values = context.AboutLists.Find(p.AboutListId); 
            values.Description = p.Description;
            context.SaveChanges();
            return View(values);

        }
    }
}