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
            EntityModel entities = new EntityModel();

            // Testando apenas com a user Ana Luisa (LINQ)
            var LoggedUser = entities.User.FirstOrDefault(x => x.Name == "Ana Luisa");
            ViewBag.LoggedUser = LoggedUser;

            // Trazendo entidades matched (LINQ)
            var matches = entities.UserMatch.Where(x => x.UserId == LoggedUser.Id).ToList();

            // Preenchendo entidades (metodo de extensao)
            foreach(var match in matches)
            {
                match.FillData();
            }

            return View("~/Views/SearchForPeople.cshtml", matches);
        }

        public ActionResult MyProfile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SearchForPeople()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}