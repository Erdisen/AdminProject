using Microsoft.AspNetCore.Mvc;

namespace AdminProject.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet("customer/detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            return View();
        }

        [HttpGet("customer/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
