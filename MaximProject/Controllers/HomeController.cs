using Microsoft.AspNetCore.Mvc;

namespace MaximProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
