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
using PartyInvites.Models;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

// 2.21
// Install the Bootstrap NuGet package for client styling.
// NuGet UI: Tools | Library Package Manager | Manage NuGet Packages for Solution
// NuGet CLI: Tools | Library Package Manager | Package Manager Console
// Example bootstrap install:
// Download the package and add it to the project:
// e.g.latest:
// Install - Package bootstrap
// e.g.v3.0.0:
// Install - Package - version 3.0.0 bootstrap

// See Views/Home/Index.cshtml

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

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // Check for input validation errors
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else {
                // report validation errors
                return View();
            }

        }
    }

}
