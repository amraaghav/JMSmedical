using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Log or save data (e.g., send email, store in DB)
                TempData["SuccessMessage"] = "Message sent successfully!";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
