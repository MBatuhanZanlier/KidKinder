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
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateClassroom()
        {
            List<SelectListItem> values = (from x in context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.BranchID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        public ActionResult CreateClassroom(ClassRoom p)
        {
            context.ClassRooms.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        } 
        public ActionResult DeleteClassroom(int id) 
        {
            var values = context.ClassRooms.Find(id); 
            context.ClassRooms.Remove(values); 
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet] 
        public ActionResult UpdateClassroom(int id)
        {
            List<SelectListItem> values = (from x in context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.BranchID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var values2=context.ClassRooms.Find(id); 
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateClassroom(ClassRoom p)
        {
            var values = context.ClassRooms.Find(p.ClassRoomId); 
            values.Title = p.Title; 
            values.Description = p.Description; 
            values.TotalSeat = p.TotalSeat; 
            values.AgeOfKids = p.AgeOfKids;
            values.ClassTime = p.ClassTime; 
            values.Price = p.Price; 
            values.ImageUrl = p.ImageUrl; 
            values.BranchID = p.BranchID;
            context.SaveChanges();

            return RedirectToAction("Index"); 
        }
    }
}