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
        public ActionResult Index()
        {
            int time = DateTime.Now.Hour;
            ViewBag.Greeting = time < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpPost]
        public ActionResult Index(RestaurantResponse restaurantResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("RestaurantThanks", restaurantResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
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