using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
