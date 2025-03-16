using System.ComponentModel.DataAnnotations;

namespace JMSmedical.Models
{
    public class CartItem
    {
            [Key]
            public int Id { get; set; }          // Product ID
            public required string Name { get; set; }     // Product Name
            public decimal Price { get; set; }   // Product Price
            public int Quantity { get; set; }    // Quantity of the product
            public required string ImageUrl { get; set; } // Image URL for display

    }
}
