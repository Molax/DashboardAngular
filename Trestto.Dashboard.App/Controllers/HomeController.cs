using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trestto.Dashboard.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<string> blablas()
        {
            List<string> lsta = new List<string>();

            lsta.Add("www");
            lsta.Add("ww32w");
            lsta.Add("www2");
            lsta.Add("www1");
            lsta.Add("wwwas");
            lsta.Add("sdasdsad");
            return lsta;
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