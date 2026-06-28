using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.EnterpriseServices;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Antlr.Runtime.Misc;
using Microsoft.Ajax.Utilities;
using PartyInvites.Models;  // 2.14 import the models to simplify reference to the GuestResponse class
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }

        // 2.12-13 see Views/Home/RsvpForm.cshtml

        // 2.14
        // By default a form will handle both GET and POST HTTP requests:
        //   when the form recieves a POST response it simply calls the RsvpForm action method again 
        //   and reloads the same view.
        //   
        [HttpGet]   // Now the RsvpForm action method will only specifically handle GET requests
        public ViewResult RsvpForm()
        {
            return View();
        }

        // This overloaded RsvpForm method will only handle POST requests
        // It recieves the guestResponse data and applies the HttpPost attribute.
        // You need to create this Thanks (as before, right-click one of the methods in the code editor):
        // Add | Add View
        // View Name: Thanks
        // Template: Empty   (NOTE: not 'Empty (without model)')
        // Model Class: GuestResponse
        // Leave the View Options options disabled (default)
        // Add to create the view

        // This post method will now:
        // - find the render the "Thanks" view.
        // - pass the GuestResponse object to the view

        // 2.15-16 see Views/Home/Thanks.cshtml
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // 2.17
            // Check for input validation errors
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else {
                // report validation errors

                // 2.18 see Views/Home/RsvpForm.cshtml
                return View();
            }

        }
    }

}
