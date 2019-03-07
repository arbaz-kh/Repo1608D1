using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(FormCollection fm)
        {
            string name = fm["txtname"];
            ViewBag.nm = name;
            return View("Welcome");
        }

        public ActionResult Welcome()
        {            
            return View();
        }
    }
}