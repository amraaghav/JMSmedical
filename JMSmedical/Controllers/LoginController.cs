using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add authentication logic here
                return RedirectToAction("Main", "Main"); // Redirect after successful login
            }

            return View(model);
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

    }
}