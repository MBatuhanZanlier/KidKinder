using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
            KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        } 

       public PartialViewResult GalleryHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult GalleryPartial()
        {  
            var values=context.Galleries.Where(x => x.Status==true).ToList();
            return PartialView(values);
        }
    }
}