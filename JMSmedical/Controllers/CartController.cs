using JMSmedical.Data.Helpers;
using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;
using static JMSmedical.Models.CartItem;

namespace JMSmedical.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("cart") ?? new List<CartItem>();
            return View(cart);
            
        }

        public IActionResult AddToCart(int id, string name, decimal price, string imageUrl)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("cart") ?? new List<CartItem>();

            var existingItem = cart.FirstOrDefault(p => p.Id == id);
            if (existingItem != null)
            {
                existingItem.Quantity++; // Increase quantity if exists
            }
            else
            {
                cart.Add(new CartItem { Id = id, Name = name, Price = price, Quantity = 1, ImageUrl = imageUrl });
            }

            HttpContext.Session.SetObjectAsJson("cart", new List<CartItem>());


            return RedirectToAction("Cart");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(p => p.Id == id);
            if (item != null)
            {
                cart.Remove(item);
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            return RedirectToAction("Cart");
        }

        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove("cart");
            return RedirectToAction("Cart", "Cart");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
