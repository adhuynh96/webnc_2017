using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Session2.Models;

namespace WebAdvance.Session2.Controllers
{
    public class HomeController : Controller
    {
        private int numberExample=0;
        // GET: Home
        public ActionResult Index()
        {
            numberExample += 1;
            ViewBag.NumberExample = numberExample;
            ViewBag.Student = "Thuc";      
            return View();
        }

        public string Hello()
        {
            ViewBag.Student = "Thuc";
            return "Hello";
        }
        [HttpGet]
        public ActionResult RSVPForm()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult RSVPForm(GuestResponse response)
        {
            return View("Thanks", response);
        }
    }
}