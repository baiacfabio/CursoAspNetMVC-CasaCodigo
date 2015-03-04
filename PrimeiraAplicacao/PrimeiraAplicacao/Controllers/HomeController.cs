using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAplicacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Minha primeira aplicação com ASP.NET MVC";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descrição da aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de Contato.";

            return View();
        }
    }
}
