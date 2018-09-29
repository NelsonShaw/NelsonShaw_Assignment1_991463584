using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NelsonShaw_Assignment1_991463584.Models
{
    public class RestaurantResponse
    {
        [Required(ErrorMessage = "Please select a restaurant")]
        public string RestaurantName { get; set; }
    }
}