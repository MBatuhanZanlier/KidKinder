using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminNoticationController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Notifications.ToList();
            return View(values);
        }
        public ActionResult DeleteNotification(int id)
        {
            var values = context.Notifications.Find(id);
            context.Notifications.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}