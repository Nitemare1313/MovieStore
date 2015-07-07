﻿using ASPNETIdentity_GoogleAuthenticator.Models;
using System.Web.Mvc;

namespace IdentitySample.Controllers {

    [Audit]
    public class HomeController : Controller {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
