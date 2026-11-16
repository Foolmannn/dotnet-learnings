using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Lab8AuthApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content("Welcome to the Home Page!");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return Content("Welcome Admin!");
        }

        [Authorize(Roles = "User")]
        public IActionResult User()
        {
            return Content("Welcome User");
        }
    }
}