using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class SignupController : Controller
    {
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid )
            {
                // Add authentication logic here
                return RedirectToAction("Login", "Login"); // Redirect after successfully Signup
            }
            {
                return View(model);
            }
        }
    }
}
