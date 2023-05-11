public class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public OrderItem(Product product, int quantity, double price)
    {
        Product = product;
        Quantity = quantity;
        Price = price;
    }
    public double SubTotal()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return $"{Product.ToString()}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F")}";
    }
}