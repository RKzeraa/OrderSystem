using System.Text;

public class OrderItem
{
    private Product Product { get; set; }
    private int Quantity { get; set; }
    private double Price { get; set; }

    public OrderItem(Product product, int quantity, double price)
    {
        Product = product;
        Quantity = quantity;
        Price = price;
    }
    internal double SubTotal()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Product.ToString());
        sb.Append(", Quantity: ");
        sb.Append(Quantity.ToString());
        sb.Append(", Subtotal: ");
        sb.Append(SubTotal().ToString("C2"));
        return sb.ToString();
    }
}