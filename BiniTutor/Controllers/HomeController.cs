using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiniTutor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize] //Accessed by all registered users
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //[Authorize(Roles ="Superuser")] //Accessed by Super users
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}