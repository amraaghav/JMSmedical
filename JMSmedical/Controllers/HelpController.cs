using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Help()
        {
            return View();
        }
    }
}
