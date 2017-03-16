using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Assignment.Core.Interfaces;
using WebAdvance.Assignment.Core.Membership;

namespace WebAdvance.Assignment.Controllers
{
    public class TesterController : Controller
    {
        private ITesterRepository _testerRepsitory;
        private IUnitOfWork _unitOfWork;
        public TesterController(ITesterRepository testerRepsitory,
                                 IUnitOfWork unitOfWork)
        {
            _testerRepsitory = testerRepsitory;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(_testerRepsitory.GetTesters());
        }
        [HttpGet]
        // GET: Tester
        public ActionResult Create()
        {
            //
            //
            //
            Tester tester = new Tester();             
            return View(tester);
        }

        [HttpPost]
        public ActionResult Create(Tester tester)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Tester" + tester.UserName + " is added";
                _testerRepsitory.Add(tester);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Input is invalid";
                return View(tester);
            }
            
        }
    }
}