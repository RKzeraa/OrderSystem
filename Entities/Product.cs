public class Product {
    private string? Name { get; set; }
    private double Price { get; set; }

    public Product() {

    }

    public Product(string name, double price) {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}, ${Price.ToString("F")}";
    }
}