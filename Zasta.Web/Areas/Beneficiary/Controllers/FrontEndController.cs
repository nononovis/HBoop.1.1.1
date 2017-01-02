using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;

namespace Zasta.Web.Areas.Beneficiary.Controllers
{
    public class FrontEndController : Controller
    {
        public ActionResult LoginClient()
        {
            return View();
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult Panier() {
            return View();
        }

        public ActionResult Paiement() {
            return View();
        }

        public ActionResult Parametre()
        {
            return View();
        }

        public ActionResult Historique_Reservation()
        {
            return View();
        }

        public ActionResult Detail_Reservation()
        {
            return View();
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

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Infos_salon_mobile()
        {
            return View();
        }

        public ActionResult Infos_Salon()
        {
            return View();
        }
    }
}