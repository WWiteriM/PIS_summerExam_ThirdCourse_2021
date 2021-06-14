using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Exam_Task_2.Controllers
{
    public class FitController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            ViewBag.Message = Request.Params.Get("s");
            return View();
        }

        [HttpGet]
        public ActionResult GetParm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ParmSave(string press)
        {
            if (press == "Add")
            {
                ViewBag.x = Request.Params.Get("x");
                ViewBag.s = Request.Params.Get("s");
                ViewBag.d = Request.Params.Get("d");

                return View();
            } else
            {
                return RedirectToAction("Index");
            }
        }
    }
}