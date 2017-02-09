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
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Student = "Thuc";      
            return View();
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