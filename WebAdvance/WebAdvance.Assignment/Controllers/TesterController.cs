using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Assignment.Models;

namespace WebAdvance.Assignment.Controllers
{
    public class TesterController : Controller
    {
        [HttpGet]
        // GET: Tester
        public ActionResult Index()
        {
            Tester tester = new Tester();             
            return View(tester);
        }

        [HttpPost]
        public ActionResult Index(Tester tester)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Tester" + tester.UserName + " is added";
            }
            return View(tester);
        }
    }
}