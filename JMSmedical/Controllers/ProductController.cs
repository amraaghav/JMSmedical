using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
