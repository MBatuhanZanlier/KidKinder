﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
using System.Web.UI.WebControls;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        
        public ActionResult Index()
        {
            return View();
        } 

       
        public PartialViewResult PartialFuture()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAboutList()
        {
            var values = context.AboutLists.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values = context.ClassRooms.OrderByDescending(x => x.ClassRoomId).Take(3).ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialBookASeat()
        {
            List<SelectListItem> values = (from x in context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.BranchID.ToString()

                                           }).ToList();
            ViewBag.clss = values;
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddBookAseat(BookASeat p)
        {
            context.BookASeats.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialTeacher()
        {
            var values = context.Teachers.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
       
    }
}