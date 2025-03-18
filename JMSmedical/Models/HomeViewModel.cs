using JMSmedical.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Models
{
    public class HomeViewModel
    {
        public required List<Category> Categories { get; set; }
        public required List<Product> Products { get; set; }
        internal List<Products>? WinterEssentials { get; set; }
    }
}
