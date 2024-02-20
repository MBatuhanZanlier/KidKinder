using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
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
            return PartialView();
        }
    }
}