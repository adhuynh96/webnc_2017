using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAdvance.Session3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetById(int? id)
        {
            ViewBag.ID = id;
            return View();
        }
        [HttpGet]
        public ActionResult GetProductName()
        {
            return Content("Iphone 7");
        }

        [HttpGet]
        public ActionResult GetProductJson()
        {
            var product = new { Name = "Iphone 7", Price = 700 };
            return base.Json(product,JsonRequestBehavior.AllowGet);
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult StatusCode(int id)
        {
            if (id == 1)
            {
                return Content("You are logged in");
            }
            else
            {
                return new HttpUnauthorizedResult();
            }
            
        }


    }
}