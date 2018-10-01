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
    /// Represents the guest information to be processed for restaurant party reservations.
    /// </summary>
    public class GuestResponse
    {
        /// <summary>
        /// Represents the name of the guest.
        /// </summary>
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        /// <summary>
        /// Represents the email of the guest.
        /// </summary>
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        /// <summary>
        /// Represents the phone number of the guest.
        /// </summary>
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        /// <summary>
        /// Represents the number of friends that the guest is bringing or knows their coming.
        /// </summary>
        [Required(ErrorMessage = "Please enter a number")]
        [RegularExpression(@"^[0-9]*$", 
            ErrorMessage = "Please enter a number")]
        public string NumberOfFriends { get; set; }

        /// <summary>
        /// Represents whether the guest will attend or not.
        /// </summary>
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}