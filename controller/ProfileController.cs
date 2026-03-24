using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LecturreActivity2.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}