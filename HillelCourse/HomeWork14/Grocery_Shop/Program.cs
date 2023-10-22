namespace Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем магазин и добавляем в него некоторые продукты
            Shop shop = new Shop();
            shop.AddProduct(new Product(1, "Bread", 2.0));
            shop.AddProduct(new Product(2, "Milk", 1.5));
            shop.AddProduct(new Product(3, "Eggs", 2.2));
            shop.AddProduct(new Product(4, "Juice", 3.0));

            // Создаем корзину для клиента
            Cart cart = new Cart();

            while (true)
            {
                Console.WriteLine("Available products:");
                List<Product> products = shop.GetAllProducts();
                foreach (Product product in products)
                {
                    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}$");
                }

                Console.WriteLine("Select action:");
                Console.WriteLine("1. Add product to cart");
                Console.WriteLine("2. Remove product from cart");
                Console.WriteLine("3. View the total cost in the cart");
                Console.WriteLine("4. View the products in the cart");
                Console.WriteLine("5. Complete the purchase");
                Console.Write("Enter action number: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the product ID to add to cart: ");
                            if (int.TryParse(Console.ReadLine(), out int productId))
                            {
                                Product productToAdd = shop.GetProductById(productId);
                                if (productToAdd != null)
                                {
                                    cart.AddToCart(productToAdd);
                                    Console.Clear();
                                    Console.WriteLine("Product added to cart.");
                                }
                                else
                                {
                                    Console.WriteLine("The product with the specified ID was not found.");
                                }
                            }
                            break;

                        case 2:
                            Console.Write("Enter the product ID to remove from the cart: ");
                            if (int.TryParse(Console.ReadLine(), out int productToRemoveId))
                            {
                                cart.RemoveFromCart(productToRemoveId);
                                Console.Clear();
                                Console.WriteLine("The product has been removed from the cart.");
                            }
                            break;

                        case 3:
                            double totalPrice = cart.GetTotalPrice();
                            Console.Clear();
                            Console.WriteLine($"Total cost of products in cart: {totalPrice}");
                            break;

                        case 4:
                            List<Product> cartItems = cart.GetCartItems();
                            if (cartItems.Count > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Products in cart:");
                                foreach (Product product in cartItems)
                                {
                                    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Your shopping cart is empty.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("The purchase is complete. Press Enter to exit");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select an action from the list.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please select an action from the list.");
                }

                Console.WriteLine();
            }
        }
    }
}