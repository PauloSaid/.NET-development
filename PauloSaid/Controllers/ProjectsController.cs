using Microsoft.AspNetCore.Mvc;

namespace Paulo_Said.Controllers
{
    public class ProjectsController : Controller
    {
        [Route("/Project")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Project/Clock")]
        public IActionResult Clock() { return View(); }
    }
}
