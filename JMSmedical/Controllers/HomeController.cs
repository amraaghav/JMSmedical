using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace JMSmedical.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Categories = new List<Category>
                {
                    new Category { Id = 1,  Name = "Diabetes", ImageUrl = "/Images/Diabetes.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder" },
                    new Category { Id = 2, Name = "Bone, Joint & Muscle Care", ImageUrl = "/Images/Bone.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder" },
                    new Category { Id = 3, Name = "Derma Care", ImageUrl = "/Images/Derma Care.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder"},
                    new Category { Id = 4, Name = "Stomach Care", ImageUrl = "/Images/Stomach Care.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder" },
                    new Category { Id = 5, Name = "Liver Care", ImageUrl = "/Images/Liver Care.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder"},
                    new Category { Id = 6, Name = "Heart Care", ImageUrl = "/Images/Heart Care.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder"}
                },
                WinterEssentials = new List<Products>
                {
                    new Products { Id=7, Name = "Zandu Chyavanprash", ImageUrl = "/Images/Chyavanprash.jpg", Price = 278, MRP = 300, Discount = 7, Rating = 4.2, Reviews = 250, Badge = "", TimeLeft = "", Quantity = "500gm bottle" },
                    
                },
                Products = new List<Product>
                {
                    new Product { Id = 1, Name = "Zandu Chyavanprash", ImageUrl = "/Images/Chyavanprash.jpg", Price = 676, MRP = 760, Discount = 11, Rating = 4.3, Reviews = 575, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "box of 400 gm Powder" },
                    new Product { Id = 2, Name = "Patanjali Ayurveda Special Chyawanprash", ImageUrl = "/Images/Patanjali chayawanprash.jpg", Price = 983, MRP = 1199, Discount = 18, Rating = 4.0, Reviews = 1707, Badge = "", TimeLeft = "", Quantity = "packet of 1 Kit" },
                    new Product { Id = 3, Name = "Tetley Green Tea", ImageUrl = "/Images/GreenTea.jpg", Price = 285, MRP = 335, Discount = 15, Rating = 4.4, Reviews = 1532, Badge = "BEST SELLER", TimeLeft = "", Quantity = "bottle of 1 Ltr Juice" },
                    new Product { Id = 4, Name = "Sri Sri Tattva Natural Honey", ImageUrl = "/Images/Honey.jpg", Price = 1551, MRP = 1825, Discount = 15, Rating = 4.5, Reviews = 900, Badge = "SALE", TimeLeft = "4 days 2 hrs", Quantity = "combo pack of 2 Packs" },
                    new Product { Id = 8, Name = "Zandu Pure Honey", ImageUrl = "/Images/Zandu honey.jpg", Price = 350, MRP = 400, Discount = 12, Rating = 4.5, Reviews = 400, Badge = "BEST SELLER", TimeLeft = "", Quantity = "1kg bottle" }
                }
            };

            return View(model);
        }

        public IActionResult Medicines()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        } 
    }
}
