using Microsoft.AspNetCore.Mvc;

namespace John_s_Portfolio.Controllers
{
    public class OtherStuffController : Controller
    {

        //This File functions of pages that will contain little gizmos that I have created
        //specifically for the portfolio.
        public IActionResult Index()
        {
            return View();
        }
    }
}
