using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Newtonsoft.Json;

namespace John_s_Portfolio.Controllers
{

    //Each Page need to be declared as a function in the below class
    public class ProjectsController : Controller
    {

        //Python Projects Page
        public IActionResult Index()
        {   
          return View();
        }

        //Skyrim Modlist Page
        public IActionResult SkyrimModlist()
        {
            return View();
        }
    }
}
