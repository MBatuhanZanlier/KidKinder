using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AdminStudentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Students.ToList();
            return View(values);
        }
        [HttpGet] 
        public ActionResult CreateStudent()
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
        [HttpPost]
        public ActionResult CreateStudent(Student p)
        {   
            context.Students.Add(p); 
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteClassroom(int id)
        {
            var values = context.Students.Find(id); 
            context.Students.Remove(values); 
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var values = context.Students.Find(id);
            return View();
        }
        [HttpPost] 
        public ActionResult UpdateStudent(Student p) 
        {
            var values = context.Students.Find(p.StudentId);
            values.NameSurname = p.NameSurname; 
            values.BranchID = p.BranchID; 
            context.SaveChanges();
            return RedirectToAction("Index");
        }  


    }
}