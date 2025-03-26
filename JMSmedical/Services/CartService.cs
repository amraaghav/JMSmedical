using JMSmedical.Models;
using System.Collections.Generic;
using System.Linq;

namespace JMSmedical.Controllers
{
    public class CartService
    {
        private List<CartItem> _cartItems = new List<CartItem>();

        public List<CartItem> GetCartItems() => _cartItems;

        public void AddToCart(CartItem item)
        {
            var existingItem = _cartItems.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _cartItems.Add(item);
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            var item = _cartItems.FirstOrDefault(i => i.Id == id);
            if (item != null && quantity > 0)
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(int id)
        {
            _cartItems.RemoveAll(i => i.Id == id);
        }

        public decimal GetTotalPrice() => _cartItems.Sum(item => item.Price * item.Quantity);
    }
}
