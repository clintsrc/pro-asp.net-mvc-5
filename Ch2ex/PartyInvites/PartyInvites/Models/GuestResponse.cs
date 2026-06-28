using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;    // import declarative for standard validation rules

namespace PartyInvites.Models
{

    // 2.16
    // Input validation is applied in the domain model instead of the UI so that
    //   validation is handled in one place, and applied wherever the model is used.

    // 2.17 (see Controllers/HomeControllers.cshtml)
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")] // MVC detects these and automatically validate data during the model-binding process
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        // A nullable boolean ("bool?") can be true, false or null.
        // The value will be null, which will trigger a validation error unless
        //   the user makes a selection.
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}