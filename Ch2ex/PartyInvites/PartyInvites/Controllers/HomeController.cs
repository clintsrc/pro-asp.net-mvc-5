using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;   // Controller base class

// MVC: Models (data and business logic), Views (UI HTML rendering), Controllers (routes traffic: receives input
//  requests, fetches from the Models, forwards to Views for rendering).
//  The Razor engine renders the View

// IIS Express is a lightweight version of IIS that ships with VisualStudio to run and test web apps locally.
//  Just click the IIS Express button with the browser fo your choice selected. It automatically stops when you close the browser.
//  IIS assigns the app a random port when you create the project (e,g, https://localhost:44343/ in .vs/<app_name>/config/applicationhost.config)


// Controllers handle incoming requests: they are C# classes that inherit from the built-in Controller base class.
namespace PartyInvites.Controllers
{
    // Follow the convention to use NameController
    // Visual Studio automaticaly handles some of the code functionality as long as conventions are followed.
    // To add new Controllers to the project: Solution Explorer: Right-click Controllers, Add | Controller
    
    // Home[Controller] is the default controller that supports these routes by default:
    //  /
    //  /Home
    //  /Home/Index

    public class HomeController : Controller
    {
        // Action method: public method invoked by a web URL to perform an action

        // 2.1
        // This is a stripped down version of the template's default action method.
        // public ActionResult Index()
        // {
        //     return View();
        // }


        // 2.2
        // This example returns a string instead of HTML
        // public string Index()
        // {
        //     return "Hello World";
        // }


        // 2.3
        // A view provides an HTML response
        // To add Views to Action methods: Right-click method name directly in the code editor, Add View
        //   Common | MVC | View, Add
        //   View Name: Follow the convention to set this to the name of the action method that the view will be associated with (Index here)
        //   Template: set to Empty (without model)
        //   Options:
        //   Create as a partial view: disabled (default)
        //   Use a layout page: disabled
        //   Click Add
        // This will create the new View file at: Views/Home/Index.cshtml
        // The convention is that the view has the name of the action method and is contained in a folder named after the controller: /Views/Home/Index.cshtml
        public ViewResult Index()
        {
            // The View method returns a ViewResult
            return View();
        }
    }

}