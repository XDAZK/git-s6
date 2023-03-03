using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranCongMinh_1911060177.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "PhungXuanDoan_clone";
            ViewBag.Message = "PhungXuanDoan_1911065522";
            ViewBag.Message = "Câu 17";
            ViewBag.Message = "thay đoi file bat ki"
            return View();
        }
    }
}