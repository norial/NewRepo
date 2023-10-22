public class Product
{
    public int Id { get; set; } //product ID
    public string Name { get; set; } // product name
    public double Price { get; set; } // product price

    // Product ctor
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}