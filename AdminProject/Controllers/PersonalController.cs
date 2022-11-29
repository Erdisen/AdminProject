using Microsoft.AspNetCore.Mvc;

namespace AdminProject.Controllers
{
    
    public class PersonalController : Controller
    {
        [HttpGet("personal/detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            return View();
        }

        [HttpGet("personal/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
