using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Admin(AdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add authentication logic here
                return RedirectToAction("", ""); // Redirect after successfully Signup
            }
            {
                return View(model);
            }
        }
    }
}
