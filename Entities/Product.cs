using System.Text;

public class Product {
    private string? Name { get; set; }
    private double Price { get; set; }

    public Product(string name, double price) {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Name + ", ");
        sb.Append(Price.ToString("C2"));

        return sb.ToString();
    }
}