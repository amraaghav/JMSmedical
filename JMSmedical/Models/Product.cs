using Microsoft.AspNetCore.Mvc;

namespace JMSmedical.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal MRP { get; set; }
        public int Discount { get; set; }
        public double Rating { get; set; }
        public int Reviews { get; set; }
        public required string Badge { get; set; } // "SALE" or "BEST SELLER"
        public required string TimeLeft { get; set; } // e.g. "4 days 2 hrs"
        public required string Quantity { get; set; } // e.g. "box of 400 gm Powder"
    }

}
