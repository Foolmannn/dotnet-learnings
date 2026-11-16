using Lab7PlayerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace PlayerApp.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message =
                    "Player information saved successfully!";

                ModelState.Clear();

                return View();
            }

            return View(player);
        }
    }
}