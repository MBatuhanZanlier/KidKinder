using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class AdminClassromController : Controller
    {
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.ClassRooms.ToList(); 
            return View(values);
        }
    }
}