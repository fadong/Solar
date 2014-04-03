using Galaxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galaxy.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Cabalt(장외파생상품 시스템)";

            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Cabalt는 장외파생상품 시스템입니다.";
            AboutModels mdl = new AboutModels();
            return View(mdl);
        }

        public ActionResult Contact() {
            ViewBag.Message = "jaekyoon.lee@gmail.com";

            return View();
        }
    }
}
