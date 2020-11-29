using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstruturasDeNamoro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Entities entities = new Entities();
            var test = entities.User.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}