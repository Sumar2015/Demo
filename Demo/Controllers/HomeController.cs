using Demo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Information about this final project.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information.";

            return View();
        }
    }
}