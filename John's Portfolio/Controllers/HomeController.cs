using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using John_s_Portfolio.Models;

namespace John_s_Portfolio.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    //Creates a new page called Index(Shows this page by default when loaded up)
    public IActionResult Index()
    {
        var DetailsLayer= new DetailsLayer();
        Details details = DetailsLayer.GetDetails(Id:1);
        return View(details);
    }


    // Creates a new page called Privacy(To view this page, either enter: https://localhost:7039/Home/Privacy
    // or click on the Privacy link on the Default Page)
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
