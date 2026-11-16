using Microsoft.AspNetCore.Mvc;

namespace Lab9CookieApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (username == "suman" &&
                password == "suman123")
            {
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddDays(5),
                    HttpOnly = true,
                    Secure = HttpContext.Request.IsHttps,
                    IsEssential = true,
                    SameSite = SameSiteMode.Lax
                };

                Response.Cookies.Append(
                    "Username", username, options);

                return RedirectToAction("Welcome");
            }

            ViewBag.Error = "Invalid username or password";

            return View();
        }

        public IActionResult Welcome()
        {
            string username = Request.Cookies["Username"];

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login");
            }

            ViewBag.Username = username;

            return View();
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("Username");

            return RedirectToAction("Login");
        }
    }
}