using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
