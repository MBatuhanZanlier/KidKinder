using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;
namespace KidKinder.Controllers
{
    public class AdminBranchController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.Branches.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateBranch()
        {
     
            return View();
        }
        [HttpPost]
        public ActionResult CreateBranch(Branch p)
        {
            context.Branches.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBranch(int id)
        {
            var valu = context.Branches.Find(id);
            context.Branches.Remove(valu);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateBranch(int id)
        {
            var values = context.Branches.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateBranch(Branch p)
        {
            var values = context.Branches.Find(p.BranchID);
            values.Name = p.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailBranch(int id)
        {
            var value = context.Teachers.Where(x => x.BranchID == id).ToList();
            /* var values = context.Teachers.Where(x => x.TeacherId == id).Select(y => y.NameSurname).FirstOrDefault()*/
            ;

            return View(value);
        }
        public ActionResult DetailStudent(int id)
        {
            var value = context.Students.Where(x => x.BranchID == id).ToList();
            var tname = context.Teachers.Where(x => x.TeacherId == id).Select(y => y.NameSurname).FirstOrDefault();
            ViewBag.Tname= tname;
            return View(value);
        }
    }
}