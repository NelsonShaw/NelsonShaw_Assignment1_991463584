// Import the basic libraries.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Import the models in order to transfer them between views.
using NelsonShaw_Assignment1_991463584.Models;

/// <summary>
/// Represents the controller namespace.
/// </summary>
namespace NelsonShaw_Assignment1_991463584.Controllers
{
    /// <summary>
    /// Represents a main controller that manages multiple pages.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Represents a method that will display the home page upon program startup.
        /// </summary>
        /// <returns>Represents an action result that will display the home view.</returns>
        public ActionResult Index()
        {
            // Get the current time and store the string result to transfer to the view depending on the time of day.
            int time = DateTime.Now.Hour;
            ViewBag.Greeting = time < 12 ? "Good Morning" : "Good Afternoon";

            // Display the home page.
            return View();
        }

        /// <summary>
        /// Represents a method that will take the restaurant response and send it to the Restaurant Thanks view.
        /// </summary>
        /// <param name="restaurantResponse">Represents the restaurant response received.</param>
        /// <returns>Represents the action result that will either stay on the home view or transfer the model to the Restaurant Thanks view.</returns>
        [HttpPost]
        public ActionResult Index(RestaurantResponse restaurantResponse)
        {
            // Check to see if the restaurant information is valid.
            if (ModelState.IsValid)
            {
                // If the information is valid, send the resonse to the Restaurant Thanks view.
                return View("RestaurantThanks", restaurantResponse);
            }
            else
            {
                // Otherwise, there is a validation error.
                return View();
            }
        }

        /// <summary>
        /// Represents a method that will retrieve an HttpGet request and display the rsvp form.
        /// </summary>
        /// <returns>Represents an action result to display the rsvp.</returns>
        [HttpGet]
        public ActionResult RsvpForm()
        {
            // Display the rsvp form.
            return View();
        }

        /// <summary>
        /// Represents a method that will take the guest response and send it to the Thanks view.
        /// </summary>
        /// <param name="guestResponse">Represents the guest information to be submitted.</param>
        /// <returns>Represents an action result that will either keep the user on the rsvp form or will send the user to the Thanks view.</returns>
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            // Check to see if the guest response is valid.
            if (ModelState.IsValid)
            {
                // If the information is valid, send the guest information to the thanks view.
                return View("Thanks", guestResponse);
            }
            else
            {
                // Otherwise, there was a validation error.
                return View();
            }
        }
    }
}