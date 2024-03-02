using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;
namespace KidKinder.Controllers
{
    public class AdminContactController : Controller
    {
        KidKinderContext context = new KidKinderContext(); 
        public ActionResult Index() 
        {
            var values = context.Contacts.Where(x => x.IsRead == false).Take(5).ToList();
            ViewBag.ısread= context.Contacts.Where(x => x.IsRead == false).Count();
      ;
            return View(values);
    
        }
        public ActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailMessage(int id)
        {
            var value = context.Contacts.Find(id); 
             
            return View(value);

        }
       

    }
}