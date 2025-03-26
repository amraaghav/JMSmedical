using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
