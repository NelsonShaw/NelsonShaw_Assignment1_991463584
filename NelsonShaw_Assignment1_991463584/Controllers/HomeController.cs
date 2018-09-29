using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NelsonShaw_Assignment1_991463584.Models;

namespace NelsonShaw_Assignment1_991463584.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int time = DateTime.Now.Hour;
            ViewBag.Greeting = time < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}