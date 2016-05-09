using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class YearMonthDayController : Controller
    {
        // GET: YearMonthDay
        public ActionResult YearMonthDay()
        {
            YearMonthDay YMD = new YearMonthDay();
            return View(YMD);
        }
    }
}