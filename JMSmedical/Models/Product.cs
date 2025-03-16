using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Models
{
    public class Product
    {

        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public string? Id { get; internal set; }
    }
}
