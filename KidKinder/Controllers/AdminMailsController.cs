using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminMailsController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.MailSubscribes.ToList();
            return View(values);
        }   
        public ActionResult DeleteMail(int id)
        {
            var values = context.MailSubscribes.Find(id); 
            context.MailSubscribes.Remove(values); 
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}