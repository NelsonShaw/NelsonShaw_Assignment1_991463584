using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NelsonShaw_Assignment1_991463584.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int time = DateTime.Now.Hour;
            ViewBag.Greeting = time < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}