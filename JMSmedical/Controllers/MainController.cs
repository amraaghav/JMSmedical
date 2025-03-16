using JMSmedical.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Main()
        {
            var model = new MainViewModel
            {
                Categories = new List<Category>
                {
                    new Category { Id="1", Name = "Diabetes", ImageUrl = "wwwroot/Images/Diabetes.jpg" },
                    new Category { Id="2", Name = "Bone, Joint & Muscle Care", ImageUrl = "wwwroot/Images/Bone.jpg" },
                    new Category { Id="3", Name = "Derma Care", ImageUrl = "wwwroot/Images/Derma Care.jpg" },
                    new Category { Id="4", Name = "Stomach Care", ImageUrl = "wwwroot/Images/Stomach Care.jpg" },
                    new Category { Id="5", Name = "Liver Care", ImageUrl = "wwwroot/Images/Liver Care.jpg" },
                    new Category { Id="6", Name = "Heart Care", ImageUrl = "wwwroot/Images/Heart Care.jpg" }
                },
                WinterEssentials = new List<Product>
                {
                    new Product { Id="7", Name = "Zandu Chyavanprash", ImageUrl = "wwwroot/Images/Chyavanprash.jpg" },
                    new Product { Id="8", Name = "Patanjali Ayurveda Special Chyawanprash", ImageUrl = "wwwroot/Images/Patanjali ChyaVanprash.jpg" },
                    new Product { Id="9", Name = "Tetley Green Tea", ImageUrl = "wwwroot/Images/GreenTea.jpg" },
                    new Product { Id="10", Name = "Sri Sri Tattva Natural Honey", ImageUrl = "wwwroot/Images/Honey.jpg" },
                    new Product { Id="11", Name = "Zandu Pure Honey", ImageUrl = "wwwroot/Images/Zandu honey.jpg" }
                }
            };

            return View(model);
        }
    }
}

