using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {

            //ViewBag.ResimCizmeCount=context.Teachers.Where(x => x.BranchID== context.branches).Where(z => z.Name == "Resim Çizim").Select
            //ViewBag.AvrPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");

            return View();
        }
    }
}