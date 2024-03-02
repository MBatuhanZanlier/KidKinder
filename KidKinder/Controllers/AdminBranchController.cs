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
        KidKinderContext context =new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.branches.ToList(); 
            return View(value);
        }
    }
}