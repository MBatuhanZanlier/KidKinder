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
            ViewBag.MatCount = context.Students.Where(x => x.BranchID == context.Branches.Where(y => y.Name == "Matematik").Select(z => z.BranchID).FirstOrDefault()).Count();
            ViewBag.TurkceCount = context.Students.Where(x => x.BranchID == context.Branches.Where(y => y.Name == "Türkçe").Select(z => z.BranchID).FirstOrDefault()).Count();
            ViewBag.AlmancaCount = context.Students.Where(x => x.BranchID == context.Branches.Where(y => y.Name == "Almanca").Select(z => z.BranchID).FirstOrDefault()).Count();
            ViewBag.ResımCount = context.Students.Where(x => x.BranchID == context.Branches.Where(y => y.Name == "Görsel Sanatlar").Select(z => z.BranchID).FirstOrDefault()).Count();
            //ViewBag.ResimCizmeCount=context.Teachers.Where(x => x.BranchID== context.branches).Where(z => z.Name == "Resim Çizim").Select
            ViewBag.AvrPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");
            ViewBag.kayıt = context.BookASeats.Count();
            ViewBag.student = context.Students.Count();
            ViewBag.teacher = context.Teachers.Count();
            ViewBag.message = context.Contacts.Count();
            ViewBag.testim = context.Testimonials.Count(); 
            var values= context.Teachers.ToList();
            return View(values);
        }
    }
}