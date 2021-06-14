using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Exam_Task_5.Controllers
{
    [Route("Fit/{action}")]
    public class FITController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string s)
        {
            ViewBag.s = s;
            return View();
        }

        [HttpGet]
        public IActionResult GetParm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ParmSave(int x, string s, DateTime d, string press)
        {
            if (press == "ok")
            {
                ViewBag.x = x;
                ViewBag.s = s;
                ViewBag.d = d;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
