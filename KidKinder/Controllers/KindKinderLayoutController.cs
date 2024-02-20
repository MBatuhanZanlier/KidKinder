using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class KindKinderLayoutController : Controller
    {
        // GET: KindKinderLayout
        public ActionResult _Layout()
        {
            return View();
        }


        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult _PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult _PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult _PartialScripts()
        {
            return PartialView();
        }
    } 

}