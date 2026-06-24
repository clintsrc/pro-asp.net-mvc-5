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


        // 2.11
        // An Action method here for /Home/RsvpForm view
        //
        // To create a strongly typed view for the RsvpForm Action method:
        //
        // *** Build the project first *** to ensure the GuestResponse class model is compiled for the strongly typeed view to use
        //
        // Solution Explorer: Right-click RsvpForm method here in the code editor:
        // Add | Add View
        // View Name: RsvpForm
        // Template: Empty   (NOTE: not 'Empty (without model)')
        // Model Class: GuestResponse
        // Leave the View Options options disabled (default)
        // Add to create the view
        //

        // 2.12-13 (see Views/Home/RvspForm.cshtml)
        public ViewResult RsvpForm()
        {
            return View();
        }
    }

}



