using Microsoft.AspNetCore.Mvc;

namespace AdminProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
