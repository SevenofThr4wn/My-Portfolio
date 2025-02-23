using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace John_s_Portfolio.Controllers
{
    //Change the name of this controller to suit your needs. 

    //Additionally, change the name of the folder 'Projects' to one that suits your needs.

    //Add functions below so you are able to view the newly added pages. 
    public class ProjectsController : Controller
    {
        //Creates a new page called Index(to view this page enter:
        //https://localhost:7039/Projects into the URL page)
        public IActionResult Index()
        {
            return View();
        }

        //Creates a new page called SkyrimModlist(to view this page enter:
        //https://localhost:7039/Projects/SkyrimModlist/ into the URL bar)

        //Change the name of this function to one that suites your needs

        public IActionResult SkyrimModlist()
        {
            return View();
        }
    }
}
