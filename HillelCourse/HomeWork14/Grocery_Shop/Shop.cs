using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop
{
    public class Shop
    {
        private List<Product> products; // List of available products

        public Shop()
        {
            products = new List<Product>();
        }

        // Method for adding a product to a store's assortment
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Method for deleting a product by identifier
        public void RemoveProduct(int productId)
        {
            Product productToRemove = products.Find(p => p.Id == productId);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
            else
            {
                Console.WriteLine("Product with the specified identifier was not found.");
            }
        }

        // Method for retrieving a product by identifier
        public Product GetProductById(int productId)
        {
            return products.Find(p => p.Id == productId);
        }

        // Method for obtaining a list of all products
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
