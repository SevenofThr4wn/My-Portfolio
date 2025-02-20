using Microsoft.AspNetCore.Mvc;

namespace John_s_Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
