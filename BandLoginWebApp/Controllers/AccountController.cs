using Microsoft.AspNetCore.Mvc;

namespace BandLoginWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
          
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        public IActionResult Logout()
        {
          
            return RedirectToAction("Login");
        }
    }
}
