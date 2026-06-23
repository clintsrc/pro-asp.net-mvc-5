using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        // 2.8 (see the Home/Index.cshtml file)

        // 2.9 The model (or domain model) represents real world objects, processes, and rules that define the subject (domain) of the app.
        //  It contsins C# domain objects  that define the domain and the methods that manipulate them.
        //  Views and Controllers present the domain to the clients. An MVC app starts with a well-designed model to which controllers and views are added.
        //
        //  Model classes are in the Models folder by convention
        //  To create a new model in Solution Explorer: Right-click Models | Add | Class
        //  File name: GuestResponse.cs
        //  Add to create the class.
        //  (See the Models\GuestResponse.cs file)
        //
        // 2.10 see Views\Home\Index.cshtml

        // This example object stores, validates, and confirms RSVPs
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            
            // The ViewBag attribute names are arbitrary.           
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }
    }

}



