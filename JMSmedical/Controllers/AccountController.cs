using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        // ✅ Handle Login Form Submission
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "amraaghav" && password == "1611")  // Dummy credentials
            {
                HttpContext.Session.SetString("Username", username);  // ✅ Store username in session
                return RedirectToAction("Profile");  // ✅ Redirect to Profile page
            }

            ViewBag.Error = "Invalid username or password!";
            return View();
        }

        // ✅ Profile Page - Check if Logged In
        public IActionResult Profile()
        {
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login"); // ✅ Redirect to login if not authenticated
            }

            ViewBag.Username = username;
            return View();
        }

        // ✅ Logout - Clear Session
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // ✅ User Profile Page
        public IActionResult UserProfile()
        {
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login"); // ✅ Redirect to login if not authenticated
            }

            ViewBag.Username = username;
            return View();
        }
        // ✅ Orders Page
        public IActionResult Orders()
        {
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login"); // ✅ Redirect to login if not authenticated
            }

            // Dummy Order Data (Replace with DB logic)
            ViewBag.Orders = new List<string>
            {
                "Order #1234 - Medicine A",
                "Order #5678 - Medicine B",
                "Order #9101 - Medicine C"
            };

            return View();
        }
    }
}
