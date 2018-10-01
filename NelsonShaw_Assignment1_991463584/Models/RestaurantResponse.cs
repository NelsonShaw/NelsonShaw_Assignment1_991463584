// Import the basic libraries.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Import the data annotations in the event of information input error.
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents the model namespace.
/// </summary>
namespace NelsonShaw_Assignment1_991463584.Models
{
    /// <summary>
    /// Represents the restaurant information to be read from the guest.
    /// </summary>
    public class RestaurantResponse
    {
        /// <summary>
        /// Represents the name of the restaurant.
        /// </summary>
        [Required(ErrorMessage = "Please select a restaurant")]
        public string Name { get; set; }
    }
}