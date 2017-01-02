using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zasta.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getInfoSalon()
        {
            return PartialView("informationsalon");
        }

        public ActionResult getInfoSalonMobile()
        {
            return PartialView("infosalon");
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Plan()
        {
            return View();
        }

        public ActionResult Qui_sommes_nous()
        {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }

        public ActionResult Mot_de_passe_oublie()
        {
            return View();
        }

        public ActionResult Infos_salon_mobile()
        {
            return View();
        }

        public ActionResult Infos_salon()
        {
            return View();
        }

    }
}