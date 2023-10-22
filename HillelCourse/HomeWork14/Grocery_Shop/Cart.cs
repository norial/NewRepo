using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop
{
    public class Cart
    {
        private List<Product> cartItems; // List of products in the shopping cart

        public Cart()
        {
            cartItems = new List<Product>();
        }

        // Method for adding a product to your cart
        public void AddToCart(Product product)
        {
            cartItems.Add(product);
        }

        // Method for removing a product from the cart by ID
        public void RemoveFromCart(int productId)
        {
            Product productToRemove = cartItems.Find(p => p.Id == productId);
            if (productToRemove != null)
            {
                cartItems.Remove(productToRemove);
            }
            else
            {
                Console.WriteLine("The product with the specified ID is not found in the cart.");
            }
        }

        // Method for calculating the total price of all products in the basket
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in cartItems)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public List<Product> GetCartItems()
        {
            return cartItems;
        }
    }
}
